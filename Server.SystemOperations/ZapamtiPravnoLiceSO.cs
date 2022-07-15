using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class ZapamtiPravnoLiceSO : SystemOperationBase
    {
        PravnoLice p;
        public ZapamtiPravnoLiceSO(PravnoLice p)
        {
            this.p = p;
        }
        protected override void Execute()
        {
            repository.UpdateSpec(p);
            p.Korisnik.Condition = $"KorisnikID={p.Korisnik.KorisnikID}";
            repository.UpdateSpec(p.Korisnik);
        }
    }
}
