using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class ObrisiUsluguSO : SystemOperationBase
    {
        private readonly Usluga u;
        public ObrisiUsluguSO(Usluga u)
        {
            this.u = u;
        }
        protected override void Execute()
        {
            repository.DeleteSpec(u);
        }
    }
}
