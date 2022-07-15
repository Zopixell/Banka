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
    public partial class UCKorisnikPravnoLicePretraga : UserControl
    {
        BrisanjePravnogLicaController controller;
        public UCKorisnikPravnoLicePretraga()
        {
            InitializeComponent();
            controller = new BrisanjePravnogLicaController(this);
            controller.Init();
        }
        #region
        //private void btnPretrazi_Click(object sender, EventArgs e)
        //{
        //    PravnoLice p = new PravnoLice();
        //    int id = Convert.ToInt32(txtAtribut.Text);
        //    p.Condition = $"K.KorisnikID={id}";
        //    List<PravnoLice> lista = new List<PravnoLice>();
        //    lista.Add(Communication.Instance.SendRequestGetResult<PravnoLice>(Common.Communication.Operation.VratiPravnoLice, p));
        //    // lista.Add(f);
        //    dgvKorisnici.DataSource = lista;
        //}
        #endregion


    }
}
