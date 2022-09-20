using System.Windows.Forms;

namespace AS2223_4G_INF_CangiottiFederico_RubricaCSV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

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

        }
    }
}