using System.Windows.Forms;

namespace AS2223_4G_INF_CangiottiFederico_RubricaCSV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        const int N_RECORD = 10;    // numero righe
        const int N_INFO = 3;   // numero di informazioni (numero colonne)

        string[] cognomi = new string[N_RECORD];
        string[] nomi = new string[N_RECORD];
        string[] provenienza = new string[N_RECORD];

        private void btnCaricaFile_Click(object sender, EventArgs e)
        {
            DialogResult risultatoAperturaFile = openFileDialog.ShowDialog();  // apre il file dialog
            if (risultatoAperturaFile == DialogResult.OK)  // controllo che l'apertura sia andata a buon fine
            {
                txtFile.Text = openFileDialog.FileName;     // assegno il percorso del file scelto al testo della textbox
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

            DividiDati();
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
                string[] appoggio = new string[N_INFO];
                string riga;
                int i = 0;

                try
                {
                    while (!sr.EndOfStream)
                    {
                        riga = sr.ReadLine();   // leggo una riga alla volta dal CSV
                        appoggio = riga.Split(","); // divido la stringa salvandola nel vettore

                        cognomi[i] = appoggio[0];   // assegno il nome al vettore corrispondente
                        nomi[i] = appoggio[1];  // assegno il cognome al vettore corrispondente
                        provenienza[i] = appoggio[2];   // assegno la provenienza al vettore corrispondente

                        i++;
                    }
                } catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Errore durante il carimento del file");
                }
            }
        }

        void StampaCSV()
        {
            lstVisualizza.Items.Clear();
            for (int i = 0; i < N_RECORD; i++)
            {
                lstVisualizza.Items.Add($"{cognomi[i]}, {nomi[i]}, {provenienza[i]}");
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

            for (int i = 0; i < N_RECORD; i++)
            {
                if (cognomi[i].ToLower().Contains(target))
                {
                    lstVisualizza.Items.Add($"{cognomi[i]}, {nomi[i]}, {provenienza[i]}");
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

            for (int i = 0; i < N_RECORD; i++)
            {
                if (cognomi[i].ToLower().StartsWith(target))
                {
                    lstVisualizza.Items.Add($"{cognomi[i]}, {nomi[i]}, {provenienza[i]}");
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

            for (int i = 0; i < N_RECORD; i++)
            {
                if (cognomi[i].ToLower().EndsWith(target))
                {
                    lstVisualizza.Items.Add($"{cognomi[i]}, {nomi[i]}, {provenienza[i]}");
                }
            }
        }
    }
}