using MedicalClinic.Infrastructure;
using MedicalClinic.Interface.Repository;
using MedicalClinic.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MedicalClinic.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        public int Create(T entity)
        {
            using (var db = new ApplicationContext())
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
                return entity.Id;

            }
           
        }

        public void Delete(params int[] id)
        {
            using (var db = new ApplicationContext())
            {
                
                var entities = db.Set<T>().Where(e=> id.Contains(e.Id));
                db.Set<T>().RemoveRange(entities);  
                db.SaveChanges();
            }
           
        }

        public T Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            using (var db = new ApplicationContext())
            {
                IQueryable<T> query = db.Set<T>();

                if (includes != null)
                {
                    query = includes.Aggregate(query, (current, include) => current.Include(include));
                }

                return query.FirstOrDefault(predicate);
            }
        }

        public V GetProjected<V>(Expression<Func<T, bool>> predicate, Expression<Func<T, V>> selector)
        {
            using (var db = new ApplicationContext())
            {
                IQueryable<T> query = db.Set<T>();

                return query.Where(predicate).Select(selector).FirstOrDefault();
            }
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            using (var db = new ApplicationContext())
            {
                IQueryable<T> query = db.Set<T>();

                if (includes != null)
                {
                    query = includes.Aggregate(query, (current, include) => current.Include(include));
                }

                return query.ToArray();
            }

        }

        public void Update(T entity)
        {
            using (var db = new ApplicationContext())
            {
                 db.Set<T>().Update(entity);
                 db.SaveChanges();

            }

        }
    }
}
