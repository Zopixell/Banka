using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class VratiFizickoLiceSO : SystemOperationBase
    {
        private FizickoLice f;

       public FizickoLice Result { get; set; }

        public VratiFizickoLiceSO(FizickoLice f)
        {
            this.f = f;
        }

        protected override void Execute()
        {
            Result = repository.GetAllSpec(f).OfType<FizickoLice>().ToList()[0];
        }
    }
}
