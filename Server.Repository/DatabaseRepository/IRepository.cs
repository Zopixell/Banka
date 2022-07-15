using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repository.DatabaseRepository
{
    public interface IRepository<T> where T :class
    {
        List<T> GetAll(IDomainObjects obj);
        List<T> GetAllSpec(IDomainObjects obj);
        List<T> GetAllJoin(IDomainObjects obj);
        List<T> GetCondition(IDomainObjects obj);
        T GetSpec(IDomainObjects obj);
        void Save(T obj);
        void Update(T obj);
        void Delete(T obj);
        List<T> Search(string kriterijum);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
        T Login(T obj);
        int GetNewID(IDomainObjects obj);
        int GetNewIDSpec(IDomainObjects obj);
        void DeleteSpec(T obj);
        void UpdateSpec(T obj);
    }
}
