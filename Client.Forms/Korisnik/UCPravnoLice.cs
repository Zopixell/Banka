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
    public partial class UCPravnoLice : UserControl
    {
        PravnoLiceController controller;
        public UCPravnoLice()
        {
            InitializeComponent();
            controller = new PravnoLiceController(this);
            controller.Init();
        }
    }
}
