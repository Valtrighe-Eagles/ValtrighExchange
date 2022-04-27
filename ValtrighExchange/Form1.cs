using System;
using System.IO;
using System.Windows.Forms;

namespace ValtrighExchange
{
    public partial class Form1 : Form
    {
        private Form2 Home;
        private int ID_N;
        private string csvFile;
        private string ID;
        public Form1()
        {
            InitializeComponent();
            csvFile = "Utenti.csv"; // nome del file
            ID = "";
            ID_N = File.ReadAllLines(csvFile).Length; // vede quante righe ha il file
        }

        // Effettua accesso
        private void Accedi_Click(object sender, EventArgs e)
        {
            string Username = Username1.Text;
            string Password = Password1.Text;
            string nome = "", cognome = "",ident="";
            bool continua = false;

            foreach (var line in File.ReadLines(csvFile))
            {
                // Controlla che l'utente inserito esista
                string username = line.Substring(0, line.IndexOf(";"));
                if (username == Username)
                {
                    // Controlla che la password sia corretta
                    string password = line.Substring(line.LastIndexOf(";") + 1);
                    if (password == Password)
                    {
                        continua = true;
                        int start = line.IndexOf(";") + 1;
                        int length = line.LastIndexOf(";") - line.IndexOf(";") - 1;
                        string nc = line.Substring(start, length);

                        ident = username;
                        nome = nc.Substring(0, nc.IndexOf(";"));
                        cognome = nc.Substring(nc.IndexOf(";") + 1);
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
            if (continua == true)
            {
                Home = new Form2(ident, nome, cognome);
                Home.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Utente non trovato");
                Username1.Text = "";
                Password1.Text = "";
            }
        }

        // Mostra la finestra per registrarsi
        private void Registrati1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;            
            Username1.Text = "";
            Password1.Text = "";
        }

        // Nasconde la finestra per registrarsi
        private void Back1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Nome.Text = "";
            Cognome.Text = "";
            Password.Text = "";
            Checkpsw.Text = "";
        }

        // Registra un nuovo utente
        private void Registrati_Click(object sender, EventArgs e)
        {
            if (Password.Text == Checkpsw.Text)
            {
                ID_N++;
                ID = Convert.ToString(ID_N).PadLeft(4, '0');
                string linea = ID + ';' + Nome.Text + ';' + Cognome.Text + ';' + Password.Text + '\n';
                File.AppendAllText(csvFile, linea);
                MessageBox.Show("Registrazione avvenuta con successo\nIl tuo ID è: " + ID);
                panel1.Visible = false;
                Username1.Text = ID;
                Password1.Text = Password.Text;
            }
            else
            {
                while (Password.Text != Checkpsw.Text)
                {
                    MessageBox.Show("Le due password non coincidono");
                    Checkpsw.Clear();
                    Password.Clear();
                }
            }            
        }
    }
}