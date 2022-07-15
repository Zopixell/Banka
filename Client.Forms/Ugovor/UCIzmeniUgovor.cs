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
    public partial class UCIzmeniUgovor : UserControl
    {
        IzmenaUgovoraController controller;
        public UCIzmeniUgovor()
        {
            InitializeComponent();
            controller = new IzmenaUgovoraController(this);
            controller.Init();
        }
    }
}
