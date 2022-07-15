using Client.Forms.Korisnik;
using Client.Forms.ServerCommunication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class IzmenaPravnogLicaController
    {
        UCIzmenaPravnoLice izmenaPravnog;
        PravnoLice pravno;

        public IzmenaPravnogLicaController(UCIzmenaPravnoLice izmenaPravnog)
        {
            this.izmenaPravnog = izmenaPravnog;
        }
        internal void Init()
        {
            List<PravnoLice> lista = new List<PravnoLice>();
            lista = Communication.Instance.SendRequestGetResult<List<PravnoLice>>(Common.Communication.Operation.VratiPravnaLica);
            izmenaPravnog.DgvKorisnici.DataSource = lista;
            izmenaPravnog.BtnPretrazi.Click += btnPretrazi_Click;
            izmenaPravnog.BtnUcitaj.Click += btnUcitaj_Click;
            izmenaPravnog.BtnIzmeni.Click += btnIzmeni_Click;

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
           
                PravnoLice p = new PravnoLice();
                string ime = izmenaPravnog.TxtAtribut.Text;
                
                if (!Validacije.Helper.PraznoPoljeValidacija(izmenaPravnog.TxtAtribut))
                {
                    izmenaPravnog.Label7.Text = "Unesite deo imena ili ime";
                    izmenaPravnog.Label7.BackColor = Color.Red;

                    return;
                }
                

                p.Condition = $"K.ImeKorisnika LIKE '{ime}%'";
                List<PravnoLice> lista = new List<PravnoLice>();
                lista = Communication.Instance.SendRequestGetResult<List<PravnoLice>>(Common.Communication.Operation.PronadjiPravnaLica,p);
                
                izmenaPravnog.DgvKorisnici.DataSource = lista;
            if (lista.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da pronadje korisnika pravno lice po zadatoj vrednosti.");
                return;
            }
            else
            {

               System.Windows.Forms.MessageBox.Show("Sistem je pronasao korisnike pravna lica po zadatoj vrednosti");
            }

                
           

            
        }
        private void btnUcitaj_Click(object sender, EventArgs e)
        {

            if (izmenaPravnog.DgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita korisnika pravno lice po zadatoj vrednosti");
                return;
            }
                PravnoLice p = new PravnoLice();
                p = (PravnoLice)izmenaPravnog.DgvKorisnici.CurrentRow.DataBoundItem;
                p.Condition = $"K.KorisnikID={p.Korisnik.KorisnikID}";
                p = Communication.Instance.SendRequestGetResult<PravnoLice>(Common.Communication.Operation.VratiPravnoLice, p);
                izmenaPravnog.TxtIme.Text = p.Korisnik.ImeKorisnika.ToString();
                izmenaPravnog.TxtPrezime.Text = p.Korisnik.PrezimeKorisnika.ToString();
                izmenaPravnog.TxtJMBG.Text = p.Korisnik.JMBG.ToString();
                izmenaPravnog.TxtMesecnaZarada.Text = p.MesecnaZarada.ToString();
                izmenaPravnog.TxtPIB.Text = p.PIB.ToString();
                izmenaPravnog.TxtDatumOsnivanja.Text = p.DatumOsnivanja.ToString();
                pravno = p;
                System.Windows.Forms.MessageBox.Show("Sistem je ucitao korisnika pravno lice.");
           
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
           
                Common.Domain.FizickoLice fiz = new Common.Domain.FizickoLice();
                if (!Validacije.Helper.PraznoPoljeValidacija(izmenaPravnog.TxtIme) |
                    !Validacije.Helper.PraznoPoljeValidacija(izmenaPravnog.TxtPrezime) |
                    !Validacije.Helper.PraznoPoljeValidacija(izmenaPravnog.TxtJMBG))
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti pravno lice.");
                    return;
                }

                if (!Validacije.Helper.DoubleValidacija(izmenaPravnog.TxtMesecnaZarada) |
                    !Validacije.Helper.IntValidacija(izmenaPravnog.TxtPIB))
                {
                    return;
                }

                if (!Validacije.Helper.ValidacijaDatuma(izmenaPravnog.TxtDatumOsnivanja))
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti pravno lice.");
                    return;
                }
                if (!Validacije.Helper.JMBGValidacija(izmenaPravnog.TxtJMBG))
                {

                    MessageBox.Show("Sistem ne moze da zapamti korisnika fizicko lice.  ");
                    return;
                }
                PravnoLice p = new PravnoLice();
                p.Korisnik = new Common.Domain.Korisnik();
                p.Korisnik.KorisnikID = pravno.Korisnik.KorisnikID;
                p.Condition = $"KorisnikID={pravno.Korisnik.KorisnikID}";
                p.Korisnik.ImeKorisnika = izmenaPravnog.TxtIme.Text;
                p.Korisnik.PrezimeKorisnika = izmenaPravnog.TxtPrezime.Text;
                p.Korisnik.JMBG = izmenaPravnog.TxtJMBG.Text;
                p.Korisnik.Bankar = new Bankar();
                p.Korisnik.Bankar = Session.SessionData.Instance.Bankar;
                p.PIB = int.Parse(izmenaPravnog.TxtPIB.Text);
                p.MesecnaZarada = double.Parse(izmenaPravnog.TxtMesecnaZarada.Text);
                p.DatumOsnivanja = DateTime.Parse(izmenaPravnog.TxtDatumOsnivanja.Text);
                Communication.Instance.SendRequestNoResult(Common.Communication.Operation.ZapamtiPravnoLice, p);
                System.Windows.Forms.MessageBox.Show("Sistem je uspesno zapamtio pravno lice.");
           
        }
    }
}
