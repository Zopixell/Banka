using Client.Forms.Korisnik;
using Client.Forms.ServerCommunication;
using Common.Domain;
using Server.ApplicationLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class PravnoLiceController
    {

        UCPravnoLice unosPravnog;
       // UCKorisnikPravnoLicePretraga pretragaPravnog;

        public PravnoLiceController(UCPravnoLice unosPravnog)
        {
            this.unosPravnog = unosPravnog;
        }
            
        
        public void Init()
        {

            unosPravnog.BtnDodajPravno.Click += btnDodaj_Click;
          
        }
       
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Common.Domain.PravnoLice pravno = new Common.Domain.PravnoLice();
                if (!Validacije.Helper.PraznoPoljeValidacija(unosPravnog.TxtIme) |
                    !Validacije.Helper.PraznoPoljeValidacija(unosPravnog.TxtPrezime) |
                    !Validacije.Helper.PraznoPoljeValidacija(unosPravnog.TxtJMBG)|
                    !Validacije.Helper.PraznoPoljeValidacija(unosPravnog.TxtPIB)|
                    !Validacije.Helper.PraznoPoljeValidacija(unosPravnog.TxtMesecnaZarada)|
                    !Validacije.Helper.PraznoPoljeValidacija(unosPravnog.TxtDatumOsnivanja))
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti novog korisnika. (pravno lice)");
                    return;
                }

                if (!Validacije.Helper.IntValidacija(unosPravnog.TxtMesecnaZarada) |
                    !Validacije.Helper.IntValidacija(unosPravnog.TxtPIB))
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti novog korisnika. (pravno lice)");
                    return;
                }

                if (!Validacije.Helper.ValidacijaDatuma(unosPravnog.TxtDatumOsnivanja))
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti novog korisnika. (pravno lice)");
                    return;
                }
                if (!Validacije.Helper.JMBGValidacija(unosPravnog.TxtJMBG))
                {
                    return;
                }
                pravno.Korisnik = new Common.Domain.Korisnik();
                pravno.Korisnik.ImeKorisnika = unosPravnog.TxtIme.Text;
                pravno.Korisnik.PrezimeKorisnika = unosPravnog.TxtPrezime.Text;
                pravno.Korisnik.JMBG = unosPravnog.TxtJMBG.Text;
                pravno.Korisnik.Bankar = Session.SessionData.Instance.Bankar;
                pravno.MesecnaZarada = double.Parse(unosPravnog.TxtMesecnaZarada.Text);
                pravno.PIB = int.Parse(unosPravnog.TxtPIB.Text);
                pravno.DatumOsnivanja = DateTime.ParseExact(unosPravnog.TxtDatumOsnivanja.Text, "dd.MM.yyyy", null);

                pravno.primaryKey = pravno.Korisnik.KorisnikID;
                ServerCommunication.Communication.Instance.SendRequestNoResult(Common.Communication.Operation.SacuvajPravnoLice, pravno);
                System.Windows.Forms.MessageBox.Show("Sistem je zapamtio novog korisnika! (pravno lice)");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da zapamti novog korisnika. (pravno lice)");
            }
        }
        #region
        public void SacuvajPravnoLice(TextBox txtImeKorisnika, TextBox txtPrezimeKorisnika, TextBox txtJmbg, TextBox txtMesecnaZarada, TextBox txtPIB, TextBox txtDatumOsnivanja)
        {

            try
            {
                if (!Validacije.Helper.PraznoPoljeValidacija(txtImeKorisnika)|
                    !Validacije.Helper.PraznoPoljeValidacija(txtPrezimeKorisnika)|
                    !Validacije.Helper.PraznoPoljeValidacija(txtJmbg)|
                        !Validacije.Helper.PraznoPoljeValidacija(txtMesecnaZarada)|
                        !Validacije.Helper.PraznoPoljeValidacija(txtPIB)|
                        !Validacije.Helper.ValidacijaDatuma(txtDatumOsnivanja))
                {
                    return;
                }
                Common.Domain.PravnoLice pravno = new Common.Domain.PravnoLice
                {
                    Korisnik = new Common.Domain.Korisnik
                    {
                        ImeKorisnika = txtImeKorisnika.Text,
                        PrezimeKorisnika = txtPrezimeKorisnika.Text,
                        JMBG = txtJmbg.Text
                    },
                    MesecnaZarada = double.Parse(txtMesecnaZarada.Text),
                    PIB = int.Parse(txtPIB.Text),
                    DatumOsnivanja = DateTime.ParseExact(txtDatumOsnivanja.Text,"dd.MM.yyyy",null),
                };
                Controller.Instance.SacuvajPravnoLice(pravno);
                MessageBox.Show("Uspesno sacuvano pravno lice");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
