using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class UnosFizickogLicaSO : SystemOperationBase
    {
        private readonly FizickoLice fl;
        public UnosFizickogLicaSO(FizickoLice fl)
        {
            this.fl = fl;
        }
        protected override void Execute()
        {
             fl.Korisnik.KorisnikID = repository.GetNewIDSpec(fl);
            repository.Save(fl.Korisnik);
         //   fl.primaryKey = repository.GetNewID(fl);
            repository.Save(fl);
         
        }
    }
}
