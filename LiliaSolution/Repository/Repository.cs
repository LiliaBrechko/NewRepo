using Interface.Repository;
using Infrastructure.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Repository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        public int Create(T entity)
        {
            using (var contex = new ApplicationContext())
            {
                contex.Add(entity);
                contex.SaveChanges();
                return entity.Id;
            }
        }

        public void Delete(params int[] id)
        {
            using (var contex = new ApplicationContext())
            {
                foreach(var entityId in id)
                {
                    var entityToRemove = contex.Set<T>().FirstOrDefault(x => x.Id == entityId) ??
                        throw new ApplicationException($"{typeof(T).Name} with {id} not found");
                    contex.Remove(entityToRemove);
                    contex.SaveChanges() ;

                }

            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var contex = new ApplicationContext())
            {
                return contex.Set<T>().ToList();

            }
        }

        public T Get(int id)
        {
            using (var contex = new ApplicationContext())
            {
                return contex.Set<T>().FirstOrDefault(x => x.Id == id)  ?? 
                    throw new ApplicationException($"{typeof(T).Name} with {id} not found");
            }
        }

        public void Update(int id, T entity)
        {
            using (var contex = new ApplicationContext())
            {
                var entityToUpdate = contex.Set<T>().FirstOrDefault( x => x.Id == id)  ?? 
                    throw new ApplicationException($"{typeof(T).Name} with {id} not found");
                contex.Entry(entityToUpdate).CurrentValues.SetValues(entity);
                contex.SaveChanges();


            }
        }
    }
}
