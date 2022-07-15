﻿using Client.Forms.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController;
        public FrmLogin()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            loginController.Login(this);
        }
    }
}
