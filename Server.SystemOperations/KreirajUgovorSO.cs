using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class KreirajUgovorSO : SystemOperationBase
    {

        private readonly Ugovor ugovor;
      
        public KreirajUgovorSO(Ugovor ugovor)
        {
            this.ugovor = ugovor;
            
        }

        protected override void Execute()
        {
           ugovor.Id = repository.GetNewID(ugovor);
           repository.Save(ugovor);  //verovatno drugacije jer je jak-slab objekat

            foreach (Stavka s in ugovor.ListaStavki)
            {
                s.Ugovor.Id = ugovor.Id;
                repository.Save(s);
            }
        }
    }
}
