using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class UcitajUgovorSO : SystemOperationBase
    {
         private Ugovor u;
        public Ugovor Result { get; private set; }
        public UcitajUgovorSO(Ugovor u)
        {
            this.u = u;
        }
        protected override void Execute()
        {
            Result = repository.GetAllSpec(u).OfType<Ugovor>().ToList()[0];
          
            Result.ListaStavki =new System.ComponentModel.BindingList<Stavka> (repository.GetAllSpec(new Stavka { Condition = $"st.UgovorID={Result.Id}" }).Cast<Stavka>().ToList());
        }
    }
}
