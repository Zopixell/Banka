using System.Windows.Forms;

namespace Client.Forms.Usluga
{
    partial class UCUsluga
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblMinimalniIznos = new System.Windows.Forms.Label();
            this.lblMaksimalniIznos = new System.Windows.Forms.Label();
            this.lblKamatnaStopa = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKamatnaStopa = new System.Windows.Forms.TextBox();
            this.txtMaksimalniIznos = new System.Windows.Forms.TextBox();
            this.txtMinimalniIznos = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(156, 61);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 16);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblMinimalniIznos
            // 
            this.lblMinimalniIznos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimalniIznos.AutoSize = true;
            this.lblMinimalniIznos.Location = new System.Drawing.Point(156, 108);
            this.lblMinimalniIznos.Name = "lblMinimalniIznos";
            this.lblMinimalniIznos.Size = new System.Drawing.Size(100, 16);
            this.lblMinimalniIznos.TabIndex = 1;
            this.lblMinimalniIznos.Text = "Minimalni iznos:";
            // 
            // lblMaksimalniIznos
            // 
            this.lblMaksimalniIznos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaksimalniIznos.AutoSize = true;
            this.lblMaksimalniIznos.Location = new System.Drawing.Point(156, 158);
            this.lblMaksimalniIznos.Name = "lblMaksimalniIznos";
            this.lblMaksimalniIznos.Size = new System.Drawing.Size(112, 16);
            this.lblMaksimalniIznos.TabIndex = 2;
            this.lblMaksimalniIznos.Text = "Maksimalni iznos:";
            // 
            // lblKamatnaStopa
            // 
            this.lblKamatnaStopa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKamatnaStopa.AutoSize = true;
            this.lblKamatnaStopa.Location = new System.Drawing.Point(156, 204);
            this.lblKamatnaStopa.Name = "lblKamatnaStopa";
            this.lblKamatnaStopa.Size = new System.Drawing.Size(100, 16);
            this.lblKamatnaStopa.TabIndex = 3;
            this.lblKamatnaStopa.Text = "Kamatna stopa:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNaziv.Location = new System.Drawing.Point(292, 54);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(227, 22);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtKamatnaStopa
            // 
            this.txtKamatnaStopa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKamatnaStopa.Location = new System.Drawing.Point(292, 198);
            this.txtKamatnaStopa.Name = "txtKamatnaStopa";
            this.txtKamatnaStopa.Size = new System.Drawing.Size(227, 22);
            this.txtKamatnaStopa.TabIndex = 5;
            // 
            // txtMaksimalniIznos
            // 
            this.txtMaksimalniIznos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaksimalniIznos.Location = new System.Drawing.Point(292, 152);
            this.txtMaksimalniIznos.Name = "txtMaksimalniIznos";
            this.txtMaksimalniIznos.Size = new System.Drawing.Size(227, 22);
            this.txtMaksimalniIznos.TabIndex = 6;
            // 
            // txtMinimalniIznos
            // 
            this.txtMinimalniIznos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinimalniIznos.Location = new System.Drawing.Point(292, 102);
            this.txtMinimalniIznos.Name = "txtMinimalniIznos";
            this.txtMinimalniIznos.Size = new System.Drawing.Size(227, 22);
            this.txtMinimalniIznos.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(258, 247);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 31);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // UCUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtMinimalniIznos);
            this.Controls.Add(this.txtMaksimalniIznos);
            this.Controls.Add(this.txtKamatnaStopa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblKamatnaStopa);
            this.Controls.Add(this.lblMaksimalniIznos);
            this.Controls.Add(this.lblMinimalniIznos);
            this.Controls.Add(this.lblNaziv);
            this.Name = "UCUsluga";
            this.Size = new System.Drawing.Size(725, 358);
            this.Load += new System.EventHandler(this.UCUsluga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblMinimalniIznos;
        private System.Windows.Forms.Label lblMaksimalniIznos;
        private System.Windows.Forms.Label lblKamatnaStopa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtKamatnaStopa;
        private System.Windows.Forms.TextBox txtMaksimalniIznos;
        private System.Windows.Forms.TextBox txtMinimalniIznos;
        private System.Windows.Forms.Button btnDodaj;

        public TextBox TxtNaziv { get=>txtNaziv; set=>txtNaziv=value; }
        public TextBox TxtKamatnaStopa { get => txtKamatnaStopa; set=> txtKamatnaStopa=value; }
        public TextBox TxtMaksimalniIznos { get=> txtMaksimalniIznos; set=> txtMaksimalniIznos=value; }
        public TextBox TxtMinimalniIznos { get=> txtMinimalniIznos; set=> txtMinimalniIznos = value; }
        public Button BtnDodaj { get=> btnDodaj; set=> btnDodaj=value; }
    }
}
