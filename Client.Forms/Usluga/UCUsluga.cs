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

namespace Client.Forms.Usluga
{
    public partial class UCUsluga : UserControl
    {
        UslugaController controller;
        public UCUsluga()
        {
            InitializeComponent();
            controller = new UslugaController(this);
            controller.Init();
        }

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        private void UCUsluga_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }
    }
}
