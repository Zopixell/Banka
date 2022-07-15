using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class PronadjiPravnaLicaSO : SystemOperationBase
    {
        public List<PravnoLice> Result { get; private set; }
        private PravnoLice p;
        public PronadjiPravnaLicaSO(PravnoLice p)
        {
            this.p = p;
        }
        protected override void Execute()
        {
            Result = repository.GetAllSpec(p).OfType<PravnoLice>().ToList();
        }
    }
}
