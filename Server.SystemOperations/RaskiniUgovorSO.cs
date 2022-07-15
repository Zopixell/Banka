using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class RaskiniUgovorSO : SystemOperationBase
    {
        Common.Domain.Ugovor u;
        public RaskiniUgovorSO(Common.Domain.Ugovor u)
        {
            this.u = u;
        }

        protected override void Execute()
        {
            //  repository.UpdateSpec(u);
            repository.DeleteSpec(u);
        }
    }
}
