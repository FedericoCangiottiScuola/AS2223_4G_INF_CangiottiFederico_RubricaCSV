namespace AS2223_4G_INF_CangiottiFederico_RubricaCSV
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFileInput = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnCaricaFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRicerca = new System.Windows.Forms.ComboBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFileInput
            // 
            this.lblFileInput.AutoSize = true;
            this.lblFileInput.Location = new System.Drawing.Point(12, 24);
            this.lblFileInput.Name = "lblFileInput";
            this.lblFileInput.Size = new System.Drawing.Size(89, 15);
            this.lblFileInput.TabIndex = 0;
            this.lblFileInput.Text = "File CSV rubrica";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(107, 21);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(488, 23);
            this.txtFile.TabIndex = 1;
            // 
            // btnCaricaFile
            // 
            this.btnCaricaFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCaricaFile.Location = new System.Drawing.Point(601, 21);
            this.btnCaricaFile.Name = "btnCaricaFile";
            this.btnCaricaFile.Size = new System.Drawing.Size(38, 23);
            this.btnCaricaFile.TabIndex = 2;
            this.btnCaricaFile.Text = "...";
            this.btnCaricaFile.UseVisualStyleBackColor = true;
            this.btnCaricaFile.Click += new System.EventHandler(this.btnCaricaFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRicerca);
            this.groupBox1.Controls.Add(this.txtCognome);
            this.groupBox1.Controls.Add(this.lblCognome);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtri di ricerca";
            // 
            // cmbRicerca
            // 
            this.cmbRicerca.FormattingEnabled = true;
            this.cmbRicerca.Items.AddRange(new object[] {
            "stampa CSV",
            "contiene",
            "inizia",
            "finisce"});
            this.cmbRicerca.Location = new System.Drawing.Point(492, 33);
            this.cmbRicerca.Name = "cmbRicerca";
            this.cmbRicerca.Size = new System.Drawing.Size(135, 23);
            this.cmbRicerca.TabIndex = 2;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(95, 33);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(391, 23);
            this.txtCognome.TabIndex = 1;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(29, 36);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(60, 15);
            this.lblCognome.TabIndex = 0;
            this.lblCognome.Text = "Cognome";
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(303, 157);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 4;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 15;
            this.lstVisualizza.Location = new System.Drawing.Point(12, 213);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(658, 349);
            this.lstVisualizza.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 570);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCaricaFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblFileInput);
            this.Name = "frmMain";
            this.Text = "Cangiotti Federico - 4G - INF - Gestione rubrica CSV contatti";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFileInput;
        private TextBox txtFile;
        private Button btnCaricaFile;
        private GroupBox groupBox1;
        private ComboBox cmbRicerca;
        private TextBox txtCognome;
        private Label lblCognome;
        private Button btnVisualizza;
        private ListBox lstVisualizza;
        private OpenFileDialog openFileDialog;
    }
}