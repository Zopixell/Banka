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
    public partial class UCRaskidanjeUgovora : UserControl
    {
        RaskidUgovoraController controller;
        public UCRaskidanjeUgovora()
        {
            InitializeComponent();
            controller = new RaskidUgovoraController(this);
            controller.Init();
        }
    }
}
