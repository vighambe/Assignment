using System.Collections.Generic;
using ContactManagement.Lib.Model;

namespace ContactManagement.Lib.AbstractRepository
{
    public interface IBaseRepository<T> where T : class, IModelBase, new()
    {
        IEnumerable<T> GetAll();
        int Count();
        T GetSingle(int id);
        //void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Commit();

        void Add(Contact model);
    }
}
