using System;
using System.Collections.Generic;
using System.Text;

namespace REST.Data.Repository
{
    public interface IRepository<T> where T : class

    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
