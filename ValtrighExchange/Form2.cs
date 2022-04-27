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

// Apertura e chiusura dei mercati -> fa partire e ferma tutti i thread     -->     FATTO (ma generando nuovi thread)
// Possibilità di interrompere uno o più thread

namespace ValtrighExchange
{
    public partial class Form2 : Form
    {
        // Crypto
        string ID;
        static double value;
        public static object valtrighe = new object(); // Per entrare nella lock

        // Thread
        Thread[] t = new Thread[10];
        Semaphore[] block = new Semaphore[10];
        bool controllo = false;  // Controllo sui thread (false -> thread non in esecuzione)
        int[] num = new int[10];
        int j = 0;

        // Per grafico
        LineSeries andamento = new LineSeries { Values = new ChartValues<double>() };
        Axis asseY;
        Axis asseX;

        public Form2(string ID, string Name, string Cognome)
        {
            InitializeComponent();
            this.ID = ID;
            value = 1000; // Valore iniziale della crypto
            Nome.Text = Name + " " + Cognome;

            // Per grafico
            Grafico.Series.Add(andamento);
            asseY = new Axis();
            asseX = new Axis();
            asseY.Title = "Valore";
            asseX.Title = "Tempo";
            Grafico.DisableAnimations = true;
            Grafico.AxisY.Add(asseY);
            Grafico.AxisX.Add(asseX);
            andamento.Values.Add(value);
        }

        // Transazioni dei thread
        public void ThreadProc(object o)
        {
            // Gestione dei thread con Utente
            string i = Convert.ToString(o).PadLeft(4, '0');
            Utente U = new Utente(i);

            int nome_thread = Thread.CurrentThread.ManagedThreadId;
            Invoke(new Action(() => last_trans.Items.Add(nome_thread + " ha iniziato a investire")));
            Invoke(new Action(() => last_trans.Items[last_trans.Items.Count - 1].EnsureVisible()));
            Invoke(new Action(() => last_trans.Columns[0].Width = -1));

            // Assegna nome ai thread
            num[j] = nome_thread;
            j = (j + 1) % 10;

            while (true)
            {
                lock (valtrighe)
                {
                    Random rnd = new Random();
                    // Controlla che il valore della Crypto sia >= 0
                    if (value >= 0)
                    {
                        int prob = rnd.Next(2);
                        double rand2 = rnd.NextDouble() * (rnd.Next(5) + 1);
                        if (prob == 0)
                        {
                            value += rand2;
                            U.Compra(rand2);
                            // {ID} ha comprato {rand2} azioni
                            Invoke(new Action(() => last_trans.Items.Add(nome_thread + " ha comprato " + rand2.ToString())));
                            Invoke(new Action(() => last_trans.Items[last_trans.Items.Count - 1].EnsureVisible()));
                            Invoke(new Action(() => last_trans.Columns[0].Width = -1));
                        }
                        else
                        {
                            value -= rand2;
                            U.Vendi((-1)*rand2);
                            // {ID} ha venduto {rand2} azioni
                            Invoke(new Action(() => last_trans.Items.Add(nome_thread + " ha venduto " + rand2.ToString())));
                            Invoke(new Action(() => last_trans.Items[last_trans.Items.Count - 1].EnsureVisible()));
                            Invoke(new Action(() => last_trans.Columns[0].Width = -1));
                        }
                    }
                    else
                        valore_attuale.Text = "La valuta è crollata";

                    Thread.Sleep(1000);
                }

                //
                if (valore_attuale.IsHandleCreated)
                {
                    valore_attuale.Invoke(new Action(() => valore_attuale.Text = value.ToString()));                    
                }     
            }
        }

