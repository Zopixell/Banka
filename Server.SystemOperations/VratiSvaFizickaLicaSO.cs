using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class VratiSvaFizickaLicaSO:SystemOperationBase
    {
        public List<FizickoLice> Result { get; private set; }

        protected override void Execute()
        {
            Result = repository.GetAllJoin(new FizickoLice()).OfType<FizickoLice>().ToList();
        }
    }
}
