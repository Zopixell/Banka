namespace Client.Forms
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fizickoLiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pravnoLiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fizickoLiceToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pravnoLiceToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaKorisnkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fizickoLiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pravnoLiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uslugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugovorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeUgovoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaUgovoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raskidanjeUgovoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnikToolStripMenuItem,
            this.uslugaToolStripMenuItem,
            this.ugovorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosKorisnikaToolStripMenuItem,
            this.izmenaKorisnikaToolStripMenuItem,
            this.pretragaKorisnkaToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // unosKorisnikaToolStripMenuItem
            // 
            this.unosKorisnikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fizickoLiceToolStripMenuItem,
            this.pravnoLiceToolStripMenuItem});
            this.unosKorisnikaToolStripMenuItem.Name = "unosKorisnikaToolStripMenuItem";
            this.unosKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.unosKorisnikaToolStripMenuItem.Text = "Unos korisnika";
            this.unosKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.unosKorisnikaToolStripMenuItem_Click);
            // 
            // fizickoLiceToolStripMenuItem
            // 
            this.fizickoLiceToolStripMenuItem.Name = "fizickoLiceToolStripMenuItem";
            this.fizickoLiceToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.fizickoLiceToolStripMenuItem.Text = "Fizicko Lice";
            this.fizickoLiceToolStripMenuItem.Click += new System.EventHandler(this.fizickoLiceToolStripMenuItem_Click);
            // 
            // pravnoLiceToolStripMenuItem
            // 
            this.pravnoLiceToolStripMenuItem.Name = "pravnoLiceToolStripMenuItem";
            this.pravnoLiceToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.pravnoLiceToolStripMenuItem.Text = "Pravno Lice";
            this.pravnoLiceToolStripMenuItem.Click += new System.EventHandler(this.pravnoLiceToolStripMenuItem_Click);
            // 
            // izmenaKorisnikaToolStripMenuItem
            // 
            this.izmenaKorisnikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fizickoLiceToolStripMenuItem2,
            this.pravnoLiceToolStripMenuItem2});
            this.izmenaKorisnikaToolStripMenuItem.Name = "izmenaKorisnikaToolStripMenuItem";
            this.izmenaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.izmenaKorisnikaToolStripMenuItem.Text = "Izmena korisnika";
            // 
            // fizickoLiceToolStripMenuItem2
            // 
            this.fizickoLiceToolStripMenuItem2.Name = "fizickoLiceToolStripMenuItem2";
            this.fizickoLiceToolStripMenuItem2.Size = new System.Drawing.Size(164, 26);
            this.fizickoLiceToolStripMenuItem2.Text = "Fizicko lice";
            this.fizickoLiceToolStripMenuItem2.Click += new System.EventHandler(this.fizickoLiceToolStripMenuItem2_Click);
            // 
            // pravnoLiceToolStripMenuItem2
            // 
            this.pravnoLiceToolStripMenuItem2.Name = "pravnoLiceToolStripMenuItem2";
            this.pravnoLiceToolStripMenuItem2.Size = new System.Drawing.Size(164, 26);
            this.pravnoLiceToolStripMenuItem2.Text = "Pravno lice";
            this.pravnoLiceToolStripMenuItem2.Click += new System.EventHandler(this.pravnoLiceToolStripMenuItem2_Click);
            // 
            // pretragaKorisnkaToolStripMenuItem
            // 
            this.pretragaKorisnkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fizickoLiceToolStripMenuItem1,
            this.pravnoLiceToolStripMenuItem1});
            this.pretragaKorisnkaToolStripMenuItem.Name = "pretragaKorisnkaToolStripMenuItem";
            this.pretragaKorisnkaToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.pretragaKorisnkaToolStripMenuItem.Text = "Pretraga korisnka";
            this.pretragaKorisnkaToolStripMenuItem.Click += new System.EventHandler(this.pretragaKorisnkaToolStripMenuItem_Click);
            // 
            // fizickoLiceToolStripMenuItem1
            // 
            this.fizickoLiceToolStripMenuItem1.Name = "fizickoLiceToolStripMenuItem1";
            this.fizickoLiceToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.fizickoLiceToolStripMenuItem1.Text = "Fizicko lice";
            this.fizickoLiceToolStripMenuItem1.Click += new System.EventHandler(this.fizickoLiceToolStripMenuItem1_Click);
            // 
            // pravnoLiceToolStripMenuItem1
            // 
            this.pravnoLiceToolStripMenuItem1.Name = "pravnoLiceToolStripMenuItem1";
            this.pravnoLiceToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.pravnoLiceToolStripMenuItem1.Text = "Pravno lice";
            this.pravnoLiceToolStripMenuItem1.Click += new System.EventHandler(this.pravnoLiceToolStripMenuItem1_Click);
            // 
            // uslugaToolStripMenuItem
            // 
            this.uslugaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosUslugeToolStripMenuItem,
            this.brisanjeUslugeToolStripMenuItem});
            this.uslugaToolStripMenuItem.Name = "uslugaToolStripMenuItem";
            this.uslugaToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.uslugaToolStripMenuItem.Text = "Usluga";
            // 
            // unosUslugeToolStripMenuItem
            // 
            this.unosUslugeToolStripMenuItem.Name = "unosUslugeToolStripMenuItem";
            this.unosUslugeToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.unosUslugeToolStripMenuItem.Text = "Unos usluge";
            this.unosUslugeToolStripMenuItem.Click += new System.EventHandler(this.unosUslugeToolStripMenuItem_Click);
            // 
            // brisanjeUslugeToolStripMenuItem
            // 
            this.brisanjeUslugeToolStripMenuItem.Name = "brisanjeUslugeToolStripMenuItem";
            this.brisanjeUslugeToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.brisanjeUslugeToolStripMenuItem.Text = "Brisanje usluge";
            this.brisanjeUslugeToolStripMenuItem.Click += new System.EventHandler(this.brisanjeUslugeToolStripMenuItem_Click);
            // 
            // ugovorToolStripMenuItem
            // 
            this.ugovorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeUgovoraToolStripMenuItem,
            this.izmenaUgovoraToolStripMenuItem,
            this.raskidanjeUgovoraToolStripMenuItem});
            this.ugovorToolStripMenuItem.Name = "ugovorToolStripMenuItem";
            this.ugovorToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ugovorToolStripMenuItem.Text = "Ugovor";
            // 
            // kreiranjeUgovoraToolStripMenuItem
            // 
            this.kreiranjeUgovoraToolStripMenuItem.Name = "kreiranjeUgovoraToolStripMenuItem";
            this.kreiranjeUgovoraToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.kreiranjeUgovoraToolStripMenuItem.Text = "Kreiranje ugovora";
            this.kreiranjeUgovoraToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeUgovoraToolStripMenuItem_Click);
            // 
            // izmenaUgovoraToolStripMenuItem
            // 
            this.izmenaUgovoraToolStripMenuItem.Name = "izmenaUgovoraToolStripMenuItem";
            this.izmenaUgovoraToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.izmenaUgovoraToolStripMenuItem.Text = "Izmena ugovora";
            this.izmenaUgovoraToolStripMenuItem.Click += new System.EventHandler(this.izmenaUgovoraToolStripMenuItem_Click);
            // 
            // raskidanjeUgovoraToolStripMenuItem
            // 
            this.raskidanjeUgovoraToolStripMenuItem.Name = "raskidanjeUgovoraToolStripMenuItem";
            this.raskidanjeUgovoraToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.raskidanjeUgovoraToolStripMenuItem.Text = "Raskidanje ugovora";
            this.raskidanjeUgovoraToolStripMenuItem.Click += new System.EventHandler(this.raskidanjeUgovoraToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 37);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1013, 671);
            this.pnlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 720);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Bankarski sistem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaKorisnkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uslugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugovorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeUgovoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaUgovoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raskidanjeUgovoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fizickoLiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pravnoLiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fizickoLiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pravnoLiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fizickoLiceToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pravnoLiceToolStripMenuItem2;
    }
}