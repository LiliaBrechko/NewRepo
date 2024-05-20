using CaloriesCalculator.Infrastructure;
using CaloriesCalculator.Interface.Repository;
using CaloriesCalculator.Models;
using System.Diagnostics.Metrics;

namespace CaloriesCalculator.Repository

{
    public class EntityRepository<T> : IEntityRepository<T> where T : class, IEntity
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

        public void Delete(params int[] ids)
        {
            using (var db = new ApplicationContext())
            {
                var entities = db.Set<T>().Where(e => ids.Contains(e.Id));
                db.Set<T>().RemoveRange(entities);
                db.SaveChanges();
            }
        }

        public T Get(int id)
        {
            using (var db = new ApplicationContext())
            {
                return db.Set<T>().FirstOrDefault(e => e.Id == id);
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var db = new ApplicationContext())
            {
                return db.Set<T>().ToArray();
            }
        }

        public void Update(int id, T entity)
        {
            using (var db = new ApplicationContext())
            {
                var entityToUpdate = db.Set<T>().FirstOrDefault(entity => entity.Id == id);

                db.Entry(entityToUpdate).CurrentValues.SetValues(entity);
                db.SaveChanges();
            }
        }
    }
}
