using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using LiveCharts.Defaults;

namespace ValtrighExchange
{
    public partial class Form2 : Form
    {
        static double value;
        public static object valtrighe = new object();
        Thread[] t = new Thread[10];
        SeriesCollection seriesViews = new SeriesCollection();
        LineSeries andamento = new LineSeries { Values = new ChartValues<double>() };
        Axis asseY;
        public Form2(string Name, string Cognome)
        {
            InitializeComponent();
            value = 1000;
            Nome.Text = Name + " " + Cognome;
            Grafico.Series.Add(andamento);
            asseY = new Axis();
            asseY.Title = "Valore";
            Grafico.DisableAnimations = true;
            Grafico.AxisY.Add(asseY);
            andamento.Values.Add(value);
        }

        public void AggiornaPrezzo(string NuovoPrezzo)
        {
            valore_attuale.Text = NuovoPrezzo;
        }

        public void ThreadProc()
        {
            while (true)
            {
                lock (valtrighe)
                {
                    Random rnd = new Random();
                    int rand1 = rnd.Next(2);

                    if (value >= 0)
                    {
                        double rand2 = rnd.NextDouble();
                        if (rand1 == 0)
                        {
                            value += rand2;
                            //0001 ha comprato rand2 azioni
                        }
                        else
                        {
                            value -= rand2;
                            //0001 ha venduto rand2 azioni
                        }
                    }
                    else
                        valore_attuale.Text = "La valuta è crollata";

                    Thread.Sleep(1000);
                }
                if (valore_attuale.IsHandleCreated)
                {
                    valore_attuale.Invoke(new Action(() => valore_attuale.Text = value.ToString()));                    
                }     
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                t[i] = new Thread(new ThreadStart(ThreadProc));
                t[i].Start();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
                t[i].Abort();
            Application.Exit();
        }

        private void Orologio_Tick(object sender, EventArgs e)
        { AggiornaOra(); }

        private void AggiornaOra()
        { Data.Text = DateTime.Now.ToString("G"); }

        private void valore_attuale_TextChanged(object sender, EventArgs e)
        {
            double valore = Convert.ToDouble(valore_attuale.Text);

            if (valore < asseY.ActualMinValue || valore > asseY.ActualMaxValue)
                Grafico.DisableAnimations = false;

            andamento.Values.Add(Convert.ToDouble(valore_attuale.Text));
            
            if (andamento.Values.Count > 2)
            {
                if (Convert.ToDouble(andamento.Values[andamento.Values.Count - 2]) < Convert.ToDouble(andamento.Values[andamento.Values.Count - 1]))
                    andamento.Stroke = System.Windows.Media.Brushes.SpringGreen;
                else
                    andamento.Stroke = System.Windows.Media.Brushes.Red;
            }
            
            if (andamento.Values.Count > 10)
                andamento.Values.Remove(andamento.Values[0]);
        }
    }

    class Utente
    {
        string ID;
        string nome;
        string cognome;
        Portafoglio conto;

        // 0001;Mario;Rossi;mariorossi

        public Utente()
        {
            conto = new Portafoglio();
            ID = "";
            nome = "";
            cognome = "";
        }

        public Utente(string ID, string nome, string cognome)
        {
            Set_Utente(ID, nome, cognome);
            conto = new Portafoglio();
        }

        public Utente(string ID, string nome, string cognome, double bilancio)
        {
            Set_Utente(ID, nome, cognome);
            conto = new Portafoglio(bilancio);
        }

        private void Set_Utente(string ID, string nome, string cognome)
        {
            this.ID = ID;
            this.nome = nome;
            this.cognome = cognome;
        }

        public string username
        {
            set { ID = value; }
            get { return ID; }
        }

        public void Compra(double qta)
        {
            conto.Aggiorna(qta, 'I');
        }

        public void Vendi(double qta)
        {
            if (conto.Bilancio - qta > 0)
                conto.Aggiorna(qta, 'O');
        }
    }

    class Portafoglio
    {
        double saldo;
        List<Transazione> transazioni;

        public double Bilancio
        { get { return saldo; } }

        public Portafoglio()
        {
            saldo = 0;
            transazioni = new List<Transazione>();
        }

        public Portafoglio(double saldo)
        {
            this.saldo = saldo;
            transazioni = new List<Transazione>();
        }

        public void Aggiorna(double mov, char verso)
        {
            saldo += mov;
            AggiungiTransazione(saldo, verso);
        }

        private void AggiungiTransazione(double mov, char verso)
        {
            Transazione transazione = new Transazione();
            transazione.Ora = DateTime.Now;
            transazione.Spesa = mov;
            transazioni.Add(transazione);
        }
    }

    class Transazione
    {
        DateTime dataOra;
        double spesa; // Anche %

        public DateTime Ora
        {
            get { return dataOra; }
            set { dataOra = value; }
        }

        public double Spesa
        {
            get { return spesa; }
            set { spesa = value; }
        }
    }
}