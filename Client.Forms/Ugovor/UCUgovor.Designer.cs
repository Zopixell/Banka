using System.Windows.Forms;

namespace Client.Forms.Ugovor
{
    partial class UCUgovor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKorisnik = new System.Windows.Forms.ComboBox();
            this.cbUsluga = new System.Windows.Forms.ComboBox();
            this.txtDatumKreiranja = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIznosUsluge = new System.Windows.Forms.TextBox();
            this.txtKamatnaStopa = new System.Windows.Forms.TextBox();
            this.checkPotpisKorisnika = new System.Windows.Forms.CheckBox();
            this.checkPotpisBankara = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum kreiranja:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Korisnik:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usluga:";
            // 
            // cbKorisnik
            // 
            this.cbKorisnik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKorisnik.FormattingEnabled = true;
            this.cbKorisnik.Location = new System.Drawing.Point(170, 35);
            this.cbKorisnik.Name = "cbKorisnik";
            this.cbKorisnik.Size = new System.Drawing.Size(252, 24);
            this.cbKorisnik.TabIndex = 5;
            // 
            // cbUsluga
            // 
            this.cbUsluga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(170, 77);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(252, 24);
            this.cbUsluga.TabIndex = 6;
            // 
            // txtDatumKreiranja
            // 
            this.txtDatumKreiranja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatumKreiranja.Location = new System.Drawing.Point(170, 123);
            this.txtDatumKreiranja.Name = "txtDatumKreiranja";
            this.txtDatumKreiranja.Size = new System.Drawing.Size(252, 22);
            this.txtDatumKreiranja.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(277, 412);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 43);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIznosUsluge);
            this.groupBox1.Controls.Add(this.txtKamatnaStopa);
            this.groupBox1.Location = new System.Drawing.Point(46, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 140);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavka ugovora";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 68);
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
            this.label2.Location = new System.Drawing.Point(57, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kamatna stopa:";
            // 
            // txtIznosUsluge
            // 
            this.txtIznosUsluge.Location = new System.Drawing.Point(203, 62);
            this.txtIznosUsluge.Name = "txtIznosUsluge";
            this.txtIznosUsluge.Size = new System.Drawing.Size(272, 22);
            this.txtIznosUsluge.TabIndex = 1;
            // 
            // txtKamatnaStopa
            // 
            this.txtKamatnaStopa.Location = new System.Drawing.Point(203, 21);
            this.txtKamatnaStopa.Name = "txtKamatnaStopa";
            this.txtKamatnaStopa.Size = new System.Drawing.Size(272, 22);
            this.txtKamatnaStopa.TabIndex = 0;
            // 
            // checkPotpisKorisnika
            // 
            this.checkPotpisKorisnika.AutoSize = true;
            this.checkPotpisKorisnika.Location = new System.Drawing.Point(225, 200);
            this.checkPotpisKorisnika.Name = "checkPotpisKorisnika";
            this.checkPotpisKorisnika.Size = new System.Drawing.Size(124, 20);
            this.checkPotpisKorisnika.TabIndex = 45;
            this.checkPotpisKorisnika.Text = "Potpis korisnika";
            this.checkPotpisKorisnika.UseVisualStyleBackColor = true;
            // 
            // checkPotpisBankara
            // 
            this.checkPotpisBankara.AutoSize = true;
            this.checkPotpisBankara.Location = new System.Drawing.Point(46, 200);
            this.checkPotpisBankara.Name = "checkPotpisBankara";
            this.checkPotpisBankara.Size = new System.Drawing.Size(120, 20);
            this.checkPotpisBankara.TabIndex = 44;
            this.checkPotpisBankara.Text = "Potpis bankara";
            this.checkPotpisBankara.UseVisualStyleBackColor = true;
            // 
            // UCUgovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkPotpisKorisnika);
            this.Controls.Add(this.checkPotpisBankara);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtDatumKreiranja);
            this.Controls.Add(this.cbUsluga);
            this.Controls.Add(this.cbKorisnik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UCUgovor";
            this.Size = new System.Drawing.Size(717, 586);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKorisnik;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.TextBox txtDatumKreiranja;
        private System.Windows.Forms.Button btnDodaj;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtIznosUsluge;
        private TextBox txtKamatnaStopa;
        private CheckBox checkPotpisKorisnika;
        private CheckBox checkPotpisBankara;

        public ComboBox CbKorisnik { get=> cbKorisnik; set=> cbKorisnik=value; }
        public ComboBox CbUsluga { get=> cbUsluga; set=> cbUsluga=value; }
        public TextBox TxtDatumKreiranja { get=> txtDatumKreiranja; set=> txtDatumKreiranja=value; }
        public TextBox TxtIznosUsluge { get => txtIznosUsluge; set => txtIznosUsluge = value; }
        public TextBox TxtKamatnaStopa { get => txtKamatnaStopa; set => txtKamatnaStopa = value; }
        public Button BtnDodaj { get=> btnDodaj; set=> btnDodaj=value; }
        public CheckBox CheckPotpisKorisnika { get => checkPotpisKorisnika; set => checkPotpisKorisnika = value; }
        public CheckBox CheckPotpisBankara { get => checkPotpisBankara; set => checkPotpisBankara = value; }
       

    }
}
