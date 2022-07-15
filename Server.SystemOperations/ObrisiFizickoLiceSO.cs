using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class ObrisiFizickoLiceSO : SystemOperationBase
    {
        private readonly FizickoLice fizicko;
        public ObrisiFizickoLiceSO(FizickoLice fizicko)
        {
            this.fizicko = fizicko;
        }
        protected override void Execute()
        {
            //repository.Delete(fizicko);
            repository.DeleteSpec(fizicko);
        }
    }
}
