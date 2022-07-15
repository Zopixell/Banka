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
    public class FizickoLice : IDomainObjects
    {
        double visinaPlate;
        int duzinaZaposlenja;
        Korisnik korisnik;
        public double VisinaPlate { get => visinaPlate; set => visinaPlate = value; }
        public int DuzinaZaposlenja { get => duzinaZaposlenja; set => duzinaZaposlenja = value; }
        [Browsable(false)]
        public string TableName => "FizickoLice";
        [Browsable(false)]
        public string InsertValues => $"{Korisnik.KorisnikID},{VisinaPlate},{DuzinaZaposlenja}";
        [Browsable(false)]
        public string IdName => "KorisnikID";

        [Browsable(false)]
        public string WhereCondition => throw new NotImplementedException();

        public Korisnik Korisnik { get => korisnik; set => korisnik = value; }
        [Browsable(false)]
        public int primaryKey { get => Korisnik.KorisnikID; set => Korisnik.KorisnikID = value; }
        [Browsable(false)]
        public string TableNameSpec => "Korisnik";
        [Browsable(false)]
        public string JoinCondition => "ON (FL.KorisnikID=K.KorisnikID)";
        [Browsable(false)]
        public string JoinTable => "JOIN Korisnik K";
        [Browsable(false)]
        public string TableAlias => "FL";
        [Browsable(false)]
        public string Condition { get; set; }
        [Browsable(false)]
        public string UpdateValues =>$" KorisnikID = {Korisnik.KorisnikID}, VisinaPlate = {VisinaPlate}, DuzinaZaposlenja={DuzinaZaposlenja} ";

        public IDomainObjects ReadObjectRow(SqlDataReader reader)
        {
            FizickoLice f = new FizickoLice
            {
                Korisnik =new Korisnik
                {
                    KorisnikID=(int)reader["KorisnikID"],
                    ImeKorisnika=(String)reader["ImeKorisnika"],
                    PrezimeKorisnika = (String)reader["PrezimeKorisnika"],
                    JMBG=(String)reader["JMBG"],

                    Bankar =new Bankar
                    {
                        BankarID=(int)reader["BankarID"]
                    }

                },
                VisinaPlate=(Double)reader["VisinaPlate"],
                DuzinaZaposlenja=(int)reader["DuzinaZaposlenja"]
            
            };
            return f;
        }
    }
}
