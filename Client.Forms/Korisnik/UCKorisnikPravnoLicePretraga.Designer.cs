using System.Windows.Forms;

namespace Client.Forms.Korisnik
{
    partial class UCKorisnikPravnoLicePretraga
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtAtribut = new System.Windows.Forms.TextBox();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPIB = new System.Windows.Forms.TextBox();
            this.txtDatumOsnivanja = new System.Windows.Forms.TextBox();
            this.txtMesecnaZarada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPretraga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(172, 464);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(145, 26);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obrisi korisnika";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(17, 70);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(657, 111);
            this.dgvKorisnici.TabIndex = 6;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(535, 21);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(139, 33);
            this.btnPretrazi.TabIndex = 5;
            this.btnPretrazi.Text = "Pronadji korisnika";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // txtAtribut
            // 
            this.txtAtribut.Location = new System.Drawing.Point(191, 21);
            this.txtAtribut.Name = "txtAtribut";
            this.txtAtribut.Size = new System.Drawing.Size(258, 22);
            this.txtAtribut.TabIndex = 4;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(471, 198);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(145, 23);
            this.btnUcitaj.TabIndex = 8;
            this.btnUcitaj.Text = "Ucitaj korisnika";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "JMBG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Prezime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ime :";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(162, 292);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.ReadOnly = true;
            this.txtJMBG.Size = new System.Drawing.Size(193, 22);
            this.txtJMBG.TabIndex = 31;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(162, 242);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(193, 22);
            this.txtPrezime.TabIndex = 30;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(162, 199);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(193, 22);
            this.txtIme.TabIndex = 29;
            // 
            // txtPIB
            // 
            this.txtPIB.Location = new System.Drawing.Point(162, 379);
            this.txtPIB.Name = "txtPIB";
            this.txtPIB.ReadOnly = true;
            this.txtPIB.Size = new System.Drawing.Size(193, 22);
            this.txtPIB.TabIndex = 28;
            // 
            // txtDatumOsnivanja
            // 
            this.txtDatumOsnivanja.Location = new System.Drawing.Point(162, 424);
            this.txtDatumOsnivanja.Name = "txtDatumOsnivanja";
            this.txtDatumOsnivanja.ReadOnly = true;
            this.txtDatumOsnivanja.Size = new System.Drawing.Size(193, 22);
            this.txtDatumOsnivanja.TabIndex = 27;
            // 
            // txtMesecnaZarada
            // 
            this.txtMesecnaZarada.Location = new System.Drawing.Point(162, 338);
            this.txtMesecnaZarada.Name = "txtMesecnaZarada";
            this.txtMesecnaZarada.ReadOnly = true;
            this.txtMesecnaZarada.Size = new System.Drawing.Size(193, 22);
            this.txtMesecnaZarada.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Datum osnivanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "PIB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mesecna zarada:";
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
            // UCKorisnikPravnoLicePretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtPIB);
            this.Controls.Add(this.txtDatumOsnivanja);
            this.Controls.Add(this.txtMesecnaZarada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtAtribut);
            this.Name = "UCKorisnikPravnoLicePretraga";
            this.Size = new System.Drawing.Size(798, 523);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtAtribut;
        private Button btnUcitaj;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtJMBG;
        private TextBox txtPrezime;
        private TextBox txtIme;
        private TextBox txtPIB;
        private TextBox txtDatumOsnivanja;
        private TextBox txtMesecnaZarada;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblPretraga;

        public TextBox TxtAtribut { get=> txtAtribut; set=> txtAtribut=value; }
        public Button BtnPretrazi { get=> btnPretrazi; set=> btnPretrazi=value; }
        public DataGridView DgvKorisnici { get=> dgvKorisnici; set=> dgvKorisnici=value; }
        public Button BtnUcitaj { get => btnUcitaj; set => btnUcitaj = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtAtribut = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPIB { get => txtPIB; set => txtPIB = value; }
        public TextBox TxtDatumOsnivanja { get => txtDatumOsnivanja; set => txtDatumOsnivanja = value; }
        public TextBox TxtMesecnaZarada { get => txtMesecnaZarada; set => txtMesecnaZarada = value; }
        public Label LblPretraga { get => lblPretraga; set => lblPretraga = value; }

    }
}
