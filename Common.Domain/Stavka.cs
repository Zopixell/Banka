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
    public class Stavka : IDomainObjects
    {
        Usluga usluga;
        Ugovor ugovor;
        int redniBroj;
        double kamatnaStopa;
        double iznosUsluge;

        public Usluga Usluga { get => usluga; set => usluga = value; }
        public Ugovor Ugovor { get => ugovor; set => ugovor = value; }
        public int RedniBroj { get => redniBroj; set => redniBroj = value; }
        public double KamatnaStopa { get => kamatnaStopa; set => kamatnaStopa = value; }
        public double IznosUsluge { get => iznosUsluge; set => iznosUsluge = value; }
        [Browsable(false)]
        public string TableName => " Stavka ";
        [Browsable(false)]
        public string InsertValues => $" {Usluga.UslugaID}, {Ugovor.Id}, {RedniBroj}, {kamatnaStopa}, {iznosUsluge} ";
        [Browsable(false)]
        public string IdName => throw new NotImplementedException();
        [Browsable(false)]
        public string WhereCondition => $" UgovorID={Ugovor.Id}";
        [Browsable(false)]
        public int primaryKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public string TableNameSpec => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => " on ( ug.UgovorID=st.UgovorID ) join Usluga u on ( u.UslugaId=st.UslugaID ) ";
        [Browsable(false)]
        public string JoinTable => " join Ugovor ug ";
        [Browsable(false)]
        public string TableAlias => " st ";
        [Browsable(false)]
        public string Condition { get; set; }
        [Browsable(false)]
        public string UpdateValues => $" UslugaID= {Usluga.UslugaID}, UgovorID= {Ugovor.Id}, RedniBroj= {RedniBroj}, KamatnaStopa= {KamatnaStopa}, IznosUsluge= {IznosUsluge} ";

        public IDomainObjects ReadObjectRow(SqlDataReader reader)
        {
            Stavka s = new Stavka
            {
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

                },
                Ugovor = new Ugovor
                {
                    Id = (int)reader["UgovorID"],
                    DatumKreiranja = (DateTime)reader["DatumKreiranja"],
                    PotpisBankara = (bool)reader["PotpisBankara"],
                    PotpisKorisnika = (bool)reader["PotpisKorisnika"],
                    Bankar = new Bankar
                    {
                        BankarID = (int)reader["BankarID"],
                       
                    },
                    Status = new StatusUgovora
                    {
                        Id = (int)reader["StatusID"],
                       
                    },
                    Korisnik = new Korisnik
                    {
                        KorisnikID = (int)reader["KorisnikID"],
                       
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
                },
                RedniBroj =(int)reader["RedniBroj"],
                KamatnaStopa = (double)reader["KamatnaStopa"],
                IznosUsluge = (double)reader["IznosUsluge"],
            };
            return s;
        }
    }
}
