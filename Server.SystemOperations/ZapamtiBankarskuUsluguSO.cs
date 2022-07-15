using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class ZapamtiBankarskuUsluguSO : SystemOperationBase
    {
        private readonly Usluga u;

        public ZapamtiBankarskuUsluguSO(Usluga u)
        {
            this.u = u;
        }
        protected override void Execute()
        {
            u.UslugaID = repository.GetNewID(u);
            repository.Save(u);
        }
    }
}
