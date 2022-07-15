using Client.Forms.Korisnik;
using Client.Forms.ServerCommunication;
using Common.Domain;
using Server.ApplicationLogic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class IzmenaFizickogLicaController
    {
        UCIzmenaFizickoLice izmenaFiz;
        FizickoLice fizicko;

        public IzmenaFizickogLicaController(UCIzmenaFizickoLice izmenaFiz)
        {
            this.izmenaFiz = izmenaFiz;
            
        }


        internal void Init()
        {
            
            List<FizickoLice> lista = new List<FizickoLice>();
            lista=Communication.Instance.SendRequestGetResult<List<FizickoLice>>(Common.Communication.Operation.VratiFizickaLica);
            izmenaFiz.DgvKorisnici.DataSource = lista;
            izmenaFiz.BtnPretrazi.Click += btnPretrazi_Click;
            izmenaFiz.BtnUcitaj.Click += btnUcitaj_Click;
            izmenaFiz.BtnIzmeni.Click += btnIzmeni_Click;
        }


        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            FizickoLice f = new FizickoLice();
            if (!Validacije.Helper.PraznoPoljeValidacija(izmenaFiz.TxtAtribut))
            {
                izmenaFiz.Label4.Text = "Unesite deo imena ili ime";
                izmenaFiz.Label4.BackColor = Color.Red;

                return;
            }
         
            string ime = izmenaFiz.TxtAtribut.Text;
            f.Condition = $"K.ImeKorisnika LIKE '{ime}%'";
            List<FizickoLice> lista = new List<FizickoLice>();

            lista = Communication.Instance.SendRequestGetResult<List<FizickoLice>>(Common.Communication.Operation.PronadjiFizickaLica, f);
            izmenaFiz.DgvKorisnici.DataSource = lista;

            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje korisnike fizicka lica po zadatoj vrednosti");
                return;
            }
            else
            {
            MessageBox.Show("Sistem je pronasao korisnike fizicka lica po zadatoj vrednosti");

            }


           
        }
        public void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (izmenaFiz.DgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita korisnika fizicko lice po zadatoj vrednosti");
                return;
            }
            FizickoLice f = new FizickoLice();
            f = (FizickoLice)izmenaFiz.DgvKorisnici.CurrentRow.DataBoundItem;
            f.Condition = $"K.KorisnikID={f.Korisnik.KorisnikID}";
            f = Communication.Instance.SendRequestGetResult<FizickoLice>(Common.Communication.Operation.VratiFizickoLice, f);
            izmenaFiz.TxtIme.Text = f.Korisnik.ImeKorisnika;
            izmenaFiz.TxtPrezime.Text = f.Korisnik.PrezimeKorisnika;
            izmenaFiz.TxtJMBG.Text = f.Korisnik.JMBG;
            izmenaFiz.TxtDuzinaZaposlenja.Text = f.DuzinaZaposlenja.ToString();
            izmenaFiz.TxtVIsinaPlate.Text = f.VisinaPlate.ToString();
            fizicko = f;
            MessageBox.Show("Sistem je ucitao korisnika fizicko lice");
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                Common.Domain.FizickoLice fiz = new Common.Domain.FizickoLice();
                if (!Validacije.Helper.PraznoPoljeValidacija(izmenaFiz.TxtIme) |
                    !Validacije.Helper.PraznoPoljeValidacija(izmenaFiz.TxtPrezime) |
                    !Validacije.Helper.PraznoPoljeValidacija(izmenaFiz.TxtJMBG))
                {

                    MessageBox.Show("Sistem ne moze da zapamti korisnika fizicko lice.  ");
                    return;
                }

                if (!Validacije.Helper.IntValidacija(izmenaFiz.TxtVIsinaPlate) |
                    !Validacije.Helper.IntValidacija(izmenaFiz.TxtDuzinaZaposlenja))
                {

                    MessageBox.Show("Sistem ne moze da zapamti korisnika fizicko lice.  ");
                    return;
                }
                if (!Validacije.Helper.JMBGValidacija(izmenaFiz.TxtJMBG))
                {

                    MessageBox.Show("Sistem ne moze da zapamti korisnika fizicko lice.  ");
                    return;
                }
                FizickoLice f = new FizickoLice();
                f.Korisnik = new Common.Domain.Korisnik();
                f.Korisnik.KorisnikID = fizicko.Korisnik.KorisnikID;
                f.Condition = $"KorisnikID={fizicko.Korisnik.KorisnikID}";
                f.Korisnik.ImeKorisnika = izmenaFiz.TxtIme.Text;
                f.Korisnik.PrezimeKorisnika = izmenaFiz.TxtPrezime.Text;
                f.Korisnik.JMBG = izmenaFiz.TxtJMBG.Text;
                f.DuzinaZaposlenja = int.Parse(izmenaFiz.TxtDuzinaZaposlenja.Text);
                f.VisinaPlate = double.Parse(izmenaFiz.TxtVIsinaPlate.Text);
                f.Korisnik.Bankar = new Bankar();
                f.Korisnik.Bankar = Session.SessionData.Instance.Bankar;
                Communication.Instance.SendRequestNoResult(Common.Communication.Operation.ZapamtiFizickoLice, f);
                MessageBox.Show("Sistem je zapamtio korisnika fizicko lice");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da zapamti korisnika fizicko lice. ");
            }

        }

        #region

        //private void btnDodaj_Click(object sender, EventArgs e)
        //{

        //    Common.Domain.Korisnik kor = new Common.Domain.Korisnik();
        //    kor.ImeKorisnika = unosKorisnika.TxtIme.Text;
        //    kor.PrezimeKorisnika = unosKorisnika.TxtPrezime.Text;
        //    kor.JMBG = unosKorisnika.TxtJMBG.Text;
        //    kor.Bankar = Session.SessionData.Instance.Bankar;
        //}
        //private void btnFizicko_Click(object sender, EventArgs e)
        //{
        //    Common.Domain.FizickoLice fiz = new Common.Domain.FizickoLice();
        //    fiz.VisinaPlate = double.Parse(unosFizickog.TxtVIsinaPlate.Text);
        //    fiz.DuzinaZaposlenja = int.Parse(unosFizickog.TxtDuzinaZaposlenja.Text);
        //}
        //private void btnPravno_Click(object sender, EventArgs e)
        //{
        //    Common.Domain.PravnoLice pravno = new Common.Domain.PravnoLice();
        //    pravno.MesecnaZarada = double.Parse(unosPravnog.TxtMesecnaZarada.Text);
        //    pravno.PIB = int.Parse(unosPravnog.TxtPIB.Text);
        //    pravno.DatumOsnivanja = DateTime.ParseExact(unosPravnog.TxtDatumOsnivanja.Text, "dd.MM.yyyy", null);
        //}
        #endregion
    }
}
