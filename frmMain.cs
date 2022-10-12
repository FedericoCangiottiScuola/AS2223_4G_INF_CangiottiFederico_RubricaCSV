using System.Windows.Forms;

namespace AS2223_4G_INF_CangiottiFederico_RubricaCSV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        static int nRecord = 0;    // numero righe
        Contatto[] contatti = new Contatto[nRecord];
        bool caricamentoEffettuato = false;

        private void btnCaricaFile_Click(object sender, EventArgs e)
        {
            DialogResult risultatoAperturaFile = openFileDialog.ShowDialog();  // apre il file dialog
            if (risultatoAperturaFile == DialogResult.OK)  // controllo che l'apertura sia andata a buon fine
            {
                txtFile.Text = openFileDialog.FileName;     // assegno il percorso del file scelto al testo della textbox
                nRecord = File.ReadLines(openFileDialog.FileName).Count();     // ottengo il numero delle righe del file
                Array.Resize(ref contatti, nRecord);    // ridimensiono l'array in base al numero di righe
                caricamentoEffettuato = false;
            } else
            {
                MessageBox.Show("Apertura del file non riuscita", "Errore");
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            if (openFileDialog.FileName == "")
            {
                MessageBox.Show("Nessun file selezionato", "Errore");
                return;
            }

            if (!caricamentoEffettuato)     // disattivazione funzione DividiDati() quando non necessaria
            {
                DividiDati();
            }
            
            switch (cmbRicerca.Text)
            {
                case "stampa CSV":
                    StampaCSV();
                    break;
                case "contiene":
                    RicercaCognomeContiene();
                    break;
                case "inizia":
                    RicercaCognomeInizia();
                    break;
                case "finisce":
                    RicercaCognomeFinisce();
                    break;
                default:
                    MessageBox.Show("Filtro di ricerca inesistente", "Errore");
                    break;
            }
        }

        void DividiDati()
        {
            using (StreamReader sr = new StreamReader(openFileDialog.FileName))   // attraverso l'uso di using, lo streamreader si apre e si chiude all'interno delle parentesi
            {
                try
                {
                    string riga;
                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        riga = sr.ReadLine();   // leggo una riga alla volta dal CSV
                        Contatto contatto = new Contatto(riga);
                        contatti[i] = contatto;

                        i++;
                    }
                } catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Errore durante il carimento del file");
                }

                caricamentoEffettuato = true;
            }
        }

        void StampaCSV()
        {
            lstVisualizza.Items.Clear();
            for (int i = 0; i < nRecord; i++)
            {
                lstVisualizza.Items.Add($"{contatti[i].getSurname()}, {contatti[i].getName()}, {contatti[i].getCity()}");
            }
        }

        void RicercaCognomeContiene()
        {
            if (txtCognome.Text == "")
            {
                MessageBox.Show("Nessun cognome inserito", "Errore");
                return;
            }

            lstVisualizza.Items.Clear();
            string target = txtCognome.Text.ToLower();

            for (int i = 0; i < nRecord; i++)
            {
                if (contatti[i].getSurname().ToLower().Contains(target))
                {
                    lstVisualizza.Items.Add($"{contatti[i].getSurname()}, {contatti[i].getName()}, {contatti[i].getCity()}");
                }
            }
        }
        void RicercaCognomeInizia()
        {
            if (txtCognome.Text == "")
            {
                MessageBox.Show("Nessun cognome inserito", "Errore");
                return;
            }

            lstVisualizza.Items.Clear();
            string target = txtCognome.Text.ToLower();

            for (int i = 0; i < nRecord; i++)
            {
                if (contatti[i].getSurname().ToLower().StartsWith(target))
                {
                    lstVisualizza.Items.Add($"{contatti[i].getSurname()}, {contatti[i].getName()}, {contatti[i].getCity()}");
                }
            }
        }

        void RicercaCognomeFinisce()
        {
            if (txtCognome.Text == "")
            {
                MessageBox.Show("Nessun cognome inserito", "Errore");
                return;
            }

            lstVisualizza.Items.Clear();
            string target = txtCognome.Text.ToLower();

            for (int i = 0; i < nRecord; i++)
            {
                if (contatti[i].getSurname().ToLower().EndsWith(target))
                {
                    lstVisualizza.Items.Add($"{contatti[i].getSurname()}, {contatti[i].getName()}, {contatti[i].getCity()}");
                }
            }
        }
    }

    class Contatto
    {
        string name;
        string surname;
        string city;

        public string getName()
        {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getCity()
        { 
            return city;
        }

        public Contatto(string record)
        {
            string[] supporto = record.Split(",");
            surname = supporto[0];
            name = supporto[1];
            city = supporto[2];
        }

        public Contatto(string name, string surname, string city)
        {
            this.name = name;
            this.surname = surname;
            this.city = city;
        }
    }
}