using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    
    public class ObrisiPravnoLiceSO:SystemOperationBase
    {

        private readonly PravnoLice pravno;
        public ObrisiPravnoLiceSO(PravnoLice pravno)
        {
            this.pravno = pravno;
        }
        protected override void Execute()
        {
            repository.DeleteSpec(pravno);
           // repository.Delete(pravno);
        }
    }
}
