using Client.Forms.Ugovor;
using Server.ApplicationLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
namespace Client.Forms.GUIController
{
    public class UgovorController
    {
        UCUgovor unosUgovora;
        double iznosGLobalni = 0;
        int brojMeseci = 12;
        int delilac = 100;
        public UgovorController(UCUgovor unosUgovora)
        {
            this.unosUgovora = unosUgovora;
        }
        internal void Init()
        {

            unosUgovora.BtnDodaj.Click += btnDodaj_Click;
            unosUgovora.CbUsluga.DataSource = Controller.Instance.VratiSveUsluge();
            unosUgovora.CbKorisnik.DataSource = Controller.Instance.VratiSveKorisnike();
            unosUgovora.CbUsluga.SelectedIndexChanged += Popuni_KamatnuStopu;
            //unosUgovora.TxtGodine.TextChanged += Popuni_Iznos_Usluge;
            //unosUgovora.TxtUkupanIznos.TextChanged += Popuni_Iznos_Usluge;

        }
    //    private void Popuni_Iznos_Usluge(object sender, EventArgs e)
    //    {


    //        try
    //        {
                
    //            if(!string.IsNullOrEmpty(unosUgovora.TxtGodine.Text) && !string.IsNullOrEmpty(unosUgovora.TxtUkupanIznos.Text))
    //            {
                    
    //                double iznos = double.Parse(unosUgovora.TxtUkupanIznos.Text);
    //                double kamata = double.Parse(unosUgovora.TxtKamatnaStopa.Text) ;
    //                int periodOtplate = int.Parse(unosUgovora.TxtGodine.Text) ;
    //                //kamata = Convert.ToDouble((kamata / 100));
    //                //periodOtplate = Convert.ToInt32(periodOtplate * 12);
    //                double rata = (iznos / periodOtplate); 
    //                double kamataDin = rata * kamata;
    //                double rataSaKamatom =rata + kamataDin;
    //                iznosGLobalni = rataSaKamatom;
    //                double rataispis =( rataSaKamatom);
    //                unosUgovora.TxtIznosUsluge.Text = rataispis.ToString();
    //            }
    //            else
    //            {
    //                unosUgovora.TxtIznosUsluge.Text = "0";
    //            }
               

    //}
    //        catch (Exception)
    //        {

    //            unosUgovora.TxtIznosUsluge.Text = "0";
    //        }
    //    }
        private void Popuni_KamatnuStopu(object sender, EventArgs e)
        {



            Common.Domain.Usluga uslu = (Common.Domain.Usluga)unosUgovora.CbUsluga.SelectedItem;
            unosUgovora.TxtKamatnaStopa.Text = uslu.KamatnaStopa.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Common.Domain.Ugovor ugovor = new Common.Domain.Ugovor();
                ugovor.DatumKreiranja = DateTime.ParseExact(unosUgovora.TxtDatumKreiranja.Text, "dd.MM.yyyy", null);
                ugovor.Bankar = Session.SessionData.Instance.Bankar;
                ugovor.Status = new StatusUgovora();
                ugovor.Status.Id = 1;

                ugovor.Korisnik = (Common.Domain.Korisnik)unosUgovora.CbKorisnik.SelectedItem;
                ugovor.Usluga = (Common.Domain.Usluga)unosUgovora.CbUsluga.SelectedItem;
                if (!unosUgovora.CheckPotpisBankara.Checked)
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti ugovor");
                    return;

                }

                if (!unosUgovora.CheckPotpisKorisnika.Checked)
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti ugovor-potpis");
                    return;

                }

                ugovor.PotpisBankara = true;
                ugovor.PotpisKorisnika = true;
                ugovor.ListaStavki = new System.ComponentModel.BindingList<Stavka>();
                Stavka s = new Stavka();
                s.Usluga = ugovor.Usluga;
                s.Ugovor = ugovor;
                s.RedniBroj = ugovor.ListaStavki.Count() + 1;
                s.KamatnaStopa = Convert.ToDouble(unosUgovora.TxtKamatnaStopa.Text);
                s.IznosUsluge = Convert.ToDouble(unosUgovora.TxtIznosUsluge.Text);
                //s.IznosUsluge = iznosGLobalni;

                ugovor.ListaStavki.Add(s);
                if (ugovor.ListaStavki.Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Ugovor mora sadrzati bar jednu stavku.");
                    return;
                }
                ServerCommunication.Communication.Instance.SendRequestNoResult(Common.Communication.Operation.KreirajUgovor, ugovor);
                System.Windows.Forms.MessageBox.Show("Sistem je zapamtio ugovor.");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Sistem ne moze da zapamti ugovor");
            }
            //dodaj
        }
    }
}
