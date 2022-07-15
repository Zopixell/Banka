using System.Windows.Forms;

namespace Client.Forms.Korisnik
{
    partial class UCKorisnikPretraga
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
            this.txtAtribut = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
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
            this.lblPretraga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAtribut
            // 
            this.txtAtribut.Location = new System.Drawing.Point(201, 24);
            this.txtAtribut.Name = "txtAtribut";
            this.txtAtribut.Size = new System.Drawing.Size(258, 22);
            this.txtAtribut.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(530, 21);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(139, 23);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pronadji korisnika";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(18, 65);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(651, 100);
            this.dgvKorisnici.TabIndex = 2;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(184, 420);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(145, 23);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi korisnika";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "JMBG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ime :";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(174, 364);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.ReadOnly = true;
            this.txtJMBG.Size = new System.Drawing.Size(178, 22);
            this.txtJMBG.TabIndex = 23;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(174, 319);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(178, 22);
            this.txtPrezime.TabIndex = 22;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(174, 276);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(178, 22);
            this.txtIme.TabIndex = 21;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(443, 174);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(182, 33);
            this.btnUcitaj.TabIndex = 20;
            this.btnUcitaj.Text = "Ucitaj korisnika";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            // 
            // txtDuzinaZaposlenja
            // 
            this.txtDuzinaZaposlenja.Location = new System.Drawing.Point(174, 228);
            this.txtDuzinaZaposlenja.Name = "txtDuzinaZaposlenja";
            this.txtDuzinaZaposlenja.ReadOnly = true;
            this.txtDuzinaZaposlenja.Size = new System.Drawing.Size(178, 22);
            this.txtDuzinaZaposlenja.TabIndex = 19;
            // 
            // txtVIsinaPlate
            // 
            this.txtVIsinaPlate.Location = new System.Drawing.Point(174, 176);
            this.txtVIsinaPlate.Name = "txtVIsinaPlate";
            this.txtVIsinaPlate.ReadOnly = true;
            this.txtVIsinaPlate.Size = new System.Drawing.Size(178, 22);
            this.txtVIsinaPlate.TabIndex = 18;
            // 
            // lblDuzinaZaposlenja
            // 
            this.lblDuzinaZaposlenja.AutoSize = true;
            this.lblDuzinaZaposlenja.Location = new System.Drawing.Point(31, 234);
            this.lblDuzinaZaposlenja.Name = "lblDuzinaZaposlenja";
            this.lblDuzinaZaposlenja.Size = new System.Drawing.Size(120, 16);
            this.lblDuzinaZaposlenja.TabIndex = 17;
            this.lblDuzinaZaposlenja.Text = "Duzina zaposlenja:";
            // 
            // lblVisinaPlate
            // 
            this.lblVisinaPlate.AutoSize = true;
            this.lblVisinaPlate.Location = new System.Drawing.Point(31, 182);
            this.lblVisinaPlate.Name = "lblVisinaPlate";
            this.lblVisinaPlate.Size = new System.Drawing.Size(80, 16);
            this.lblVisinaPlate.TabIndex = 16;
            this.lblVisinaPlate.Text = "Visina plate:";
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(3, 24);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(97, 16);
            this.lblPretraga.TabIndex = 43;
            this.lblPretraga.Text = "Ime/deo imena";
            // 
            // UCKorisnikPretraga
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
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtAtribut);
            this.Name = "UCKorisnikPretraga";
            this.Size = new System.Drawing.Size(773, 518);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAtribut;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnObrisi;
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
        private Label lblPretraga;

        public TextBox TxtAtribut { get=> txtAtribut; set=> txtAtribut=value; }
        public Button BtnPretrazi { get=> btnPretrazi; set=> btnPretrazi=value; }
        public DataGridView DgvKorisnici { get=> dgvKorisnici; set=> dgvKorisnici=value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
        public TextBox TxtDuzinaZaposlenja { get => txtDuzinaZaposlenja; set => txtDuzinaZaposlenja = value; }
        public TextBox TxtVIsinaPlate { get => txtVIsinaPlate; set => txtVIsinaPlate = value; }
        public Button BtnObrisi { get=> btnObrisi; set=> btnObrisi=value; }
        public Button BtnUcitaj { get => btnUcitaj; set => btnUcitaj = value; }
        public Label LblPretraga { get => lblPretraga; set => lblPretraga = value; }

    }
}
