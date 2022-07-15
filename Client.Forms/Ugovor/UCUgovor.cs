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

namespace Client.Forms.Ugovor
{
    public partial class UCUgovor : UserControl
    {
        UgovorController controller;
        public UCUgovor()
        {
            InitializeComponent();
            controller =  new UgovorController(this);
            controller.Init();
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        
        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
