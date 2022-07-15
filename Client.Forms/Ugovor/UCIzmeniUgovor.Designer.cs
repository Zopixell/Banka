using System.Windows.Forms;

namespace Client.Forms.Ugovor
{
    partial class UCIzmeniUgovor
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
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.dgvUgovor = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.txtDatumKreiranja = new System.Windows.Forms.TextBox();
            this.cbUsluga = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.btnUcitajUgovor = new System.Windows.Forms.Button();
            this.btnUcitajStavku = new System.Windows.Forms.Button();
            this.btnIzmeniStavku = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIznosUsluge = new System.Windows.Forms.TextBox();
            this.txtKamatnaStopa = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.checkPotpisBankara = new System.Windows.Forms.CheckBox();
            this.checkPotpisKorisnika = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(249, 26);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(266, 22);
            this.txtKriterijum.TabIndex = 0;
            // 
            // btnPronadji
            // 
            this.btnPronadji.Location = new System.Drawing.Point(549, 25);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(137, 23);
            this.btnPronadji.TabIndex = 1;
            this.btnPronadji.Text = "Pronadji";
            this.btnPronadji.UseVisualStyleBackColor = true;
            // 
            // dgvUgovor
            // 
            this.dgvUgovor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUgovor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovor.Location = new System.Drawing.Point(26, 63);
            this.dgvUgovor.Name = "dgvUgovor";
            this.dgvUgovor.RowHeadersWidth = 51;
            this.dgvUgovor.RowTemplate.Height = 24;
            this.dgvUgovor.Size = new System.Drawing.Size(687, 127);
            this.dgvUgovor.TabIndex = 2;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(106, 559);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(236, 39);
            this.btnIzmeni.TabIndex = 19;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // txtDatumKreiranja
            // 
            this.txtDatumKreiranja.Location = new System.Drawing.Point(150, 469);
            this.txtDatumKreiranja.Name = "txtDatumKreiranja";
            this.txtDatumKreiranja.Size = new System.Drawing.Size(192, 22);
            this.txtDatumKreiranja.TabIndex = 18;
            // 
            // cbUsluga
            // 
            this.cbUsluga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(150, 414);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(192, 24);
            this.cbUsluga.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Usluga:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Korisnik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Datum izmene:";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(150, 364);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(192, 22);
            this.txtKorisnik.TabIndex = 23;
            // 
            // dgvStavke
            // 
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(26, 223);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(687, 120);
            this.dgvStavke.TabIndex = 24;
            // 
            // btnUcitajUgovor
            // 
            this.btnUcitajUgovor.Location = new System.Drawing.Point(719, 63);
            this.btnUcitajUgovor.Name = "btnUcitajUgovor";
            this.btnUcitajUgovor.Size = new System.Drawing.Size(114, 46);
            this.btnUcitajUgovor.TabIndex = 25;
            this.btnUcitajUgovor.Text = "Ucitaj ugovor";
            this.btnUcitajUgovor.UseVisualStyleBackColor = true;
            // 
            // btnUcitajStavku
            // 
            this.btnUcitajStavku.Location = new System.Drawing.Point(719, 223);
            this.btnUcitajStavku.Name = "btnUcitajStavku";
            this.btnUcitajStavku.Size = new System.Drawing.Size(114, 40);
            this.btnUcitajStavku.TabIndex = 26;
            this.btnUcitajStavku.Text = "Ucitaj stavku";
            this.btnUcitajStavku.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniStavku
            // 
            this.btnIzmeniStavku.Location = new System.Drawing.Point(719, 308);
            this.btnIzmeniStavku.Name = "btnIzmeniStavku";
            this.btnIzmeniStavku.Size = new System.Drawing.Size(145, 35);
            this.btnIzmeniStavku.TabIndex = 27;
            this.btnIzmeniStavku.Text = "Izmeni stavku";
            this.btnIzmeniStavku.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIznosUsluge);
            this.groupBox1.Controls.Add(this.txtKamatnaStopa);
            this.groupBox1.Location = new System.Drawing.Point(392, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 209);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavka ugovora";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Iznos usluge:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kamatna stopa:";
            // 
            // txtIznosUsluge
            // 
            this.txtIznosUsluge.Location = new System.Drawing.Point(174, 121);
            this.txtIznosUsluge.Name = "txtIznosUsluge";
            this.txtIznosUsluge.Size = new System.Drawing.Size(272, 22);
            this.txtIznosUsluge.TabIndex = 1;
            // 
            // txtKamatnaStopa
            // 
            this.txtKamatnaStopa.Location = new System.Drawing.Point(174, 60);
            this.txtKamatnaStopa.Name = "txtKamatnaStopa";
            this.txtKamatnaStopa.ReadOnly = true;
            this.txtKamatnaStopa.Size = new System.Drawing.Size(272, 22);
            this.txtKamatnaStopa.TabIndex = 0;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(56, 29);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(102, 16);
            this.lblPretraga.TabIndex = 41;
            this.lblPretraga.Text = "Jmbg/deo jmbg";
            // 
            // checkPotpisBankara
            // 
            this.checkPotpisBankara.AutoSize = true;
            this.checkPotpisBankara.Location = new System.Drawing.Point(26, 523);
            this.checkPotpisBankara.Name = "checkPotpisBankara";
            this.checkPotpisBankara.Size = new System.Drawing.Size(120, 20);
            this.checkPotpisBankara.TabIndex = 42;
            this.checkPotpisBankara.Text = "Potpis bankara";
            this.checkPotpisBankara.UseVisualStyleBackColor = true;
            // 
            // checkPotpisKorisnika
            // 
            this.checkPotpisKorisnika.AutoSize = true;
            this.checkPotpisKorisnika.Location = new System.Drawing.Point(218, 523);
            this.checkPotpisKorisnika.Name = "checkPotpisKorisnika";
            this.checkPotpisKorisnika.Size = new System.Drawing.Size(124, 20);
            this.checkPotpisKorisnika.TabIndex = 43;
            this.checkPotpisKorisnika.Text = "Potpis korisnika";
            this.checkPotpisKorisnika.UseVisualStyleBackColor = true;
            // 
            // UCIzmeniUgovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkPotpisKorisnika);
            this.Controls.Add(this.checkPotpisBankara);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzmeniStavku);
            this.Controls.Add(this.btnUcitajStavku);
            this.Controls.Add(this.btnUcitajUgovor);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.txtDatumKreiranja);
            this.Controls.Add(this.cbUsluga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUgovor);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.txtKriterijum);
            this.Name = "UCIzmeniUgovor";
            this.Size = new System.Drawing.Size(951, 687);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.DataGridView dgvUgovor;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox txtDatumKreiranja;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.DataGridView dgvStavke;
        private Button btnUcitajUgovor;
        private Button btnUcitajStavku;
        private Button btnIzmeniStavku;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtIznosUsluge;
        private TextBox txtKamatnaStopa;
        private Label lblPretraga;
        private CheckBox checkPotpisBankara;
        private CheckBox checkPotpisKorisnika;

       
        public TextBox TxtKriterijum { get => txtKriterijum; set => txtKriterijum = value; }
        public Button BtnPronadji { get => btnPronadji; set => btnPronadji = value; }
        public DataGridView DgvUgovor { get => dgvUgovor; set => dgvUgovor = value; }
        
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public TextBox TxtDatumKreiranja { get => txtDatumKreiranja; set => txtDatumKreiranja = value; }
        public ComboBox CbUsluga { get => cbUsluga; set => cbUsluga = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label LblPretraga { get => lblPretraga; set => lblPretraga = value; }
        public TextBox TxtKorisnik { get => txtKorisnik; set => txtKorisnik = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public TextBox TxtIznosUsluge { get => txtIznosUsluge; set => txtIznosUsluge = value; }
        public TextBox TxtKamatnaStopa { get => txtKamatnaStopa; set => txtKamatnaStopa = value; }
        public Button BtnUcitajUgovor { get => btnUcitajUgovor; set => btnUcitajUgovor = value; }
        public Button BtnUcitajStavku { get => btnUcitajStavku; set => btnUcitajStavku = value; }
        public Button BtnIzmeniStavku { get => btnIzmeniStavku; set => btnIzmeniStavku = value; }
        public CheckBox CheckPotpisBankara { get => checkPotpisBankara; set => checkPotpisBankara = value; }
        public CheckBox CheckPotpisKorisnika { get => checkPotpisKorisnika; set => checkPotpisKorisnika = value; }

    }
}
