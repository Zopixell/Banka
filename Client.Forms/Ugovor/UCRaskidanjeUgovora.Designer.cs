using System.Windows.Forms;

namespace Client.Forms.Ugovor
{
    partial class UCRaskidanjeUgovora
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
            this.btnRaskini = new System.Windows.Forms.Button();
            this.dgvUgovor = new System.Windows.Forms.DataGridView();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.txtDatumKreiranja = new System.Windows.Forms.TextBox();
            this.cbUsluga = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBankar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUcitajUgovor = new System.Windows.Forms.Button();
            this.lblPretraga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRaskini
            // 
            this.btnRaskini.Location = new System.Drawing.Point(281, 440);
            this.btnRaskini.Name = "btnRaskini";
            this.btnRaskini.Size = new System.Drawing.Size(131, 41);
            this.btnRaskini.TabIndex = 27;
            this.btnRaskini.Text = "Raskini ugovor";
            this.btnRaskini.UseVisualStyleBackColor = true;
            // 
            // dgvUgovor
            // 
            this.dgvUgovor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovor.Location = new System.Drawing.Point(28, 52);
            this.dgvUgovor.Name = "dgvUgovor";
            this.dgvUgovor.RowHeadersWidth = 51;
            this.dgvUgovor.RowTemplate.Height = 24;
            this.dgvUgovor.Size = new System.Drawing.Size(859, 114);
            this.dgvUgovor.TabIndex = 25;
            // 
            // btnPronadji
            // 
            this.btnPronadji.Location = new System.Drawing.Point(626, 14);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(137, 23);
            this.btnPronadji.TabIndex = 24;
            this.btnPronadji.Text = "Pronadji";
            this.btnPronadji.UseVisualStyleBackColor = true;
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(207, 15);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(317, 22);
            this.txtKriterijum.TabIndex = 23;
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(290, 219);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(192, 22);
            this.txtKorisnik.TabIndex = 36;
            // 
            // txtDatumKreiranja
            // 
            this.txtDatumKreiranja.Location = new System.Drawing.Point(290, 312);
            this.txtDatumKreiranja.Name = "txtDatumKreiranja";
            this.txtDatumKreiranja.ReadOnly = true;
            this.txtDatumKreiranja.Size = new System.Drawing.Size(192, 22);
            this.txtDatumKreiranja.TabIndex = 35;
            // 
            // cbUsluga
            // 
            this.cbUsluga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(290, 257);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(192, 24);
            this.cbUsluga.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Usluga:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Korisnik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Datum izmene:";
            // 
            // txtBankar
            // 
            this.txtBankar.Location = new System.Drawing.Point(290, 359);
            this.txtBankar.Name = "txtBankar";
            this.txtBankar.ReadOnly = true;
            this.txtBankar.Size = new System.Drawing.Size(192, 22);
            this.txtBankar.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Bankar:";
            // 
            // btnUcitajUgovor
            // 
            this.btnUcitajUgovor.Location = new System.Drawing.Point(318, 172);
            this.btnUcitajUgovor.Name = "btnUcitajUgovor";
            this.btnUcitajUgovor.Size = new System.Drawing.Size(145, 29);
            this.btnUcitajUgovor.TabIndex = 39;
            this.btnUcitajUgovor.Text = "Ucitaj ugovor";
            this.btnUcitajUgovor.UseVisualStyleBackColor = true;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(28, 15);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(102, 16);
            this.lblPretraga.TabIndex = 40;
            this.lblPretraga.Text = "Jmbg/deo jmbg";
            // 
            // UCRaskidanjeUgovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.btnUcitajUgovor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBankar);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.txtDatumKreiranja);
            this.Controls.Add(this.cbUsluga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRaskini);
            this.Controls.Add(this.dgvUgovor);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.txtKriterijum);
            this.Name = "UCRaskidanjeUgovora";
            this.Size = new System.Drawing.Size(930, 525);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRaskini;
        private System.Windows.Forms.DataGridView dgvUgovor;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.TextBox txtDatumKreiranja;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBankar;
        private System.Windows.Forms.Label label2;
        private Button btnUcitajUgovor;
        private Label lblPretraga;

        public Button BtnUcitajUgovor { get => btnUcitajUgovor; set => btnUcitajUgovor = value; }
        public Button BtnRaskini { get => btnRaskini; set => btnRaskini = value; }
        public DataGridView DgvUgovor { get => dgvUgovor; set => dgvUgovor = value; }
        public Button BtnPronadji { get => btnPronadji; set => btnPronadji = value; }
        public TextBox TxtKriterijum { get => txtKriterijum; set => txtKriterijum = value; }
        public TextBox TxtKorisnik { get => txtKorisnik; set => txtKorisnik = value; }
        public TextBox TxtDatumKreiranja { get => txtDatumKreiranja; set => txtDatumKreiranja = value; }
        public ComboBox CbUsluga { get => cbUsluga; set => cbUsluga = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtBankar { get => txtBankar; set => txtBankar = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label LblPretraga { get => lblPretraga; set => lblPretraga = value; }

    }
}
