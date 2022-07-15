using Client.Forms.Exeptions;
using Common.Communication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client.Forms.ServerCommunication
{
    public class Communication
    {
        private Socket soket;
        private CommunicationHelper helper;
        private static Communication instance;


        private Communication() 
        { 
        }

        public static Communication Instance
        {
            get { 
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        public Output SendRequestGetResult<Output>(Operation op, object i= null) where Output : class
        {
            SendRequest(op, i);
            return GetResult<Output>();
        }

        private T GetResult<T>() where T : class
        {
            Response response = helper.Recieve<Response>();
            if (response.isSuccessful)
            {
                return (T)response.Result;
            }
            else
            {
                //System.Windows.Forms.MessageBox.Show("NIje okej result");
                
                throw new SystemOperationException(response.Message);
            }
        }

        private void SendRequest(Operation operation, object requestObject=null)
        {
            try
            {
                Request r = new Request
                {
                    Operation = operation,
                    RequestObject = requestObject
                };
                helper.Send(r);

            }
            catch (IOException ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
                throw new ServerCommunicationException(ex.Message);
            }
        }
        public void SendRequestNoResult(Operation op, object i)
        {
            SendRequest(op, i);
            GetResult();
        }
        private void GetResult()
        {
            Response response = helper.Recieve<Response>();
            if (!response.isSuccessful)
            {
                throw new SystemOperationException(response.Message);
            }
        }

        public void Connect()
        {
            if (soket == null || !soket.Connected)
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soket.Connect("127.0.0.1", 9000);
                helper = new CommunicationHelper(soket);
            } 

        }

        public void Close()
        {
            if (soket == null) return;
            Request request = new Request
            {
                Operation = Operation.Kraj,
            };
            helper.Send(request);
            soket.Shutdown(SocketShutdown.Both);
            soket.Close();
            soket = null;

        }
    }
}
