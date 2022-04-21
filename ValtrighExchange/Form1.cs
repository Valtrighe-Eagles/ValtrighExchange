using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValtrighExchange
{
    public partial class Form1 : Form
    {
        private Form2 Home;
        private int ID_N;
        private string csvFile;
        public Form1()
        {
            InitializeComponent();
            csvFile = "Utenti.csv";
            ID_N = File.ReadAllLines(csvFile).Length;
        }
        // Effettua accesso
        private void Accedi_Click(object sender, EventArgs e)
        {
            string Username = Username1.Text;
            string Password = Password1.Text;
            string nome = "", cognome = "";
            bool checkutente = false;
            bool continua = false;

            foreach (var line in File.ReadLines(csvFile))
            {
                // Controlla che l'utente inserito esista
                string username = line.Substring(0, line.IndexOf(";"));
                if (username == Username)
                {
                    checkutente = true;
                    // Controlla che la password sia corretta
                    string password = line.Substring(line.LastIndexOf(";") + 1);
                    if (password == Password)
                    {
                        continua = true;
                        int start = line.IndexOf(";") + 1;
                        int length = line.LastIndexOf(";") - line.IndexOf(";") - 1;
                        string nc = line.Substring(start, length);
                        
                        nome = nc.Substring(0, nc.IndexOf(";"));
                        cognome = nc.Substring(nc.IndexOf(";")+1);
                    }
                    else
                    {
                        MessageBox.Show("Password errata");
                        Password1.Clear();
                    }
                    break;
                }
            }
            // Se le credenziali corrispondono porta alla home
            if (checkutente == false)
            {
                MessageBox.Show("Utente non trovato");
            }
            else if (continua == true)
            {
                Home = new Form2(nome, cognome);
                Home.Show();
                this.Hide();
            }
        }

        // Mostra la finestra per registrarsi
        private void Registrati1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        // Nasconde la finestra per registrarsi
        private void Back1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Nome.Text = "";
            Cognome.Text = "";
            Password.Text = "";
            Checkpsw.Text = "";
            Username1.Text = "";
            Password1.Text = "";
        }

        // Registra un nuovo utente
        private void Registrati_Click(object sender, EventArgs e)
        {
            ID_N++;
            if (Password.Text == Checkpsw.Text)
            {
         
                string linea = Convert.ToString(ID_N).PadLeft(4, '0') + ';' + Nome.Text + ';' + Cognome.Text + ';' + Password.Text + '\n';
                File.AppendAllText(csvFile, linea);
            }
            else
            {
                MessageBox.Show("Le due password non coincidono");
                Checkpsw.Clear();
                Password.Clear();
            }
            panel1.Visible = false;
        }
    }
}