using FirstDB;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        public int Create(T entity)
        {
            using(var contex = new Config())
            {
                contex.Add(entity);
                contex.SaveChanges();
                return entity.Id;

            }
        }

        public void Delete(params int[] ids)
        {
            using (var contex = new Config())
            {
                foreach(var id in ids)
                {
                    var entitytoremove = contex.Set<T>().FirstOrDefault(a => a.Id == id) ?? throw new ApplicationException($"{typeof(T).Name} with {id} not found");
                    contex.Remove(entitytoremove);
                    contex.SaveChanges();
                }
                
            }
        }

        public T Get(int id)
        {
            using (var contex = new Config())
            {
                return contex.Set<T>().FirstOrDefault(a => a.Id == id) ?? throw new ApplicationException($"{typeof(T).Name} with {id} not found");

            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var contex = new Config())
            {
                return contex.Set<T>().ToList();
            }

        }

        public void Update(int id, T entity)
        {
            using (var contex = new Config())
            {
                var entitytoupdate = contex.Set<T>().FirstOrDefault(a=> a.Id == id) ?? throw new ApplicationException($"{typeof(T).Name} with {id} not found");
                contex.Entry(entitytoupdate).CurrentValues.SetValues(entity);
                contex.SaveChanges();
            }

        }
    }
}
