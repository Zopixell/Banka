using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class VratiSveKorisnikeSO : SystemOperationBase
    {
        public List<Korisnik> Result { get; private set; }
        protected override void Execute()
        {
           Result=repository.GetAll(new Korisnik()).OfType<Korisnik>().ToList();
        }
    }
}
