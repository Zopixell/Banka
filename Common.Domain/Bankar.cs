using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Bankar:IDomainObjects
    {
        int bankarID;
        String imeBankara;
        String prezimeBankara;
        String korisnickoIme;
        String sifra;

        public int BankarID { get => bankarID; set => bankarID = value; }
        public string ImeBankara { get => imeBankara; set => imeBankara = value; }
        public string PrezimeBankara { get => prezimeBankara; set => prezimeBankara = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        public override string ToString()
        {
            return $"{imeBankara}  {prezimeBankara}";
        }
        public string TableName => "Bankar";

        public string InsertValues => $"{BankarID},'{ImeBankara}','{PrezimeBankara}','{KorisnickoIme}','{Sifra}'";

        public string IdName => "BankarID";

        public string WhereCondition => throw new NotImplementedException();

        public int primaryKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string TableNameSpec => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public string Condition => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public IDomainObjects ReadObjectRow(SqlDataReader reader)
        {
          Bankar b=new Bankar
          {
              BankarID=(int)reader["BankarID"],
              ImeBankara=(String)reader["ImeBankara"],
              PrezimeBankara = (String)reader["PrezimeBanakra"],
             KorisnickoIme = (String)reader["KorisnickoIme"],
             Sifra=(String)reader["Sifra"]


          };
          return b;
        }
    }
}
