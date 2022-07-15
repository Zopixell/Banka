using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Ugovor : IDomainObjects
    {
        public Ugovor()
        {
            listaStavki = new BindingList<Stavka>();
        }
        int id;
        DateTime datumKreiranja;
        bool potpisBankara;
        bool potpisKorisnika;
        Bankar bankar;
        StatusUgovora status;
        Korisnik korisnik;
        Usluga usluga;
        private BindingList<Stavka> listaStavki = new BindingList<Stavka>();
        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public DateTime DatumKreiranja { get => datumKreiranja; set => datumKreiranja = value; }
        public bool PotpisBankara { get => potpisBankara; set => potpisBankara = value; }
        public bool PotpisKorisnika { get => potpisKorisnika; set => potpisKorisnika = value; }
        public Bankar Bankar { get => bankar; set => bankar = value; }
        public StatusUgovora Status { get => status; set => status = value; }
        public Korisnik Korisnik { get => korisnik; set => korisnik = value; }
        public Usluga Usluga { get => usluga; set => usluga = value; }
        public BindingList<Stavka> ListaStavki { get => listaStavki; set => listaStavki = value; }
        [Browsable(false)]
        public string TableName => " Ugovor ";
        [Browsable(false)]
        public string InsertValues => $" {Id} ,'{DatumKreiranja}', '{PotpisBankara}', '{PotpisKorisnika}',{Bankar.BankarID}, {Status.Id}, {Korisnik.KorisnikID}, {Usluga.UslugaID}";
        [Browsable(false)]
        public string IdName => "UgovorID";
        [Browsable(false)]
        public string WhereCondition => $" UgovorID={Id}";
        [Browsable(false)]
        public int primaryKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public string TableNameSpec => " Ugovor ";
        [Browsable(false)]
        public string JoinCondition => " on (k.KorisnikID=ug.KorisnikID) join Usluga u on (u.UslugaID=ug.UslugaID) join Bankar b on (b.BankarID=ug.BankarID) join StatusUgovora s on (s.StatusID=ug.StatusID) join Stavka st on (st.UgovorID=ug.UgovorID) ";
        [Browsable(false)]
        public string JoinTable => " join Korisnik k ";
        [Browsable(false)]
        public string TableAlias => " ug ";
        [Browsable(false)]
        public string Condition { get; set; }
        [Browsable(false)]
        public string UpdateValues => $" DatumKreiranja= '{DatumKreiranja}', PotpisBankara= '{PotpisBankara}', PotpisKorisnika= '{PotpisKorisnika}', BankarID= {Bankar.BankarID}, StatusID= {Status.Id}, KorisnikID= {Korisnik.KorisnikID}, UslugaID= {Usluga.UslugaID}  ";


        //fali {ListaStavki}
        public IDomainObjects ReadObjectRow(SqlDataReader reader)
        {
            Ugovor u = new Ugovor
            {
                Id = (int)reader["UgovorID"],
                DatumKreiranja = (DateTime)reader["DatumKreiranja"],
                PotpisBankara = (bool)reader["PotpisBankara"],
                PotpisKorisnika = (bool)reader["PotpisKorisnika"],
                Bankar = new Bankar
                {
                    BankarID = (int)reader["BankarID"],
                    ImeBankara = (String)reader["ImeBankara"],
                    PrezimeBankara = (String)reader["PrezimeBanakra"],
                    KorisnickoIme = (String)reader["KorisnickoIme"],
                    Sifra = (String)reader["Sifra"]
                },
                Status = new StatusUgovora
                {
                    Id=(int)reader["StatusID"],
                    NazivStatusa=(String)reader["NazivStatusa"]
                },
                Korisnik = new Korisnik
                {
                    KorisnikID = (int)reader["KorisnikID"],
                    ImeKorisnika = (string)reader["ImeKorisnika"],
                    PrezimeKorisnika = (string)reader["PrezimeKorisnika"],
                    JMBG = (string)reader["JMBG"],
                    Bankar = new Bankar
                    {
                        BankarID = (int)reader["BankarID"],
                    }
                },
                Usluga = new Usluga
                {
                    UslugaID = (int)reader["UslugaID"],
                    NazivUsluge = (string)reader["NazivUsluge"],
                    MinimalniIznos = (double)reader["MinimalniIznos"],
                    MaksimalniIznos = (double)reader["MaksimalniIznos"],
                    KamatnaStopa = (double)reader["KamatnaStopa"],
                    Bankar = new Bankar
                    {
                        BankarID = (int)reader["BankarID"],
                    }
                }
            };

            return u;
        }

        public override string ToString()
        {
            return $"Ugovor broj: {Id} kreiran {DatumKreiranja} ";
        }
    }
}
