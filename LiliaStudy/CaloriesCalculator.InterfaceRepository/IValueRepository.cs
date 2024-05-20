using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Repository
{
    public interface IValueRepository<T>
    {
        void Create(T value);
        void Update(T value);
        void Delete(params T[] values);       
        IEnumerable<T> GetAll();
    }
}
