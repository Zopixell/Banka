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
    public partial class UCBrisanjeUsluge : UserControl
    {
        BrisanjeUslugeController controller;
        public UCBrisanjeUsluge()
        {
            InitializeComponent();
            controller = new BrisanjeUslugeController(this);
            controller.Init();
        }
    }
}
