using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class VratiSveUslugeSO : SystemOperationBase
    {
       public List<Usluga> Result { get; private set; }
        protected override void Execute()
        {
           Result = repository.GetAll(new Usluga()).OfType<Usluga>().ToList();
        }
    }
}
