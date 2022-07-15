using Client.Forms.Korisnik;
using Client.Forms.Ugovor;
using Client.Forms.Usluga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void unosUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCUsluga());
        }
        private void ChangePanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userControl);
        }

        private void unosKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ChangePanel(new UCKorisnik());
        }

        private void fizickoLiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCFizickoLice());
        }

        private void pravnoLiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCPravnoLice());
        }

        private void pretragaKorisnkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fizickoLiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCKorisnikPretraga());
        }

        private void pravnoLiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCKorisnikPravnoLicePretraga());
        }

        private void kreiranjeUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCUgovor());
        }

        private void izmenaUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCIzmeniUgovor());
        }

        private void raskidanjeUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCRaskidanjeUgovora());
        }

        private void fizickoLiceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCIzmenaFizickoLice());
        }

        private void pravnoLiceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCIzmenaPravnoLice());
        }

        private void brisanjeUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCBrisanjeUsluge());
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ServerCommunication.Communication.Instance.Close();
            }
            catch (IOException ex)
            {

                Debug.WriteLine("-------" + ex.Message);
            }
        }
    }
}
