using Client.Forms.Korisnik;
using Client.Forms.ServerCommunication;
using Common.Domain;
using Server.ApplicationLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class FizickoLiceController
    {

        UCFizickoLice unosFizickog;
        BindingList<FizickoLice> lista = new BindingList<FizickoLice>();
       
        

        public FizickoLiceController(UCFizickoLice unosFizickog)
        {
            this.unosFizickog = unosFizickog;
        }

        public FizickoLiceController(UCFizickoLice unosFizickog,UCIzmenaFizickoLice unosKorisnika)
        {
            this.unosFizickog = unosFizickog;
           
            
        }
        internal void Init()
        {
            unosFizickog.BtnDodajFizicko.Click += btnDodaj_Click;
           
        }
       
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Common.Domain.FizickoLice fiz = new Common.Domain.FizickoLice();
                if (!Validacije.Helper.PraznoPoljeValidacija(unosFizickog.TxtIme) |
                    !Validacije.Helper.PraznoPoljeValidacija(unosFizickog.TxtPrezime) |
                    !Validacije.Helper.PraznoPoljeValidacija(unosFizickog.TxtJMBG)|
                    !Validacije.Helper.PraznoPoljeValidacija(unosFizickog.TxtVIsinaPlate)|
                    !Validacije.Helper.PraznoPoljeValidacija(unosFizickog.TxtDuzinaZaposlenja))
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti novog korisnika. (fizicko lice)");

                    return;
                }

                if (!Validacije.Helper.IntValidacija(unosFizickog.TxtVIsinaPlate)|
                    !Validacije.Helper.IntValidacija(unosFizickog.TxtDuzinaZaposlenja))
                {

                    MessageBox.Show("Sistem ne moze da zapamti novog korisnika. (fizicko lice)"); 
                    return;
                }
                if (!Validacije.Helper.JMBGValidacija(unosFizickog.TxtJMBG))
                {
                    MessageBox.Show("Sistem ne moze da zapamti novog korisnika. (fizicko lice)");
                    return;
                }
                
                fiz.Korisnik = new Common.Domain.Korisnik();
                fiz.Korisnik.ImeKorisnika = unosFizickog.TxtIme.Text;
                fiz.Korisnik.PrezimeKorisnika = unosFizickog.TxtPrezime.Text;
                fiz.Korisnik.JMBG = unosFizickog.TxtJMBG.Text;
                fiz.Korisnik.Bankar = Session.SessionData.Instance.Bankar;
                fiz.VisinaPlate = double.Parse(unosFizickog.TxtVIsinaPlate.Text);
                fiz.DuzinaZaposlenja = int.Parse(unosFizickog.TxtDuzinaZaposlenja.Text);

                fiz.primaryKey = fiz.Korisnik.KorisnikID;

                Communication.Instance.SendRequestNoResult(Common.Communication.Operation.SacuvajFizickoLice, fiz);
                System.Windows.Forms.MessageBox.Show("Sistem je zapamtio novog korisnika! (fizicko lice)");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da zapamti novog korisnika. (fizicko lice)");
            }
        }

        #region
        public void SacuvajFizickoLice(TextBox txtImeKorisnika, TextBox txtPrezimeKorisnika, TextBox txtJmbg, TextBox txtVisinaPlate, TextBox txtDuzinaZaposlenja)
        {

            try
            {
                if (!Validacije.Helper.PraznoPoljeValidacija(txtImeKorisnika) |
                       !Validacije.Helper.PraznoPoljeValidacija(txtPrezimeKorisnika) |
                       !Validacije.Helper.PraznoPoljeValidacija(txtJmbg) |
                           !Validacije.Helper.PraznoPoljeValidacija(txtVisinaPlate) |
                           !Validacije.Helper.PraznoPoljeValidacija(txtDuzinaZaposlenja) 
                          )
                {
                    return;
                }
                Common.Domain.FizickoLice fizickoLice = new Common.Domain.FizickoLice
                {
                    Korisnik = new Common.Domain.Korisnik
                    {
                        ImeKorisnika = txtImeKorisnika.Text,
                        PrezimeKorisnika = txtPrezimeKorisnika.Text,
                        JMBG = txtJmbg.Text
                    },
                    VisinaPlate = double.Parse(txtVisinaPlate.Text),
                    DuzinaZaposlenja = int.Parse(txtDuzinaZaposlenja.Text),
                };
                Controller.Instance.SacuvajFizickoLice(fizickoLice);
                MessageBox.Show("Uspesno sacuvano fizicko lice");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
