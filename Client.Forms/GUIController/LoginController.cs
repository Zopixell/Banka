using Client.Forms.ServerCommunication;
using Client.Forms.Session;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class LoginController
    {
      //  public Bankar Bankar { get; set; }

        internal void Login(FrmLogin frmLogin)
        {
            string korisnickoIme = frmLogin.TxtKorisnickoIme.Text;
            string sifra = frmLogin.TxtSifra.Text;
          
            if(string.IsNullOrEmpty(korisnickoIme)|| string.IsNullOrEmpty(sifra))
            {
                frmLogin.TxtKorisnickoIme.BackColor = Color.Yellow;
                frmLogin.TxtSifra.BackColor = Color.Yellow;
                return;
            }
            try
            {
                Bankar bankar = new Bankar
                {
                    KorisnickoIme = korisnickoIme,
                    Sifra = sifra,
                };

                Communication.Instance.Connect();

                SessionData.Instance.Bankar = Communication.Instance.SendRequestGetResult<Bankar>(Common.Communication.Operation.Login, bankar);
                if (SessionData.Instance.Bankar != null)
                {
                    MessageBox.Show("Sistem je uspesno prijavio zaposlenog.");
                    frmLogin.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da prijavi zaposlenog");
                }
            
                    
              }
           
            catch (SocketException ex)
            {

                MessageBox.Show("Greska pri radu sa serverom!" + ex.Message);
            }
            catch (Exception exx )
            {
                MessageBox.Show(exx.Message);
            }
        }

    }
}
