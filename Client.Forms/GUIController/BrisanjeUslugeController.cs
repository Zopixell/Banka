using Client.Forms.Usluga;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class BrisanjeUslugeController
    {
        UCBrisanjeUsluge ucbrisanjeU;
        Common.Domain.Usluga usluga;
        public BrisanjeUslugeController(UCBrisanjeUsluge ucbrisanjeU)
        {
            this.ucbrisanjeU = ucbrisanjeU;

        }
        internal void Init()
        {
            List<Common.Domain.Usluga> lista = new List<Common.Domain.Usluga>();
            lista = ServerCommunication.Communication.Instance.SendRequestGetResult<List<Common.Domain.Usluga>>(Common.Communication.Operation.VratiSveUsluge);
            ucbrisanjeU.DgvUgovor.DataSource = lista;
            ucbrisanjeU.BtnPronadji.Click += btnPronadji_Click;
            ucbrisanjeU.BtnUcitaj.Click += btnUcitaj_Click;
            ucbrisanjeU.BtnObrisi.Click += btnObrisi_Click;

        }
        public void btnPronadji_Click(object sender, EventArgs e)
        {
            Common.Domain.Usluga u = new Common.Domain.Usluga();
            string naziv = ucbrisanjeU.TxtKriterijum.Text;

            
            u.Condition = $" NazivUsluge LIKE '{naziv}%'";
            if (!Validacije.Helper.PraznoPoljeValidacija(ucbrisanjeU.TxtKriterijum))
            {
                ucbrisanjeU.LblPretraga.Text = "Unesite deo imena ili ime";
                ucbrisanjeU.LblPretraga.BackColor = Color.Red;

                return;
            }
            
            List<Common.Domain.Usluga> l = new List<Common.Domain.Usluga>();
            l = ServerCommunication.Communication.Instance.SendRequestGetResult<List<Common.Domain.Usluga>>(Common.Communication.Operation.PronadjiUsluge,u);
            if (l.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje bankarske usluge po zadatoj vrednosti. ");
                return;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem je pronasao bankarske usluge po zadatoj vrednosti.");
            }
            ucbrisanjeU.DgvUgovor.DataSource = l;
        }
        public void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (ucbrisanjeU.DgvUgovor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita bankarsku uslugu.");
                return;
            }
            Common.Domain.Usluga u = new Common.Domain.Usluga();
            u = (Common.Domain.Usluga)ucbrisanjeU.DgvUgovor.CurrentRow.DataBoundItem;
            u.Condition = $"UslugaID={u.UslugaID}";
            u= ServerCommunication.Communication.Instance.SendRequestGetResult<Common.Domain.Usluga>(Common.Communication.Operation.UcitajUslugu, u);
            ucbrisanjeU.TxtNaziv.Text = u.NazivUsluge;
            ucbrisanjeU.TxtMinimalniIznos.Text = u.MinimalniIznos.ToString();
            ucbrisanjeU.TxtMaksimalniIznos.Text = u.MaksimalniIznos.ToString();
            ucbrisanjeU.TxtKamatnaStopa.Text = u.KamatnaStopa.ToString();
            usluga = u;
            System.Windows.Forms.MessageBox.Show("Sistem je ucitao bankarsku uslugu.");

        }
        public void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                Common.Domain.Usluga u = new Common.Domain.Usluga();
                if (ucbrisanjeU.TxtMinimalniIznos.Text == "")
                {
                    MessageBox.Show("Sistem ne moze da obrise bankarsku uslugu.");
                    return;

                }
                u.Condition = $" UslugaID = {usluga.UslugaID}";
                
                ServerCommunication.Communication.Instance.SendRequestNoResult(Common.Communication.Operation.ObrisiUslugu, u);
                System.Windows.Forms.MessageBox.Show("Sistem je obrisao bankarsku uslugu.");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da obrise bankarsku uslugu.");
            }
        }
    }
}
