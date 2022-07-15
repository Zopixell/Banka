using Common.Domain;
using Server.SystemOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ApplicationLogic
{
    public class Controller
    {

        private static Controller instance;
        private Controller() {

        }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        //1.	Signal PrijaviZaposlenog(Bankar)
        public Bankar Login(Bankar bankar)
        {
            SystemOperationBase so = new LoginSo(bankar);
            so.ExecuteTemplate();
            return ((LoginSo)so).Result;
        }



        //2.	 ZapamtiNovogKorisnika(Korisnik)
        public void SacuvajFizickoLice( FizickoLice fizickoLice)
        {
            SystemOperationBase so = new UnosFizickogLicaSO(fizickoLice);
            so.ExecuteTemplate();

        }
        public void SacuvajPravnoLice(PravnoLice pravnoLice)
        {
            SystemOperationBase so = new UnosPravnogLicaSO(pravnoLice);
            so.ExecuteTemplate();

        }
        //3.	Signal VratiKorisnike(List<Korisnik>)
        public List<Korisnik> VratiSveKorisnike()
        {
            SystemOperationBase so = new VratiSveKorisnikeSO();
            so.ExecuteTemplate();
            return ((VratiSveKorisnikeSO)so).Result;
        }


        public List<FizickoLice> VratiSvaFizickaLica()
        {
            SystemOperationBase so = new VratiSvaFizickaLicaSO();
            so.ExecuteTemplate();
            return ((VratiSvaFizickaLicaSO)so).Result;

        }
        public List<PravnoLice> VratiSvaPravnaLica()
        {
            SystemOperationBase so = new VratiSvaPravnaLicaSO();
            so.ExecuteTemplate();
            return ((VratiSvaPravnaLicaSO)so).Result;

        }
       

        //4.	Signal ZapamtiKorisnika(Korisnik)
        public void ZapamtiFizickoLice(FizickoLice f)
        {
            SystemOperationBase so = new ZapamtiFizickoLiceSO(f);
            so.ExecuteTemplate();
        }
        public void ZapamtiPravnoLice(PravnoLice p)
        {
            SystemOperationBase so = new ZapamtiPravnoLiceSO(p);
            so.ExecuteTemplate();
        }

        //5.	Signal PronadjiKorisnika(Korisnik, List<Korisnik>)
        public List<PravnoLice> PronadjiPravnaLica(PravnoLice p)
        {
            SystemOperationBase so = new PronadjiPravnaLicaSO(p);
            so.ExecuteTemplate();
            return ((PronadjiPravnaLicaSO)so).Result;
        }
        public List<FizickoLice> PronadjiFizickaLica(FizickoLice f)
        {
            SystemOperationBase so = new PronadjiFizickaLicaSO(f);
            so.ExecuteTemplate();
            return ((PronadjiFizickaLicaSO)so).Result;
        }
        //6.	Signal UcitajKorisnika(Korisnik)
        public FizickoLice vratiFizickoLice(FizickoLice f)
        {
            SystemOperationBase so = new VratiFizickoLiceSO(f);
            so.ExecuteTemplate();
            return ((VratiFizickoLiceSO)so).Result;

        }
        public PravnoLice vratiPravnoLice(PravnoLice p)
        {
            SystemOperationBase so = new VratiPravnoLiceSO(p);
            so.ExecuteTemplate();
            return ((VratiPravnoLiceSO)so).Result;
        }

        //7.	Signal ObrisiKorisnika(Korisnik)
        public void ObrisiFizickoLice(FizickoLice fizicko)
        {
            SystemOperationBase so = new ObrisiFizickoLiceSO(fizicko);
            so.ExecuteTemplate();
        }
        public void ObrisiPravnoLice(PravnoLice pravno)
        {
            SystemOperationBase so = new ObrisiPravnoLiceSO(pravno);
            so.ExecuteTemplate();
        }
        //8.	Signal ZapamtiBankarskuUslugu(BankarskaUsluga)

        public void SacuvajUslugu(Usluga usluga)
        {
            SystemOperationBase so = new ZapamtiBankarskuUsluguSO(usluga);
            so.ExecuteTemplate();

        }
        //9.	Signal VratiUsluge(List<Usluga>)

        public List<Usluga> VratiSveUsluge()
        {
            SystemOperationBase so = new VratiSveUslugeSO();
            so.ExecuteTemplate();
            return ((VratiSveUslugeSO)so).Result;
        }
        //10.	Signal PronadjiUslugu(Usluga, List<Usluga>)

        public List<Usluga> PronadjiUsluge(Usluga u)
        {
            SystemOperationBase so = new PronadjiUsluguSO(u);
            so.ExecuteTemplate();
            return ((PronadjiUsluguSO)so).Response;
        }
        //11.	Signal UcitajUslugu(Usluga)
        public Usluga UcitajUslugu(Usluga u)
        {
            SystemOperationBase so = new UcitajUsluguSO(u);
            so.ExecuteTemplate();
            return ((UcitajUsluguSO)so).Result;
        }
        //12.	Signal ObrisiUslugu(Usluga)
        public void ObrisiUslugu(Usluga usluga)
        {
            SystemOperationBase so = new ObrisiUsluguSO(usluga);
            so.ExecuteTemplate();
        }
        //13.	Signal KreirajUgovor(Usluga, Korisnik)

        public void KreirajUgovor(Ugovor ugovor)
        {
            SystemOperationBase so = new KreirajUgovorSO(ugovor);
            so.ExecuteTemplate();

        }
        //14.	Signal ZapamtiPodatkeUgovora(Ugovor)
        public void ZapamtiUgovor(Ugovor u)
        {
            SystemOperationBase so = new ZapamtiUgovorSO(u);
            so.ExecuteTemplate();
        }
        //15.	Signal PronadjiUgovor(Usluga, List<Usluga>, Korisnik, List<Korisnik>)
        public List<Ugovor> PronadjiUgovor(Ugovor ugovor)
        {
            SystemOperationBase so = new PronadjiUgovorSO(ugovor);
            so.ExecuteTemplate();
            return ((PronadjiUgovorSO)so).Result;
        }
        //16.	Signal UcitajUgovor(Ugovor)
        public Ugovor UcitajUgovor(Ugovor u)
        {
            SystemOperationBase so = new UcitajUgovorSO(u);
            so.ExecuteTemplate();
            return ((UcitajUgovorSO)so).Result;
        }

        //17.	Signal RaskiniUgovor(Ugovor)

        
        public void RaskidUgovora(Ugovor u)
        {
            SystemOperationBase so = new RaskiniUgovorSO(u);
            so.ExecuteTemplate();

        }
        public List<Bankar> VratiSveBankare()
        {
            SystemOperationBase so = new VratiSveBankareSO();
            so.ExecuteTemplate();
            return ((VratiSveBankareSO)so).Result;
        }


    }

}

