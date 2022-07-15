using Client.Forms.GUIController;
using Server.ApplicationLogic;
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
    public partial class UCFizickoLice : UserControl
    {
        FizickoLiceController controller;
      
       

        public UCFizickoLice()
        {
            InitializeComponent();
            controller = new FizickoLiceController(this);
         
            controller.Init();
        }

        #region
        //public UCFizickoLice(FizickoLiceController controller)
        //{

        //}

        //private void btnDodajFizicko_Click(object sender, EventArgs e)
        //{
        //  //  controller.SacuvajFizickoLice(TxtIme, TxtPrezime, TxtJMBG, txtVIsinaPlate, txtDuzinaZaposlenja);

        //}
        #endregion
    }
}
