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
    public class BrisanjePravnogLicaController
    {
        UCKorisnikPravnoLicePretraga pravnoPretraga;
        PravnoLice pravno = new PravnoLice();
        public BrisanjePravnogLicaController(UCKorisnikPravnoLicePretraga pravnoPretraga)
        {
            this.pravnoPretraga = pravnoPretraga;
        }
        internal void Init()
        {
            List<PravnoLice> lista = new List<PravnoLice>();
            lista = Communication.Instance.SendRequestGetResult<List<PravnoLice>>(Common.Communication.Operation.VratiPravnaLica);
            pravnoPretraga.DgvKorisnici.DataSource = lista;
           // pravnoPretraga.DgvKorisnici.DataSource = Communication.Instance.SendRequestGetResult < PravnoLice > (Common.Communication.Operation.VratiPravnaLica);
            pravnoPretraga.BtnPretrazi.Click += btnPretrazi_Click;
            pravnoPretraga.BtnUcitaj.Click += btnUcitaj_Click;
            pravnoPretraga.BtnObrisi.Click += btnObrisi_Click;
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {

            PravnoLice p = new PravnoLice();
            string ime = pravnoPretraga.TxtAtribut.Text;
            if (!Validacije.Helper.PraznoPoljeValidacija(pravnoPretraga.TxtAtribut))
            {
                pravnoPretraga.LblPretraga.Text = "Unesite deo imena ili ime";
                pravnoPretraga.LblPretraga.BackColor = Color.Red;

                return;
            }

            p.Condition = $"K.ImeKorisnika LIKE '{ime}%'";
            List<PravnoLice> lista = new List<PravnoLice>();
            lista = Communication.Instance.SendRequestGetResult<List<PravnoLice>>(Common.Communication.Operation.PronadjiPravnaLica, p);

            
            pravnoPretraga.DgvKorisnici.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje korisnika pravno lice po zadatoj vrednosti.");
                return;
            }
            else
            {
                MessageBox.Show("Sistem je pronasao korisnike pravna lica po zadatoj vrednosti");


            }
        }
        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (pravnoPretraga.DgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita korisnika pravno lice po zadatoj vrednosti");
                return;
            }
            PravnoLice p = new PravnoLice();
            p = (PravnoLice)pravnoPretraga.DgvKorisnici.CurrentRow.DataBoundItem;
            p.Condition = $"K.KorisnikID={p.Korisnik.KorisnikID}";
            p = Communication.Instance.SendRequestGetResult<PravnoLice>(Common.Communication.Operation.VratiPravnoLice, p);
            pravnoPretraga.TxtIme.Text = p.Korisnik.ImeKorisnika.ToString();
            pravnoPretraga.TxtPrezime.Text = p.Korisnik.PrezimeKorisnika.ToString();
            pravnoPretraga.TxtJMBG.Text = p.Korisnik.JMBG.ToString();
            pravnoPretraga.TxtMesecnaZarada.Text = p.MesecnaZarada.ToString();
            pravnoPretraga.TxtPIB.Text = p.PIB.ToString();
            pravnoPretraga.TxtDatumOsnivanja.Text = p.DatumOsnivanja.ToString();
            MessageBox.Show("Sistem je ucitao korisnika pravno lice");
            pravno = p;
          
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {


            try
            {
                
                String jmbg = pravnoPretraga.TxtJMBG.Text;
                
                pravno.Condition = $"JMBG like '{jmbg}' ";
                #region
                //p.Korisnik.ImeKorisnika = pravnoPretraga.TxtIme.Text;
                //p.Korisnik.PrezimeKorisnika = pravnoPretraga.TxtPrezime.Text;
                //p.Korisnik.JMBG = pravnoPretraga.TxtJMBG.Text;
                //p.MesecnaZarada = double.Parse(pravnoPretraga.TxtMesecnaZarada.Text);
                //p.PIB = int.Parse(pravnoPretraga.TxtMesecnaZarada.Text);
                //p.DatumOsnivanja = DateTime.Parse(pravnoPretraga.TxtDatumOsnivanja.Text);
                #endregion
                Communication.Instance.SendRequestNoResult(Common.Communication.Operation.ObrisiPravnoLice, pravno);
                if (pravnoPretraga.TxtJMBG.Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da obrise korisnika pravno lice ");
                    return;
                }
                
                System.Windows.Forms.MessageBox.Show("Sistem je obrisao korisnika pravno lice");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Sistem ne moze da obrise korisnika pravno lice ");
            }
           
        }

    }
}
