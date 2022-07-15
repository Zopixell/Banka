using Common.Communication;
using Common.Domain;
using Server.ApplicationLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Main
{
    public class ClientHandler
    {
        private Socket soket;
        private CommunicationHelper helper;

        public EventHandler OdjavljenKlijent;

        public ClientHandler(Socket soket)
        {
            this.soket = soket;
            helper = new CommunicationHelper(soket);
        }

        private bool kraj = false;

        public void HandleRequests()
        {
            try
            {
                while (!kraj)
                {
                    Request request = helper.Recieve<Request>();
                    Response response = CreateResponse(request);
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);;
            }
            finally { closeSocket(); }


        }

        private Response CreateResponse(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        response.Result = Controller.Instance.Login((Bankar)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da prijavi zaposlenog. (ch)";
                        }
                        break;
                    case Operation.Kraj:
                        kraj = true;
                        break;
                    case Operation.SacuvajUslugu:
                        Controller.Instance.SacuvajUslugu((Usluga)request.RequestObject);
                            break;

                    case Operation.ObrisiUslugu:
                        Controller.Instance.ObrisiUslugu((Usluga)request.RequestObject);
                        break;

                    case Operation.VratiSveUsluge:
                        response.Result = Controller.Instance.VratiSveUsluge();
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nece da vrati usluge client handler";
                        }
                        break;

                    case Operation.PronadjiUsluge:
                        response.Result = Controller.Instance.PronadjiUsluge((Usluga)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da pronadje uslugu.";
                        }
                        break;
                    case Operation.UcitajUslugu:
                        response.Result = Controller.Instance.UcitajUslugu((Usluga)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da ucita uslugu.";
                        }
                        break;
                    case Operation.VratiSveKorisnike:
                        response.Result = Controller.Instance.VratiSveKorisnike();
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nece da vrati korisnike client handler";
                        }
                        break;

                    case Operation.SacuvajPravnoLice:
                        Controller.Instance.SacuvajPravnoLice((PravnoLice)request.RequestObject);
                        break;

                    case Operation.SacuvajFizickoLice:
                        Controller.Instance.SacuvajFizickoLice((FizickoLice)request.RequestObject);
                        break;
                    case Operation.VratiFizickoLice:

                        response.Result = Controller.Instance.vratiFizickoLice((FizickoLice)request.RequestObject);
                        if (response == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "NECE DA VRATI Fizicko licee jedno ClientHandler";
                        }
                        break;
                    case Operation.VratiPravnoLice:
                        response.Result = Controller.Instance.vratiPravnoLice((PravnoLice)request.RequestObject);
                        if (response == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "NECE DA VRATI pravno licee jedno ClientHandler";
                        }
                        break;

                    case Operation.ObrisiFizickoLice:
                        Controller.Instance.ObrisiFizickoLice((FizickoLice)request.RequestObject);
                        break;
                    case Operation.ObrisiPravnoLice:
                        Controller.Instance.ObrisiPravnoLice((PravnoLice)request.RequestObject);
                        break;
                    case Operation.ZapamtiFizickoLice:
                        Controller.Instance.ZapamtiFizickoLice((FizickoLice)request.RequestObject);
                        break;
                    case Operation.ZapamtiPravnoLice:
                        Controller.Instance.ZapamtiPravnoLice((PravnoLice)request.RequestObject);
                        break;
                    case Operation.VratiSveBankare:
                       response.Result= Controller.Instance.VratiSveBankare();
                        if (response == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "NECE DA VRATI BANKARE ClientHandler";
                        }
                        break;

                    case Operation.VratiFizickaLica:
                        response.Result = Controller.Instance.VratiSvaFizickaLica();
                        if (response == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "NECE DA VRATI Fizicka lica ClientHandler";
                        }
                        break;
                    case Operation.VratiPravnaLica:
                        response.Result = Controller.Instance.VratiSvaPravnaLica();
                        if (response == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "NECE DA VRATI Fizicka lica ClientHandler";
                        }

                        break;
                    case Operation.PronadjiPravnaLica:
                        response.Result = Controller.Instance.PronadjiPravnaLica((PravnoLice)request.RequestObject);
                        if (response == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Ne pronalazi pravna lica";
                        }
                        break;
                    case Operation.PronadjiFizickaLica:
                        response.Result = Controller.Instance.PronadjiFizickaLica((FizickoLice)request.RequestObject);
                        if (response == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Ne pronalazi fizicka lica";
                        }
                        break;
                    case Operation.KreirajUgovor:
                        Controller.Instance.KreirajUgovor((Ugovor)request.RequestObject);
                        break;
                    case Operation.UcitajUgovor:
                        response.Result = Controller.Instance.UcitajUgovor((Ugovor)request.RequestObject);
                        if (response == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Nece da vrati ugovor ClientHandler";
                        }
                        break;

                    case Operation.PronadjiUgovor:
                        response.Result = Controller.Instance.PronadjiUgovor((Ugovor)request.RequestObject);
                        if (response == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Ne pronalazi ugovor ";
                        }
                        break;
                    case Operation.ZapamtiUgovor:

                        Controller.Instance.ZapamtiUgovor((Ugovor)request.RequestObject);
                        break;


                    case Operation.RaskidUgovora:

                        Controller.Instance.RaskidUgovora((Ugovor)request.RequestObject);
                        break;
                    default:
                        break;

                        
                }
            }
            catch (Exception ex)
            {
                //message
                response.isSuccessful = false;
                response.Message = ex.Message;
                
            }
            return response;
        }

        private object lockobject = new object(); //saznati sta je
        internal void closeSocket()
        {
            lock (lockobject)
            {
                if (soket != null)
                {
                    kraj = true;
                    soket.Shutdown(SocketShutdown.Both);
                    soket.Close();
                    soket = null;
                    OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
                }
            }
        }


        

    }
}
