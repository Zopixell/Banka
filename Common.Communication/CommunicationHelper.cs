using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public class CommunicationHelper
    {
        private Socket soket;
        private NetworkStream tok;
        private BinaryFormatter formater;

        public CommunicationHelper(Socket soket)
        {
            this.soket = soket;
            tok = new NetworkStream(soket);
            formater = new BinaryFormatter();
        }

        public void Send<T>(T obj) where T : class
        {
            formater.Serialize(tok, obj);
        }

        public T Recieve<T>()where T: class
        {
            return (T)formater.Deserialize(tok);
        }

    }
}
