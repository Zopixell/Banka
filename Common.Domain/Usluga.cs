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
    public class Usluga:IDomainObjects
    {
        int uslugaID;
        String nazivUsluge;
        double minimalniIznos;
        double maksimalniIznos;
        double kamatnaStopa;
        Bankar bankar;

        public int UslugaID { get => uslugaID; set => uslugaID = value; }
        public string NazivUsluge { get => nazivUsluge; set => nazivUsluge = value; }
        public double MinimalniIznos { get => minimalniIznos; set => minimalniIznos = value; }
        public double MaksimalniIznos { get => maksimalniIznos; set => maksimalniIznos = value; }
        public double KamatnaStopa { get => kamatnaStopa; set => kamatnaStopa = value; }
        [Browsable(false)]
        public Bankar Bankar { get => bankar; set => bankar = value; }
        [Browsable(false)]
        public string TableName => "Usluga";
        [Browsable(false)]
        public string InsertValues => $"{UslugaID}, '{NazivUsluge}', {MinimalniIznos}, {MaksimalniIznos}, {KamatnaStopa}, {Bankar.BankarID}";
        [Browsable(false)]
        public string IdName => "UslugaID";
        [Browsable(false)]

        public string WhereCondition => throw new NotImplementedException();
        [Browsable(false)]

        public int primaryKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]

        public string TableNameSpec => "Usluga";
        [Browsable(false)]

        public string JoinCondition => throw new NotImplementedException();
        [Browsable(false)]

        public string JoinTable => throw new NotImplementedException();
        [Browsable(false)]

        public string TableAlias => throw new NotImplementedException();
        [Browsable(false)]

        public string Condition { get; set; }
        [Browsable(false)]

        public string UpdateValues => throw new NotImplementedException();

        public IDomainObjects ReadObjectRow(SqlDataReader reader)
        {
            Usluga u = new Usluga
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
            };
        return u;
        }
        public override string ToString()
        {
            return $"{ NazivUsluge}";
        }
    }
}
