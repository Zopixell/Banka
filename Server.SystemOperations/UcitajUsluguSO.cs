using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class UcitajUsluguSO:SystemOperationBase
    {
        private readonly Usluga u;
        public Usluga Result { get; private set; }
        public UcitajUsluguSO(Usluga u)
        {
            this.u = u;
        }

        protected override void Execute()
        {
           
            Result = repository.GetCondition(u).OfType<Usluga>().ToList()[0];
        }
    }
}
