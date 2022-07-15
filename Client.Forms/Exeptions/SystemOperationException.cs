using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Forms.Exeptions
{
    internal class SystemOperationException:Exception
    {
        public SystemOperationException()
        {

        }
        public SystemOperationException(String message) : base(message)
        {

        }
    }
}
