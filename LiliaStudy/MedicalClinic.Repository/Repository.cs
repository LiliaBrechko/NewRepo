using MedicalClinic.Infrastructure;
using MedicalClinic.Interface.Repository;
using MedicalClinic.Models;

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

        public void Update(T entity)
        {
            using (var db = new ApplicationContext())
            {
                var entityToUpdate = db.Set<T>().FirstOrDefault(e=> e.Id == entity.Id);
                db.Entry(entityToUpdate).CurrentValues.SetValues(entity);
                db.SaveChanges();

            }

        }
    }
}