        // Accende o spegne i thread
        void button_thread(int i,ref Button bottone)
        {
            if (t[i].IsAlive)
            {
                t[i].Abort();
                bottone.BackColor = Color.Red;
                Invoke(new Action(() => last_trans.Items.Add(num[i] + " ha smesso di investire")));
                Invoke(new Action(() => last_trans.Items[last_trans.Items.Count - 1].EnsureVisible()));
                Invoke(new Action(() => last_trans.Columns[0].Width = -1));
            }
            else
            {
                if (controllo == true)
                {
                    t[i] = new Thread(new ParameterizedThreadStart(ThreadProc));
                    t[i].Start(i + 1);
                    bottone.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("I mercati sono chiusi");
                }
            }
        }

        // Funzioni dedicate a ogni bottone (per gestire i thread)
        private void button1_Click(object sender, EventArgs e)
        {
            button_thread(0,ref button1);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_thread(1,ref button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_thread(2,ref button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_thread(3, ref button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_thread(4, ref button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_thread(5, ref button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_thread(6, ref button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_thread(7, ref button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_thread(8, ref button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_thread(9, ref button10);
        }

        // Apre il mercato e crea i thread per la prima volta
        private void Apri_Click(object sender, EventArgs e)
        {
            if (controllo == false)
            {
                for (int i = 0; i < 10; i++)
                {
                    t[i] = new Thread(new ParameterizedThreadStart(ThreadProc));
                    block[i] = new Semaphore(1,1);
                    t[i].Start(i + 1);
                }
                controllo = true;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                
            }
            else
            {
                MessageBox.Show("I mercati sono già aperti");
            }
        }

        // Chiude il mercato e ferma tutti i thread
        private void Chiudi_Click(object sender, EventArgs e)
        {
            if (controllo == true)
            {
                for (int i = 0; i < 10; i++)
                    t[i].Abort();
                controllo = false;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                button10.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("I mercati sono già chiusi");
            }
        }

        // Termina i thread quando si preme il tasto "Chiudi" del programma
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (controllo == true)
            {
                for (int i = 0; i < 10; i++)
                    t[i].Abort();
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }

        // Gestisce l'ora
        private void Orologio_Tick(object sender, EventArgs e)
        {
            AggiornaOra();
        }

        private void AggiornaOra()
        { Data.Text = DateTime.Now.ToString("G"); }

        // Traccia il grafico
        private void valore_attuale_TextChanged(object sender, EventArgs e)
        {
            double valore_iniziale = 1000;
            double valore = Convert.ToDouble(valore_attuale.Text);

           // if (valore < asseY.ActualMinValue || valore > asseY.ActualMaxValue)
            //    Grafico.DisableAnimations = false;

            andamento.Values.Add(Convert.ToDouble(valore_attuale.Text));
            
            if (andamento.Values.Count > 2)
            {
                if (Convert.ToDouble(andamento.Values[andamento.Values.Count - 1]) > valore_iniziale)
                    andamento.Stroke = System.Windows.Media.Brushes.SpringGreen;
                else
                    andamento.Stroke = System.Windows.Media.Brushes.Red;
            }
            
            if (andamento.Values.Count > 10)
                andamento.Values.Remove(andamento.Values[0]);
        }
    }

    // Collega ogni utente ad un thread
    class Utente
    {
        string ID;
        Portafoglio conto;

        public Utente()
        {
            conto = new Portafoglio();
            ID = "";
        }

        public Utente(string ID)
        {
            Set_Utente(ID);
            conto = new Portafoglio();
        }

        public Utente(string ID, double bilancio)
        {
            Set_Utente(ID);
            conto = new Portafoglio(bilancio);
        }

        private void Set_Utente(string ID)
        {
            this.ID = ID;
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

    // Contiene le transazioni dei thread
    class Portafoglio
    {
        double saldo;
        List<Transazione> transazioni;

        public double Bilancio
        { get { return saldo; } }

        public Portafoglio()
        {
            saldo = 10;
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

    // Descrive le transazioni (importa data e ora)
    class Transazione
    {
        DateTime dataOra;
        double spesa;

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