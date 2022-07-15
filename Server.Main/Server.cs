using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Main
{
    public class Server
    {

        private Socket soket;
        private List<ClientHandler> klijenti = new List<ClientHandler>();

        public Server()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Start()
        {
            try
            {
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
                soket.Bind(ep);
                soket.Listen(5);
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void Listen()
        {
            try
            {
                while (true)
                {
                    Socket klijentSoket = soket.Accept();
                    ClientHandler klijent = new ClientHandler(klijentSoket);
                    klijenti.Add(klijent);
                    klijent.OdjavljenKlijent +=Handler_OdjavljenKlijent;
                    Thread nitKlijenta = new Thread(klijent.HandleRequests);
                    nitKlijenta.IsBackground = false;
                    nitKlijenta.Start();
                
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void Handler_OdjavljenKlijent(object sender, EventArgs args)
        {
            klijenti.Remove((ClientHandler)sender);
        }

        public void Stop()
        {
            soket.Close();
            foreach(ClientHandler handler in klijenti.ToList())
            {
               handler.closeSocket();
            }
            klijenti.Clear();
        }

    }
}
