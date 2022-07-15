using Common.Domain;
using Server.DatabaseBroker;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repository.DatabaseRepository
{
    public class GenericDbRepository : IRepository<IDomainObjects>
    {
        private Broker broker = new Broker();

        
        public List<IDomainObjects> GetAll(IDomainObjects obj)
        {
            List<IDomainObjects> result = new List<IDomainObjects>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Select * from {obj.TableName}";
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObjects rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public void Save(IDomainObjects obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Insert into {obj.TableName} values ({obj.InsertValues})";
            
            command.ExecuteNonQuery();
        }
        #region
        public void Update(IDomainObjects obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Update {obj.TableName} SET {obj.UpdateValues} where {obj.WhereCondition}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Delete(IDomainObjects obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Delete from {obj.TableName} where {obj.IdName} ";
            command.ExecuteNonQuery();
        }

        public List<IDomainObjects> Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
        #endregion

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public IDomainObjects Login(IDomainObjects obj)
        {

            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Select * from {obj.TableName}";
            using(SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    IDomainObjects rowObject = obj.ReadObjectRow(reader);
                    return rowObject;
                }

            }
            return null;
        }

        public int GetNewID(IDomainObjects obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Select max({obj.IdName}) from {obj.TableName}";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                return (int)result+1;
            }
        }

        public int GetNewIDSpec(IDomainObjects obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Select max({obj.IdName}) from {obj.TableNameSpec}";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                return (int)result + 1;
            }
        }
        public void DeleteSpec(IDomainObjects obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Delete from {obj.TableNameSpec} where {obj.Condition}";
            command.ExecuteNonQuery();
        }

        public List<IDomainObjects> GetAllSpec(IDomainObjects obj)
        {
            List<IDomainObjects> result = new List<IDomainObjects>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Select * from {obj.TableName} {obj.TableAlias} {obj.JoinTable} {obj.JoinCondition} WHERE {obj.Condition}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObjects rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }
        public List<IDomainObjects> GetAllJoin(IDomainObjects obj)
        {
            List<IDomainObjects> result = new List<IDomainObjects>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Select * from {obj.TableName} {obj.TableAlias} {obj.JoinTable} {obj.JoinCondition}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObjects rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public IDomainObjects GetSpec(IDomainObjects obj)
        {
          
          SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Select * from {obj.TableName} {obj.TableAlias} {obj.JoinTable} {obj.JoinCondition} WHERE {obj.Condition}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObjects rowObject = obj.ReadObjectRow(reader);
                   return rowObject;
                }
            }
            return null;
        }

        public void UpdateSpec(IDomainObjects obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Update {obj.TableName} set {obj.UpdateValues} where {obj.Condition}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public List<IDomainObjects> GetCondition(IDomainObjects obj)
        {
            List<IDomainObjects> result = new List<IDomainObjects>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Select * from {obj.TableName}  WHERE {obj.Condition}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObjects rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }
    }
}
