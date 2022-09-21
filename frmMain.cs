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
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            switch (cmbRicerca.Text)
            {
                case "stampa CSV":
                    StampaCSV();
                    break;
                case "contiene":
                    break;
                case "inizia":
                    break;
                case "finisce":
                    break;
                default:
                    MessageBox.Show("Filtro di ricerca inesistente");
                    break;
            }
        }

        void DividiDati()
        {
            using (StreamReader sr = new StreamReader("rubrica.csv"))   // attraverso l'uso di using, lo streamreader si apre e si chiude all'interno delle parentesi
            {
                string[] appoggio = new string[N_INFO];
                string riga;
                int i = 0;

                while (!sr.EndOfStream)
                {
                    riga = sr.ReadLine();   // leggo una riga alla volta dal CSV
                    appoggio = riga.Split(","); // divido la stringa salvandola nel vettore

                    cognomi[i] = appoggio[0];   // assegno il nome al vettore corrispondente
                    nomi[i] = appoggio[1];  // assegno il cognome al vettore corrispondente
                    provenienza[i] = appoggio[2];   // assegno la provenienza al vettore corrispondente

                    i++;
                }
            }
        }

        void StampaCSV()
        {
            DividiDati();
        }
    }
}