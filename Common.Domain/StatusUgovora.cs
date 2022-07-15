using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    
    [Serializable]
    public class StatusUgovora : IDomainObjects
    {
        int id;
        String nazivStatusa;

        public int Id { get => id; set => id = value; }
        public String NazivStatusa { get => nazivStatusa; set => nazivStatusa = value; }
        public override string ToString()
        {
            return $"{nazivStatusa}";
        }
        public string TableName => "StatusUgovora";

        public string TableNameSpec => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

        public string IdName => throw new NotImplementedException();

        public string WhereCondition => throw new NotImplementedException();

        public string Condition => throw new NotImplementedException();

        public int primaryKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string JoinCondition => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public IDomainObjects ReadObjectRow(SqlDataReader reader)
        {
            StatusUgovora st = new StatusUgovora
            {
                id = (int)reader["StatusID"],
                nazivStatusa = (String)reader["NazivStatusa"]
            };

            return st;
        }
    }
}
