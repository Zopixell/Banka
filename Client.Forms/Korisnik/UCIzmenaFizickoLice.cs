using Client.Forms.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.Korisnik
{
    public partial class UCIzmenaFizickoLice : UserControl
    {
        IzmenaFizickogLicaController controller;
        public UCIzmenaFizickoLice()
        {
            InitializeComponent();
            controller = new IzmenaFizickogLicaController(this);
            controller.Init();
        }


        #region
        // FizickoLiceController fizickoLiceController;
        //  private UCFizickoLice unosKorisnika;

        //public UCIzmenaFizickoLice()
        //{
        //    InitializeComponent();
        //    controller = new KorisnikController(this);
        //    //controller.Init();
        //}
        //private void btnFizicko_Click (object sender, EventArgs e)
        //{
        //    ChangePanel(new UCFizickoLice());
        //    btnPravno.Enabled = false;
        //    btnFizicko.Enabled = true;
        //}
        //private void ChangePanel(UserControl userControl)
        //{
        //    pnlKorisnik.Controls.Clear();
        //    userControl.Dock = DockStyle.Fill;
        //    pnlKorisnik.Controls.Add(userControl);
        //}
        //private void btnPravno_Click(object sender, EventArgs e)
        //{
        //    ChangePanel(new UCPravnoLice());
        //    btnPravno.Enabled = true;
        //    btnFizicko.Enabled = false;
        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
        #endregion

       
    }
}
