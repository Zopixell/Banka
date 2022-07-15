using Client.Forms.ServerCommunication;
using Client.Forms.Usluga;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Forms.GUIController
{
    public class UslugaController
    {
        UCUsluga unosUsluge;
        public UslugaController(UCUsluga unosUsluge)
        {
            this.unosUsluge = unosUsluge;   
        }
        internal void Init()
        {

            unosUsluge.BtnDodaj.Click += btnDodaj_Click;

        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if(!Validacije.Helper.PraznoPoljeValidacija(unosUsluge.TxtNaziv)|
                    !Validacije.Helper.PraznoPoljeValidacija(unosUsluge.TxtMinimalniIznos)|
                    !Validacije.Helper.PraznoPoljeValidacija(unosUsluge.TxtMaksimalniIznos) |
                    !Validacije.Helper.PraznoPoljeValidacija(unosUsluge.TxtKamatnaStopa))
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti bankarsku uslugu.");
                    return;
                }
                if (!Validacije.Helper.IntValidacija(unosUsluge.TxtKamatnaStopa))
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti bankarsku uslugu.");
                    return;
                }
                if (int.Parse(unosUsluge.TxtMaksimalniIznos.Text) <= 0) 
                {
                    unosUsluge.TxtMaksimalniIznos.BackColor = Color.Red;
                    unosUsluge.TxtMaksimalniIznos.Text = "vece od 0 uneti";
                    return;
                }
                if( int.Parse(unosUsluge.TxtMinimalniIznos.Text) <= 0)
                {
                    unosUsluge.TxtMinimalniIznos.BackColor = Color.Red;
                    unosUsluge.TxtMinimalniIznos.Text = "vece od 0 uneti";
                    return;
                }
                if (int.Parse(unosUsluge.TxtKamatnaStopa.Text)<=0 || int.Parse(unosUsluge.TxtKamatnaStopa.Text) > 100){
                    unosUsluge.TxtKamatnaStopa.BackColor = Color.Red;
                    unosUsluge.TxtKamatnaStopa.Text = " 0-100 uneti";
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti bankarsku uslugu.");
                    return;
                }
                Common.Domain.Usluga u = new Common.Domain.Usluga();
                u.NazivUsluge = unosUsluge.TxtNaziv.Text;
                u.MinimalniIznos = Double.Parse(unosUsluge.TxtMinimalniIznos.Text);
                u.MaksimalniIznos = Double.Parse(unosUsluge.TxtMaksimalniIznos.Text);
                u.KamatnaStopa = Double.Parse(unosUsluge.TxtKamatnaStopa.Text);
                u.Bankar = Session.SessionData.Instance.Bankar;
                Communication.Instance.SendRequestNoResult(Common.Communication.Operation.SacuvajUslugu, u);
                System.Windows.Forms.MessageBox.Show("Sistem je zapamtio bankarsku uslugu.");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti bankarsku uslugu.");
            }
        }
    }
}
