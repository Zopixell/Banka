using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class ZapamtiFizickoLiceSO : SystemOperationBase
    {
        private FizickoLice f;
        public ZapamtiFizickoLiceSO(FizickoLice f)
        {
            this.f = f;
        }
        protected override void Execute()
        {
          repository.UpdateSpec(f);
            f.Korisnik.Condition = $"KorisnikID={f.Korisnik.KorisnikID}"; 
            repository.UpdateSpec(f.Korisnik);
        }
    }
}
