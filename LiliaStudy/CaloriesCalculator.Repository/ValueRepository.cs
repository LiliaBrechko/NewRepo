using CaloriesCalculator.Infrastructure;
using CaloriesCalculator.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Repository
{
    public class ValueRepository<T> : IValueRepository<T> where T : class
    {
        public void Create(T value)
        {
            using (var db = new ApplicationContext())
            {
                db.Set<T>().Add(value);
                db.SaveChanges();
            }
        }

        public void Delete(params T[] values)
        {
            using (var db = new ApplicationContext())
            {
                db.Set<T>().RemoveRange(values);
                db.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var db = new ApplicationContext())
            {
               return db.Set<T>().ToArray();
            }
        }

        public void Update(T value)
        {
            using (var db = new ApplicationContext())
            {
                db.Set<T>().Update(value);
                db.SaveChanges();
            }
        }
    }
}
