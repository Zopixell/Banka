using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    [Serializable]
    public class Response
    {
        public string Message { get; set; }
        public bool isSuccessful { get; set; } = true;
        public object Result { get; set; }
    }
}
