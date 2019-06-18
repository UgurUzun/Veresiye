using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Model;

namespace Veresiye.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext db;
        private readonly DbSet<T> entities;
        public Repository(ApplicationDbContext context)
        {
            this.db = context;
            this.entities = context.Set<T>();
        }
        public void Delete(T entity)
        {
            entities.Remove(entity);
        }

        public T Get(int id)
        {
            return entities.FirstOrDefault(x => x.Id == id);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return entities.Where(where).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> where)
        {
            return entities.Where(where).ToList();
        }

        public void Insert(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.CreatedBy = "unknown";
            entity.UpdatedAt = DateTime.Now;
            entity.UpdatedBy = "unknown";
            entities.Add(entity);

        }

        public void Update(T entity)
        {
            entity.UpdatedAt = DateTime.Now;
            entity.UpdatedBy = "unknown";
            db.Entry<T>(entity).State = EntityState.Modified;
        }
    }
}
