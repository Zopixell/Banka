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
    public class BrisanjeFizickogLicaController
    {
        UCKorisnikPretraga pretragaFiz;
        FizickoLice fizicko = new FizickoLice();
        internal void Init()
        {
            List<FizickoLice> lista = new List<FizickoLice>();
            lista = Communication.Instance.SendRequestGetResult<List<FizickoLice>>(Common.Communication.Operation.VratiFizickaLica);
            pretragaFiz.DgvKorisnici.DataSource = lista;
            pretragaFiz.BtnPretrazi.Click += btnPretrazi_Click;
            pretragaFiz.BtnUcitaj.Click += btnUcitaj_Click;
            pretragaFiz.BtnObrisi.Click += btnObrisi_Click;
        }
        public BrisanjeFizickogLicaController(UCKorisnikPretraga pretragaFiz)
        {
            this.pretragaFiz = pretragaFiz;

        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {

            FizickoLice f = new FizickoLice();
            string ime = pretragaFiz.TxtAtribut.Text;
            if (!Validacije.Helper.PraznoPoljeValidacija(pretragaFiz.TxtAtribut))
            {
                pretragaFiz.LblPretraga.Text = "Unesite deo imena ili ime";
                pretragaFiz.LblPretraga.BackColor = Color.Red;
                
                return;
            }
            
            f.Condition = $"K.ImeKorisnika LIKE '{ime}%'";
            List<FizickoLice> lista = new List<FizickoLice>();
            lista = Communication.Instance.SendRequestGetResult<List<FizickoLice>>(Common.Communication.Operation.PronadjiFizickaLica, f);
            
            pretragaFiz.DgvKorisnici.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje korisnike fizicka lica.");
                return;
            }
            else
            {
                MessageBox.Show("Sistem je pronasao korisnike fizicka lica po zadatoj vrednosti");
            }
        }
     
        public void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (pretragaFiz.DgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita korisnika fizicko lice");
                return;
            }
            FizickoLice f = new FizickoLice();
            f = (FizickoLice)pretragaFiz.DgvKorisnici.CurrentRow.DataBoundItem;
            f.Condition = $"K.KorisnikID={f.Korisnik.KorisnikID}";
            f = Communication.Instance.SendRequestGetResult<FizickoLice>(Common.Communication.Operation.VratiFizickoLice, f);
            pretragaFiz.TxtIme.Text = f.Korisnik.ImeKorisnika;
            pretragaFiz.TxtPrezime.Text = f.Korisnik.PrezimeKorisnika;
            pretragaFiz.TxtJMBG.Text = f.Korisnik.JMBG;
            pretragaFiz.TxtDuzinaZaposlenja.Text = f.DuzinaZaposlenja.ToString();
            pretragaFiz.TxtVIsinaPlate.Text = f.VisinaPlate.ToString();
            MessageBox.Show("Sistem je ucitao korisnika fizicko lice");
            fizicko = f;

        }

        public void btnObrisi_Click(object sender, EventArgs e)
        {

            try
            {
                FizickoLice f = new FizickoLice();
                string jmbg = pretragaFiz.TxtJMBG.Text;

                f.Condition = $"JMBG like '{jmbg}' ";

                //f = (FizickoLice)pretragaFiz.DgvKorisnici.CurrentRow.DataBoundItem;
                //f.Condition = $"K.KorisnikID={f.Korisnik.KorisnikID}";
                Communication.Instance.SendRequestNoResult(Common.Communication.Operation.ObrisiFizickoLice, f);
                if (pretragaFiz.TxtJMBG.Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da obrise korisnika fizicko lice ");
                    return;
                }
                System.Windows.Forms.MessageBox.Show("Sistem je obrisao korisnika fizicko lice");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Sistem ne moze da obrise korisnika fizicko lice ");
            }
        }
    }
}
