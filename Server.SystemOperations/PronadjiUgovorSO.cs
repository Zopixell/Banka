using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class PronadjiUgovorSO : SystemOperationBase
    {
        Ugovor ugovor;

        public PronadjiUgovorSO(Ugovor ugovor)
        {
            this.ugovor = ugovor;
        }
        public List<Ugovor> Result { get; set; }
        protected override void Execute()
        {
            Result = repository.GetAllSpec(ugovor).Cast<Ugovor>().ToList();
           
        }
    }
}
