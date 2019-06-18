using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Model;

namespace Veresiye.Data
{
    public interface IRepository<T> where T:BaseEntity
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> where);
    }
}
