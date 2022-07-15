using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class VratiSvaPravnaLicaSO : SystemOperationBase
    {
        public List<PravnoLice> Result { get; private set; }
        protected override void Execute()
        {
            Result = repository.GetAllJoin(new PravnoLice()).OfType<PravnoLice>().ToList();
        }
    }
}
