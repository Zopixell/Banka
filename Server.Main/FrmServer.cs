using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Main
{
    public partial class FrmServer : Form
    {
        private Server s;
        public FrmServer()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            this.FormClosed += FrmServer_FormClosed;
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.Start())
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                MessageBox.Show("Server je pokrenut");
                Thread nit = new Thread(s.Listen);
                nit.Start();
            }
            else
            {
                MessageBox.Show("Server nije pokrenut!");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            s?.Stop();
            s = null;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            MessageBox.Show("Server je zaustavljen!");
        }
    }
}
