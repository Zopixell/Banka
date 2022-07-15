using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class VratiPravnoLiceSO : SystemOperationBase
    {

        private PravnoLice p;

        public PravnoLice Result{ get; set;}
        public VratiPravnoLiceSO(PravnoLice p)
        {
            this.p = p;
        }
        protected override void Execute()
        {
            Result = repository.GetAllSpec(p).OfType<PravnoLice>().ToList()[0];
        }
    }


}
       
   
