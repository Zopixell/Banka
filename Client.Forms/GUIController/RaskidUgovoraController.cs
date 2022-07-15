using Client.Forms.Ugovor;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class RaskidUgovoraController
    {

        UCRaskidanjeUgovora raskidanjeUgovora;
        List<Common.Domain.Ugovor> listaGl = new List<Common.Domain.Ugovor>();
        BindingList<Stavka> listaStavki = new BindingList<Stavka>();
        Stavka stavka = new Stavka();
        Common.Domain.Ugovor ug = new Common.Domain.Ugovor();
        public RaskidUgovoraController(UCRaskidanjeUgovora raskidanjeUgovora)
        {
            this.raskidanjeUgovora = raskidanjeUgovora;
        }
        public void Init()
        {

            raskidanjeUgovora.BtnPronadji.Click += Pronadji_Ugovore_Click;
            raskidanjeUgovora.BtnRaskini.Click += RaskiniUgovore_Click;
            raskidanjeUgovora.CbUsluga.DataSource = ServerCommunication.Communication.Instance.SendRequestGetResult<List<Common.Domain.Usluga>>(Common.Communication.Operation.VratiSveUsluge);
            raskidanjeUgovora.BtnUcitajUgovor.Click += UcitajUgovor_Click;
        }

        private void UcitajUgovor_Click(object sender, EventArgs e)
        {
            if (raskidanjeUgovora.DgvUgovor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita ugovor.");
                return;
            }
            Common.Domain.Ugovor u = new Common.Domain.Ugovor();
            Common.Domain.Ugovor ugovor = new Common.Domain.Ugovor();
            ugovor = (Common.Domain.Ugovor)raskidanjeUgovora.DgvUgovor.CurrentRow.DataBoundItem;
            u.Condition = $" ug.UgovorID= {ugovor.Id}";
            u = ServerCommunication.Communication.Instance.SendRequestGetResult<Common.Domain.Ugovor>(Common.Communication.Operation.UcitajUgovor, u);
            raskidanjeUgovora.TxtKorisnik.Text = u.Korisnik.ToString();
            raskidanjeUgovora.CbUsluga.SelectedItem = u.Usluga;
            raskidanjeUgovora.TxtDatumKreiranja.Text = u.DatumKreiranja.ToString("dd.MM.yyyy");
            raskidanjeUgovora.TxtBankar.Text = u.Bankar.ToString();
            //  listaStavki = u.ListaStavki;
            MessageBox.Show("Sistem je ucitao ugovor.");
            ug = u;
        }

        private void RaskiniUgovore_Click(object sender, EventArgs e)
        {
            Common.Domain.Ugovor u = new Common.Domain.Ugovor();
            try
            {
                u = ug;
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Sistem ne moze da raskine ugovor.");
            }

            u.Status = new StatusUgovora();
            u.Status.Id = 3;
            u.Condition = $" UgovorID={u.Id}";
            ServerCommunication.Communication.Instance.SendRequestNoResult(Common.Communication.Operation.RaskidUgovora, u);
            if (raskidanjeUgovora.TxtKorisnik.Text =="")
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da raskine ugovor.");
                return;
            }
            else
            {
            System.Windows.Forms.MessageBox.Show("Sistem je raskinuo ugovor");

            }
        }

        private void Pronadji_Ugovore_Click(object sender, EventArgs e)
        {
            Common.Domain.Ugovor ugovor = new Common.Domain.Ugovor();
            if (!Validacije.Helper.PraznoPoljeValidacija(raskidanjeUgovora.TxtKriterijum))
            {
                raskidanjeUgovora.LblPretraga.Text = "Unesite jmbg ili deo jmbga";
                raskidanjeUgovora.LblPretraga.BackColor = Color.Red;

                return;
            }


            String jmbg = raskidanjeUgovora.TxtKriterijum.Text;
            ugovor.Condition = $" k.JMBG like '{ jmbg }%'";
            List<Common.Domain.Ugovor> lista = new List<Common.Domain.Ugovor>();
            lista = ServerCommunication.Communication.Instance.SendRequestGetResult<List<Common.Domain.Ugovor>>(Common.Communication.Operation.PronadjiUgovor, ugovor);
            raskidanjeUgovora.DgvUgovor.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje ugovor.");
                return;
            }
            else
            {
                MessageBox.Show("Sistem je nasao ugovore po zadatoj vrednosti.");

            }
           
        }
    }
}
