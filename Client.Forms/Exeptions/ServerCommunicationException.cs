using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Forms.Exeptions
{
    internal class ServerCommunicationException:Exception
    {
        public ServerCommunicationException()
        {

        }
        public ServerCommunicationException(String message):base(message)
        {

        }
    }
}
