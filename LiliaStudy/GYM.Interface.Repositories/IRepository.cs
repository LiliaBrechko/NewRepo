using System.Linq.Expressions;

namespace GYM.Interface.Repositories
{
    public interface IRepository<T>
    {
        int Create(T value);

        void Update(int id, T value);

        T Get(int id, params Expression<Func<T, object>>[] includes);

        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes);

        void Delete(int id);
    }
}