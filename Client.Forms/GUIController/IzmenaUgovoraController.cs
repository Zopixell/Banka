using Client.Forms.Ugovor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class IzmenaUgovoraController
    {
        UCIzmeniUgovor izmeniUgovor;
        List<Common.Domain.Ugovor> listaGl = new List<Common.Domain.Ugovor>();
        BindingList<Stavka> listaStavki = new BindingList<Stavka>();
        Stavka stavka = new Stavka();
        Common.Domain.Ugovor ug = new Common.Domain.Ugovor();

        double iznosGLobalni = 0;
       
        public IzmenaUgovoraController(UCIzmeniUgovor izmeniUgovor)
        {
            this.izmeniUgovor = izmeniUgovor;
        }
        internal void Init()
        {
            izmeniUgovor.BtnPronadji.Click += Pronadji_Click;
            izmeniUgovor.BtnIzmeni.Click += Izmeni_Click;
            izmeniUgovor.CbUsluga.DataSource=ServerCommunication.Communication.Instance.SendRequestGetResult<List<Common.Domain.Usluga>>(Common.Communication.Operation.VratiSveUsluge);
            izmeniUgovor.BtnUcitajUgovor.Click+=UcitajUgovor_Click;
            izmeniUgovor.BtnUcitajStavku.Click += UcitajStavku_Click;
            izmeniUgovor.BtnIzmeniStavku.Click += IzmeniStavku_Click;
            izmeniUgovor.CbUsluga.SelectedIndexChanged += Popuni_Kamatu;

            //izmeniUgovor.TxtIznosUsluge.Click += Unesi_Iznos_Usluge;
            //izmeniUgovor.TxtPeriodOtplate.Click += Unesi_Iznos_Usluge;
            //izmeniUgovor.TxtIznosUsluge.Click += Unesi_Iznos_Usluge;
        }

        private void Popuni_Kamatu(object sender, EventArgs e)
        {
            Common.Domain.Usluga uslu = (Common.Domain.Usluga)izmeniUgovor.CbUsluga.SelectedItem;
            izmeniUgovor.TxtKamatnaStopa.Text = uslu.KamatnaStopa.ToString();
        }

        //private void Unesi_Iznos_Usluge(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        if (!string.IsNullOrEmpty(izmeniUgovor.TxtPeriodOtplate.Text) && !string.IsNullOrEmpty(izmeniUgovor.TxtUkIznos.Text))
        //        {

        //            double iznos = double.Parse(izmeniUgovor.TxtUkIznos.Text);
        //            double kamata = double.Parse(izmeniUgovor.TxtKamatnaStopa.Text);
        //            int periodOtplate = int.Parse(izmeniUgovor.TxtPeriodOtplate.Text);
        //            kamata = Convert.ToDouble((kamata / 100));
        //            periodOtplate = Convert.ToInt32(periodOtplate * 12);
        //            double rata = (iznos / periodOtplate);
        //            double kamataDin = Convert.ToDouble((rata * kamata));
        //            double rataSaKamatom = Convert.ToDouble((rata + kamataDin));
        //            iznosGLobalni = rataSaKamatom;
        //            double rataispis = (rataSaKamatom);
        //            izmeniUgovor.TxtIznosUsluge.Text = rataispis.ToString();
        //        }
        //        else
        //        {
        //            izmeniUgovor.TxtIznosUsluge.Text = "0";
        //        }


        //    }
        //    catch (Exception)
        //    {

        //        izmeniUgovor.TxtIznosUsluge.Text = "0";
        //    }

        //    //try
        //    //{
        //    //    double iznos = double.Parse(izmeniUgovor.TxtUkIznos.Text);
        //    //    double kamata = double.Parse(izmeniUgovor.TxtKamatnaStopa.Text) / 100;
        //    //    int periodGod = int.Parse(izmeniUgovor.TxtPeriodOtplate.Text);
        //    //    int periodMesec = periodGod * 12;
        //    //    double rata = (iznos / periodMesec);
        //    //    double kamataDin = rata * kamata;
        //    //    double rataSaKamatom = rata + kamataDin;
        //    //    izmeniUgovor.TxtIznosUsluge.Text = rataSaKamatom.ToString();
        //    //}
        //    //catch (Exception)
        //    //{

        //    //    izmeniUgovor.TxtIznosUsluge.Text = "0";
        //    //}
        //}

        private void IzmeniStavku_Click(object sender, EventArgs e)
        {
            Stavka s = new Stavka();
            if (izmeniUgovor.DgvStavke.SelectedRows.Count == 0)
            {
                return;

            }
            stavka = (Stavka)izmeniUgovor.DgvStavke.CurrentRow.DataBoundItem;
            if (izmeniUgovor.TxtIznosUsluge.Text == "")
            {
                MessageBox.Show("Sistem ne moze da izmeni stavku.");
                return;
            }
             s.KamatnaStopa = Convert.ToDouble(izmeniUgovor.TxtKamatnaStopa.Text);

            s.IznosUsluge = Convert.ToDouble(izmeniUgovor.TxtIznosUsluge.Text);


            s.Usluga = stavka.Usluga;
            s.Ugovor = stavka.Ugovor;
            s.RedniBroj = stavka.RedniBroj;
            listaStavki.Add(s);
            listaStavki.Remove(stavka);
            
        }

        private void UcitajStavku_Click(object sender, EventArgs e)
        {
           
            if (izmeniUgovor.DgvStavke.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da ucita ugovor.");
                return;
            }
            if (izmeniUgovor.DgvUgovor.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da ucita ugovor.");
                return;
            }
            stavka = (Stavka)izmeniUgovor.DgvStavke.CurrentRow.DataBoundItem;

            izmeniUgovor.TxtKamatnaStopa.Text = stavka.KamatnaStopa.ToString();
            izmeniUgovor.TxtIznosUsluge.Text = stavka.IznosUsluge.ToString();
        }

        private void UcitajUgovor_Click(object sender, EventArgs e)
        {
            Common.Domain.Ugovor u = new Common.Domain.Ugovor();
            Common.Domain.Ugovor ugovor = new Common.Domain.Ugovor();
            if (izmeniUgovor.DgvUgovor.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da ucita ugovor.");
                return;
            }
            ugovor = (Common.Domain.Ugovor) izmeniUgovor.DgvUgovor.CurrentRow.DataBoundItem;
            u.Condition = $" ug.UgovorID= {ugovor.Id}";
            u = ServerCommunication.Communication.Instance.SendRequestGetResult<Common.Domain.Ugovor>(Common.Communication.Operation.UcitajUgovor, u);
            izmeniUgovor.TxtKorisnik.Text = u.Korisnik.ToString();
            izmeniUgovor.CbUsluga.SelectedItem = u.Usluga;
            izmeniUgovor.TxtDatumKreiranja.Text = u.DatumKreiranja.ToString("dd.MM.yyyy");
            listaStavki = u.ListaStavki;
            izmeniUgovor.DgvStavke.DataSource = listaStavki;
            MessageBox.Show("Sistem je ucitao ugovor.");
            //izmeniUgovor.TxtPeriodOtplate.Text= ugovor.Id.ToString();
            ug = u;

        }

        private void Izmeni_Click(object sender, EventArgs e)
        {
            
            Common.Domain.Ugovor ugovor = new Common.Domain.Ugovor();
            //int id = Convert.ToInt32(izmeniUgovor.TxtPeriodOtplate.Text);
            ugovor.Condition = $" UgovorID = {ug.Id } ";
          
            if (izmeniUgovor.TxtDatumKreiranja.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti ugovor.");
                return;
            }
            ugovor.DatumKreiranja = DateTime.ParseExact(izmeniUgovor.TxtDatumKreiranja.Text, "dd.MM.yyyy", null);
            if (!izmeniUgovor.CheckPotpisBankara.Checked || !izmeniUgovor.CheckPotpisKorisnika.Checked)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti ugovor.");
                return;
            }
            if(izmeniUgovor.TxtIznosUsluge.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti ugovor.");
                return;
            }
           
            ugovor.PotpisKorisnika = true;
            ugovor.PotpisKorisnika = true;
            ugovor.Bankar = new Bankar();
            ugovor.Bankar = Session.SessionData.Instance.Bankar;
            ugovor.Status = new StatusUgovora();
            ugovor.Status.Id = 2;
            ugovor.Korisnik = new Common.Domain.Korisnik();
            ugovor.Korisnik = ug.Korisnik;
            ugovor.Usluga = new Common.Domain.Usluga();
            ugovor.Usluga = (Common.Domain.Usluga)izmeniUgovor.CbUsluga.SelectedItem;
          
            ugovor.ListaStavki = listaStavki;
            ServerCommunication.Communication.Instance.SendRequestNoResult(Common.Communication.Operation.ZapamtiUgovor, ugovor);
                System.Windows.Forms.MessageBox.Show("Sistem je zapamtio ugovor");
         }
          

        

        private void Pronadji_Click(object sender, EventArgs e)
        {
            Common.Domain.Ugovor ugovor = new Common.Domain.Ugovor();
            if (!Validacije.Helper.PraznoPoljeValidacija(izmeniUgovor.TxtKriterijum))
            {
                izmeniUgovor.LblPretraga.Text = "Unesite jmbg ili deo jmbga";
                izmeniUgovor.LblPretraga.BackColor = Color.Red;

                return;
            }
            String jmbg = izmeniUgovor.TxtKriterijum.Text;
            ugovor.Condition = $" k.JMBG like '{ jmbg }%'";
            List<Common.Domain.Ugovor> lista = new List<Common.Domain.Ugovor>();
            lista = ServerCommunication.Communication.Instance.SendRequestGetResult<List<Common.Domain.Ugovor>>(Common.Communication.Operation.PronadjiUgovor, ugovor);
            izmeniUgovor.DgvUgovor.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da nadje ugovor.");
                return;
            }
            else
            {
                MessageBox.Show("Sistem je nasao ugovore po zadatoj vrednosti.");

            }

        }
    }
}
