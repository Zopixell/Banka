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
    public class PravnoLice:IDomainObjects
    {
        double mesecnaZarada;
        int pib;
        DateTime datumOsnivanja;
        Korisnik korisnik;
        public double MesecnaZarada { get => mesecnaZarada; set => mesecnaZarada = value; }
        public int PIB { get => pib; set => pib = value; }
        public DateTime DatumOsnivanja { get => datumOsnivanja; set => datumOsnivanja = value; }
        [Browsable(false)]
        public string TableName => "PravnoLice";
        [Browsable(false)]
        public string InsertValues =>$"{Korisnik.KorisnikID}, {MesecnaZarada},{PIB}, '{DatumOsnivanja}'";
        [Browsable(false)]
        public string IdName => "KorisnikID";
        [Browsable(false)]
        public string WhereCondition => throw new NotImplementedException();
     
        public Korisnik Korisnik { get => korisnik; set => korisnik = value; }
        [Browsable(false)]
        public int primaryKey { get => Korisnik.KorisnikID; set => Korisnik.KorisnikID=value; }
        [Browsable(false)]
        public string TableNameSpec => "Korisnik";
        [Browsable(false)]
        public string JoinCondition =>"ON (PL.KorisnikID=K.KorisnikID)";
        [Browsable(false)]
        public string JoinTable => "JOIN Korisnik K";
        [Browsable(false)]
        public string TableAlias =>"PL";
        [Browsable(false)]
        public string Condition { get; set; }
        [Browsable(false)]
        public string UpdateValues =>$" KorisnikID={Korisnik.KorisnikID}, MesecnaZarada={MesecnaZarada}, PIB={PIB}, DatumOsnivanja='{DatumOsnivanja}'";

        public IDomainObjects ReadObjectRow(SqlDataReader reader)
        {
            PravnoLice p = new PravnoLice
            {
                Korisnik=new Korisnik {
                    KorisnikID = (int)reader["KorisnikID"],
                    ImeKorisnika = (String)reader["ImeKorisnika"],
                    PrezimeKorisnika = (String)reader["PrezimeKorisnika"],
                    JMBG = (String)reader["JMBG"],

                    Bankar = new Bankar
                    {
                        BankarID = (int)reader["BankarID"]
                    }
                },
                MesecnaZarada = (double)reader["MesecnaZarada"],
                PIB=(int)reader["PIB"],
                DatumOsnivanja =(DateTime)(reader["DatumOsnivanja"])

            };
            return p;
        }
    }
}
