using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class PronadjiUsluguSO : SystemOperationBase
    {
        private readonly Usluga usluga;
        public List<Usluga> Response { get; private set; }
        public PronadjiUsluguSO(Usluga usluga)
        {
            this.usluga = usluga;
        }
        protected override void Execute()
        {
           Response = repository.GetCondition(usluga).OfType<Usluga>().ToList();
        }
    }
}
