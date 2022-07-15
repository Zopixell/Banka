using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IDomainObjects
    {
        string TableName { get; }
        string TableNameSpec { get; }
        string InsertValues { get; }
        string IdName { get; }
        string WhereCondition { get; }
        String Condition { get; }
       int primaryKey { get; set; }
        IDomainObjects ReadObjectRow(SqlDataReader result);
        string JoinCondition { get; }
        string JoinTable { get; }
        string TableAlias { get; }
        string UpdateValues { get; }
    }
}
