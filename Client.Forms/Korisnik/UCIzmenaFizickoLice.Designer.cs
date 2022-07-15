using System.Windows.Forms;

namespace Client.Forms.Korisnik
{
    partial class UCIzmenaFizickoLice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.txtDuzinaZaposlenja = new System.Windows.Forms.TextBox();
            this.txtVIsinaPlate = new System.Windows.Forms.TextBox();
            this.lblDuzinaZaposlenja = new System.Windows.Forms.Label();
            this.lblVisinaPlate = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtAtribut = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "JMBG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ime :";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(174, 356);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(178, 22);
            this.txtJMBG.TabIndex = 38;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(174, 311);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(178, 22);
            this.txtPrezime.TabIndex = 37;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(174, 268);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(178, 22);
            this.txtIme.TabIndex = 36;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(467, 169);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(182, 27);
            this.btnUcitaj.TabIndex = 35;
            this.btnUcitaj.Text = "Ucitaj korisnika";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            // 
            // txtDuzinaZaposlenja
            // 
            this.txtDuzinaZaposlenja.Location = new System.Drawing.Point(174, 220);
            this.txtDuzinaZaposlenja.Name = "txtDuzinaZaposlenja";
            this.txtDuzinaZaposlenja.Size = new System.Drawing.Size(178, 22);
            this.txtDuzinaZaposlenja.TabIndex = 34;
            // 
            // txtVIsinaPlate
            // 
            this.txtVIsinaPlate.Location = new System.Drawing.Point(174, 174);
            this.txtVIsinaPlate.Name = "txtVIsinaPlate";
            this.txtVIsinaPlate.Size = new System.Drawing.Size(178, 22);
            this.txtVIsinaPlate.TabIndex = 33;
            // 
            // lblDuzinaZaposlenja
            // 
            this.lblDuzinaZaposlenja.AutoSize = true;
            this.lblDuzinaZaposlenja.Location = new System.Drawing.Point(31, 226);
            this.lblDuzinaZaposlenja.Name = "lblDuzinaZaposlenja";
            this.lblDuzinaZaposlenja.Size = new System.Drawing.Size(120, 16);
            this.lblDuzinaZaposlenja.TabIndex = 32;
            this.lblDuzinaZaposlenja.Text = "Duzina zaposlenja:";
            // 
            // lblVisinaPlate
            // 
            this.lblVisinaPlate.AutoSize = true;
            this.lblVisinaPlate.Location = new System.Drawing.Point(31, 180);
            this.lblVisinaPlate.Name = "lblVisinaPlate";
            this.lblVisinaPlate.Size = new System.Drawing.Size(80, 16);
            this.lblVisinaPlate.TabIndex = 31;
            this.lblVisinaPlate.Text = "Visina plate:";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(174, 420);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(145, 23);
            this.btnIzmeni.TabIndex = 30;
            this.btnIzmeni.Text = "Izmeni korisnika";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(18, 57);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(651, 100);
            this.dgvKorisnici.TabIndex = 29;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(467, 14);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(139, 23);
            this.btnPretrazi.TabIndex = 28;
            this.btnPretrazi.Text = "Pronadji korisnika";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // txtAtribut
            // 
            this.txtAtribut.Location = new System.Drawing.Point(174, 14);
            this.txtAtribut.Name = "txtAtribut";
            this.txtAtribut.Size = new System.Drawing.Size(258, 22);
            this.txtAtribut.TabIndex = 27;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(3, 16);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(97, 16);
            this.lblPretraga.TabIndex = 42;
            this.lblPretraga.Text = "Ime/deo imena";
            // 
            // UCIzmenaFizickoLice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.txtDuzinaZaposlenja);
            this.Controls.Add(this.txtVIsinaPlate);
            this.Controls.Add(this.lblDuzinaZaposlenja);
            this.Controls.Add(this.lblVisinaPlate);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtAtribut);
            this.Name = "UCIzmenaFizickoLice";
            this.Size = new System.Drawing.Size(724, 494);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtJMBG;
        private Button btnUcitaj;
        private TextBox txtDuzinaZaposlenja;
        private TextBox txtVIsinaPlate;
        private Label lblDuzinaZaposlenja;
        private Label lblVisinaPlate;
        private Button btnIzmeni;
        private DataGridView dgvKorisnici;
        private Button btnPretrazi;
        private TextBox txtAtribut;
        private Label lblPretraga;

        public DataGridView DgvKorisnici { get => dgvKorisnici; set => dgvKorisnici = value; }
        public TextBox TxtAtribut { get => txtAtribut; set => txtAtribut = value; }
        public TextBox TxtIme { get=> txtIme; set=> txtIme=value; }
        public TextBox TxtPrezime { get=> txtPrezime; set=> txtPrezime=value; }
        public TextBox TxtJMBG { get=> txtJMBG; set=> txtJMBG=value; }
        public Button BtnUcitaj { get=> btnUcitaj; set=> btnUcitaj=value; }
        public TextBox TxtDuzinaZaposlenja { get => txtDuzinaZaposlenja; set => txtDuzinaZaposlenja = value; }
        public TextBox TxtVIsinaPlate { get => txtVIsinaPlate; set => txtVIsinaPlate = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public Label Label4 { get=> lblPretraga; set=> lblPretraga=value; }


    }
}
