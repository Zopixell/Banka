using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class UnosPravnogLicaSO : SystemOperationBase
    {
        private readonly PravnoLice pl;
        public UnosPravnogLicaSO(PravnoLice pl)
        {
            this.pl = pl;
        }
        protected override void Execute()
        {
            pl.Korisnik.KorisnikID = repository.GetNewIDSpec(pl);
            repository.Save(pl.Korisnik);
           // pl.Korisnik.id = repository.GetNewIDSpec(pl);
            repository.Save(pl);
        }
    }
}
