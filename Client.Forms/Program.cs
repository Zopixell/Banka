using Client.Forms.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                try
                {
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.ShowDialog();
                    DialogResult result = frmLogin.DialogResult;
                    frmLogin.Dispose();

                    if (result == DialogResult.OK)
                    {
                        Application.Run(new FrmMain());
                    }
                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Greska pri radu sa serverom!");
                }
            }

           // Application.Run(new FrmLogin());
        }
    }
}
