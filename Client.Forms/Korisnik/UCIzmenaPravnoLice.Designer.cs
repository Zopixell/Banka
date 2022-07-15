using System.Windows.Forms;

namespace Client.Forms.Korisnik
{
    partial class UCIzmenaPravnoLice
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
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtAtribut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "JMBG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Prezime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Ime :";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(167, 292);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(193, 22);
            this.txtJMBG.TabIndex = 48;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(167, 242);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(193, 22);
            this.txtPrezime.TabIndex = 47;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(167, 199);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(193, 22);
            this.txtIme.TabIndex = 46;
            // 
            // txtPIB
            // 
            this.txtPIB.Location = new System.Drawing.Point(167, 379);
            this.txtPIB.Name = "txtPIB";
            this.txtPIB.Size = new System.Drawing.Size(193, 22);
            this.txtPIB.TabIndex = 45;
            // 
            // txtDatumOsnivanja
            // 
            this.txtDatumOsnivanja.Location = new System.Drawing.Point(167, 424);
            this.txtDatumOsnivanja.Name = "txtDatumOsnivanja";
            this.txtDatumOsnivanja.Size = new System.Drawing.Size(193, 22);
            this.txtDatumOsnivanja.TabIndex = 44;
            // 
            // txtMesecnaZarada
            // 
            this.txtMesecnaZarada.Location = new System.Drawing.Point(167, 338);
            this.txtMesecnaZarada.Name = "txtMesecnaZarada";
            this.txtMesecnaZarada.Size = new System.Drawing.Size(193, 22);
            this.txtMesecnaZarada.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Datum osnivanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "PIB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mesecna zarada:";
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(545, 198);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(145, 23);
            this.btnUcitaj.TabIndex = 39;
            this.btnUcitaj.Text = "Ucitaj korisnika";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(177, 464);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(145, 26);
            this.btnIzmeni.TabIndex = 38;
            this.btnIzmeni.Text = "Izmeni korisnika";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(22, 70);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(668, 111);
            this.dgvKorisnici.TabIndex = 37;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(475, 16);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(139, 33);
            this.btnPretrazi.TabIndex = 36;
            this.btnPretrazi.Text = "Pronadji korisnika";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // txtAtribut
            // 
            this.txtAtribut.Location = new System.Drawing.Point(167, 21);
            this.txtAtribut.Name = "txtAtribut";
            this.txtAtribut.Size = new System.Drawing.Size(258, 22);
            this.txtAtribut.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Ime/deo imena";
            // 
            // UCIzmenaPravnoLice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtAtribut);
            this.Name = "UCIzmenaPravnoLice";
            this.Size = new System.Drawing.Size(725, 520);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtPIB;
        private System.Windows.Forms.TextBox txtDatumOsnivanja;
        private System.Windows.Forms.TextBox txtMesecnaZarada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtAtribut;
        private Label label7;

        public DataGridView DgvKorisnici { get => dgvKorisnici; set => dgvKorisnici = value; }
        public TextBox TxtAtribut { get => txtAtribut; set => txtAtribut = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
        public Button BtnUcitaj { get => btnUcitaj; set => btnUcitaj = value; }
        public TextBox TxtPIB { get => txtPIB; set => txtPIB = value; }
        public TextBox TxtDatumOsnivanja { get => txtDatumOsnivanja; set => txtDatumOsnivanja = value; }
        public TextBox TxtMesecnaZarada { get => txtMesecnaZarada; set => txtMesecnaZarada = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public Label Label7 { get => label7; set => label7 = value; }

    }

}
