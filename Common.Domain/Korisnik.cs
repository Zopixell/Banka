using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Korisnik : IDomainObjects
    {
        int korisnikID;
        String imeKorisnika;
        String prezimeKorisnika;
        String jmng;
        Bankar bankar;

        public int KorisnikID { get => korisnikID; set => korisnikID = value; }
        public string ImeKorisnika { get => imeKorisnika; set => imeKorisnika = value; }
        public string PrezimeKorisnika { get => prezimeKorisnika; set => prezimeKorisnika = value; }
        public string JMBG { get => jmng; set => jmng = value; }
        public Bankar Bankar { get => bankar; set => bankar = value; }

        public string TableName => "Korisnik";

        public string InsertValues => $"{KorisnikID}, '{ImeKorisnika}', '{PrezimeKorisnika}', '{JMBG}', {Bankar.BankarID}";

        public string IdName => "KorisnikID";

        public string WhereCondition => throw new NotImplementedException();

        public int primaryKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string TableNameSpec => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public string Condition { get; set; }

        public string UpdateValues =>$" KorisnikID={KorisnikID}, ImeKorisnika='{ImeKorisnika}', PrezimeKorisnika='{PrezimeKorisnika}', JMBG='{JMBG}', BankarID={Bankar.BankarID} ";

        public IDomainObjects ReadObjectRow(SqlDataReader reader)
        {
            Korisnik k = new Korisnik
            {
                KorisnikID = (int)reader["KorisnikID"],
                ImeKorisnika = (string)reader["ImeKorisnika"],
                PrezimeKorisnika = (string)reader["PrezimeKorisnika"],
                JMBG = (string)reader["JMBG"],
                Bankar = new Bankar
                {
                    BankarID=(int)reader["BankarID"],
                }
            };
            return k;
        }
        public override string ToString()
        {
            return $"{imeKorisnika} {prezimeKorisnika}";
        }
    }
}
