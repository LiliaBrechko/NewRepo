using GYM.Infrastructure;
using GYM.Interface.Repositories;
using GYM.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GYM.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        public int Create(T value)
        {
            using (DBContextGym db = new DBContextGym())
            {
                db.Set<T>().Add(value);

                db.SaveChanges();

                return value.Id;
            }
        }

        public void Delete(int id)
        {
            using (DBContextGym db = new DBContextGym())
            {
                var value = db.Set<T>().FirstOrDefault(e => e.Id == id);

                if (value != null)
                {
                    db.Set<T>().Remove(value);

                    db.SaveChanges();
                }
            }
        }

        public T Get(int id, params Expression<Func<T, object>>[] includes)
        {
            using (DBContextGym db = new DBContextGym())
            {
                IQueryable<T> result = db.Set<T>();

                foreach (var include in includes)
                {
                    result = result.Include(include);
                }

                return result.FirstOrDefault(e => e.Id == id) ?? throw new ApplicationException($"{typeof(T).Name} with id '{id}' not found");
            }
        }

        public virtual IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            using (DBContextGym db = new DBContextGym())
            {
                IQueryable<T> set = db.Set<T>();

                foreach (var include in includes)
                {
                    set = set.Include(include);
                }

                return set.ToArray();
            }
        }

        public void Update(int id, T value)
        {
            using (DBContextGym db = new DBContextGym())
            {
                var existingValue = db.Set<T>().FirstOrDefault(e => e.Id == id) ?? throw new ApplicationException($"{typeof(T).Name} with id '{id}' not found");

                db.Entry(existingValue).CurrentValues.SetValues(value);

                db.SaveChanges();
            }
        }
    }
}