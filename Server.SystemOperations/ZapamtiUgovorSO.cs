using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class ZapamtiUgovorSO : SystemOperationBase
    {
        Ugovor u;
        public ZapamtiUgovorSO(Ugovor u)
        {
            this.u = u;
        }

        protected override void Execute()
        {
          
                repository.UpdateSpec(u);

            foreach (Stavka s in u.ListaStavki)
            {
                // s.Condition = u.Condition;
                repository.Update(s);
            }



        }
    }
}
