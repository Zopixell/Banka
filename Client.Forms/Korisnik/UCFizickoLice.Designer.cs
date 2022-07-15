using System.Windows.Forms;

namespace Client.Forms.Korisnik
{
    partial class UCFizickoLice
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
            this.lblVisinaPlate = new System.Windows.Forms.Label();
            this.lblDuzinaZaposlenja = new System.Windows.Forms.Label();
            this.txtVIsinaPlate = new System.Windows.Forms.TextBox();
            this.txtDuzinaZaposlenja = new System.Windows.Forms.TextBox();
            this.btnDodajFizicko = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVisinaPlate
            // 
            this.lblVisinaPlate.AutoSize = true;
            this.lblVisinaPlate.Location = new System.Drawing.Point(29, 45);
            this.lblVisinaPlate.Name = "lblVisinaPlate";
            this.lblVisinaPlate.Size = new System.Drawing.Size(80, 16);
            this.lblVisinaPlate.TabIndex = 0;
            this.lblVisinaPlate.Text = "Visina plate:";
            // 
            // lblDuzinaZaposlenja
            // 
            this.lblDuzinaZaposlenja.AutoSize = true;
            this.lblDuzinaZaposlenja.Location = new System.Drawing.Point(29, 97);
            this.lblDuzinaZaposlenja.Name = "lblDuzinaZaposlenja";
            this.lblDuzinaZaposlenja.Size = new System.Drawing.Size(120, 16);
            this.lblDuzinaZaposlenja.TabIndex = 1;
            this.lblDuzinaZaposlenja.Text = "Duzina zaposlenja:";
            // 
            // txtVIsinaPlate
            // 
            this.txtVIsinaPlate.Location = new System.Drawing.Point(172, 39);
            this.txtVIsinaPlate.Name = "txtVIsinaPlate";
            this.txtVIsinaPlate.Size = new System.Drawing.Size(344, 22);
            this.txtVIsinaPlate.TabIndex = 2;
            // 
            // txtDuzinaZaposlenja
            // 
            this.txtDuzinaZaposlenja.Location = new System.Drawing.Point(172, 91);
            this.txtDuzinaZaposlenja.Name = "txtDuzinaZaposlenja";
            this.txtDuzinaZaposlenja.Size = new System.Drawing.Size(344, 22);
            this.txtDuzinaZaposlenja.TabIndex = 3;
            // 
            // btnDodajFizicko
            // 
            this.btnDodajFizicko.Location = new System.Drawing.Point(247, 280);
            this.btnDodajFizicko.Name = "btnDodajFizicko";
            this.btnDodajFizicko.Size = new System.Drawing.Size(174, 38);
            this.btnDodajFizicko.TabIndex = 9;
            this.btnDodajFizicko.Text = "Dodaj fizicko";
            this.btnDodajFizicko.UseVisualStyleBackColor = true;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(172, 139);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(344, 22);
            this.txtIme.TabIndex = 10;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(172, 182);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(344, 22);
            this.txtPrezime.TabIndex = 11;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(172, 227);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(344, 22);
            this.txtJMBG.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "JMBG:";
            // 
            // UCFizickoLice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnDodajFizicko);
            this.Controls.Add(this.txtDuzinaZaposlenja);
            this.Controls.Add(this.txtVIsinaPlate);
            this.Controls.Add(this.lblDuzinaZaposlenja);
            this.Controls.Add(this.lblVisinaPlate);
            this.Name = "UCFizickoLice";
            this.Size = new System.Drawing.Size(691, 435);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisinaPlate;
        private System.Windows.Forms.Label lblDuzinaZaposlenja;
        private System.Windows.Forms.TextBox txtVIsinaPlate;
        private System.Windows.Forms.TextBox txtDuzinaZaposlenja;
        private System.Windows.Forms.Button btnDodajFizicko;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtJMBG;
        private Label label1;
        private Label label2;
        private Label label3;

        public TextBox TxtVIsinaPlate { get=> txtVIsinaPlate; set=> txtVIsinaPlate=value; }
        public TextBox TxtDuzinaZaposlenja { get => txtDuzinaZaposlenja; set=> txtDuzinaZaposlenja=value; }
        public Button BtnDodajFizicko { get=> btnDodajFizicko; set=> btnDodajFizicko=value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }

    }
}
