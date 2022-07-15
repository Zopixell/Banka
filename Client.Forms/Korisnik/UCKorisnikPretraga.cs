using Client.Forms.GUIController;
using Client.Forms.ServerCommunication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.Korisnik
{
    public partial class UCKorisnikPretraga : UserControl
    {
        BrisanjeFizickogLicaController controller;
        public UCKorisnikPretraga()
        {
            InitializeComponent();
            controller = new BrisanjeFizickogLicaController(this);
            controller.Init();
        
           
        }
        #region
        //private void btnPretrazi_Click(object sender, EventArgs e)
        //{
        //    FizickoLice f = new FizickoLice();
        //    int id =Convert.ToInt32( txtAtribut.Text);
        //    f.Condition = $"K.KorisnikID={id}";
        //   List<FizickoLice> lista = new List<FizickoLice>();
        //    lista.Add( Communication.Instance.SendRequestGetResult<FizickoLice>(Common.Communication.Operation.VratiFizickoLice, f));
        //   // lista.Add(f);
        //    dgvKorisnici.DataSource = lista;
        //}
        #endregion

        //private void btnUcitaj_Click(object sender, EventArgs e)
        //{

        //}
    }
}
