using System.Windows.Forms;

namespace Client.Forms.Usluga
{
    partial class UCBrisanjeUsluge
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
            this.dgvUgovor = new System.Windows.Forms.DataGridView();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtMinimalniIznos = new System.Windows.Forms.TextBox();
            this.txtMaksimalniIznos = new System.Windows.Forms.TextBox();
            this.txtKamatnaStopa = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblKamatnaStopa = new System.Windows.Forms.Label();
            this.lblMaksimalniIznos = new System.Windows.Forms.Label();
            this.lblMinimalniIznos = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.lblPretraga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUgovor
            // 
            this.dgvUgovor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUgovor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovor.Location = new System.Drawing.Point(39, 68);
            this.dgvUgovor.Name = "dgvUgovor";
            this.dgvUgovor.RowHeadersWidth = 51;
            this.dgvUgovor.RowTemplate.Height = 24;
            this.dgvUgovor.Size = new System.Drawing.Size(650, 155);
            this.dgvUgovor.TabIndex = 27;
            // 
            // btnPronadji
            // 
            this.btnPronadji.Location = new System.Drawing.Point(535, 30);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(137, 23);
            this.btnPronadji.TabIndex = 26;
            this.btnPronadji.Text = "Pronadji";
            this.btnPronadji.UseVisualStyleBackColor = true;
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(236, 30);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(266, 22);
            this.txtKriterijum.TabIndex = 25;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(220, 458);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(137, 23);
            this.btnObrisi.TabIndex = 29;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // txtMinimalniIznos
            // 
            this.txtMinimalniIznos.Location = new System.Drawing.Point(265, 309);
            this.txtMinimalniIznos.Name = "txtMinimalniIznos";
            this.txtMinimalniIznos.ReadOnly = true;
            this.txtMinimalniIznos.Size = new System.Drawing.Size(227, 22);
            this.txtMinimalniIznos.TabIndex = 37;
            // 
            // txtMaksimalniIznos
            // 
            this.txtMaksimalniIznos.Location = new System.Drawing.Point(265, 359);
            this.txtMaksimalniIznos.Name = "txtMaksimalniIznos";
            this.txtMaksimalniIznos.ReadOnly = true;
            this.txtMaksimalniIznos.Size = new System.Drawing.Size(227, 22);
            this.txtMaksimalniIznos.TabIndex = 36;
            // 
            // txtKamatnaStopa
            // 
            this.txtKamatnaStopa.Location = new System.Drawing.Point(265, 405);
            this.txtKamatnaStopa.Name = "txtKamatnaStopa";
            this.txtKamatnaStopa.ReadOnly = true;
            this.txtKamatnaStopa.Size = new System.Drawing.Size(227, 22);
            this.txtKamatnaStopa.TabIndex = 35;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(265, 261);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(227, 22);
            this.txtNaziv.TabIndex = 34;
            // 
            // lblKamatnaStopa
            // 
            this.lblKamatnaStopa.AutoSize = true;
            this.lblKamatnaStopa.Location = new System.Drawing.Point(129, 411);
            this.lblKamatnaStopa.Name = "lblKamatnaStopa";
            this.lblKamatnaStopa.Size = new System.Drawing.Size(100, 16);
            this.lblKamatnaStopa.TabIndex = 33;
            this.lblKamatnaStopa.Text = "Kamatna stopa:";
            // 
            // lblMaksimalniIznos
            // 
            this.lblMaksimalniIznos.AutoSize = true;
            this.lblMaksimalniIznos.Location = new System.Drawing.Point(129, 365);
            this.lblMaksimalniIznos.Name = "lblMaksimalniIznos";
            this.lblMaksimalniIznos.Size = new System.Drawing.Size(112, 16);
            this.lblMaksimalniIznos.TabIndex = 32;
            this.lblMaksimalniIznos.Text = "Maksimalni iznos:";
            // 
            // lblMinimalniIznos
            // 
            this.lblMinimalniIznos.AutoSize = true;
            this.lblMinimalniIznos.Location = new System.Drawing.Point(129, 315);
            this.lblMinimalniIznos.Name = "lblMinimalniIznos";
            this.lblMinimalniIznos.Size = new System.Drawing.Size(100, 16);
            this.lblMinimalniIznos.TabIndex = 31;
            this.lblMinimalniIznos.Text = "Minimalni iznos:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(129, 268);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 16);
            this.lblNaziv.TabIndex = 30;
            this.lblNaziv.Text = "Naziv:";
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(535, 229);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(137, 23);
            this.btnUcitaj.TabIndex = 38;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(47, 33);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(87, 16);
            this.lblPretraga.TabIndex = 39;
            this.lblPretraga.Text = "Unesite naziv";
            // 
            // UCBrisanjeUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.txtMinimalniIznos);
            this.Controls.Add(this.txtMaksimalniIznos);
            this.Controls.Add(this.txtKamatnaStopa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblKamatnaStopa);
            this.Controls.Add(this.lblMaksimalniIznos);
            this.Controls.Add(this.lblMinimalniIznos);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvUgovor);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.txtKriterijum);
            this.Name = "UCBrisanjeUsluge";
            this.Size = new System.Drawing.Size(769, 567);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUgovor;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtMinimalniIznos;
        private System.Windows.Forms.TextBox txtMaksimalniIznos;
        private System.Windows.Forms.TextBox txtKamatnaStopa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblKamatnaStopa;
        private System.Windows.Forms.Label lblMaksimalniIznos;
        private System.Windows.Forms.Label lblMinimalniIznos;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnUcitaj;
        private Label lblPretraga;

        public Button BtnUcitaj { get => btnUcitaj; set => btnUcitaj = value; }
        public DataGridView DgvUgovor { get => dgvUgovor; set => dgvUgovor = value; }
        public Button BtnPronadji { get => btnPronadji; set => btnPronadji = value; }
        public TextBox TxtKriterijum { get => txtKriterijum; set => txtKriterijum = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public TextBox TxtMinimalniIznos { get => txtMinimalniIznos; set => txtMinimalniIznos = value; }
        public TextBox TxtMaksimalniIznos { get => txtMaksimalniIznos; set => txtMaksimalniIznos = value; }
        public TextBox TxtKamatnaStopa { get => txtKamatnaStopa; set => txtKamatnaStopa = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public Label LblPretraga { get => lblPretraga; set => lblPretraga = value; }


    }
}
