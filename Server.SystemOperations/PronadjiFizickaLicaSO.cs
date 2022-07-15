using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class PronadjiFizickaLicaSO : SystemOperationBase
    {
        private FizickoLice f;
        public List<FizickoLice> Result { get; private set; }
        public PronadjiFizickaLicaSO(FizickoLice f)
        {
            this.f = f;
        }
        protected override void Execute()
        {
            Result=repository.GetAllSpec(f).OfType<FizickoLice>().ToList();
         }
    }
}
