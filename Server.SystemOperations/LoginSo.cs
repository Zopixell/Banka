using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class LoginSo : SystemOperationBase
    {
        Bankar bankar;
        public LoginSo(Bankar bankar)
        {
            this.bankar = bankar;
        }
        public Bankar Result { get; private set; }
        protected override void Execute()
        {
           
           foreach(Bankar b in repository.GetAll(new Bankar()).OfType<Bankar>().ToList())
            {
                if(b.KorisnickoIme == bankar.KorisnickoIme && b.Sifra == bankar.Sifra) {

                    bankar.BankarID = b.BankarID;
                    bankar.ImeBankara = b.ImeBankara;
                    bankar.PrezimeBankara = b.PrezimeBankara;
                    Result = bankar;
                }
            }
        }
    }
}
