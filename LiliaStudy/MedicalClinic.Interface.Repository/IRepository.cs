using System.Linq.Expressions;
using System.Security.Principal;
using MedicalClinic.Models;

namespace MedicalClinic.Interface.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        int Create(T entity);
        void Update(T entity);
        void Delete(params int[] id);
        T Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        V GetProjected<V>(Expression<Func<T, bool>> predicate, Expression<Func<T, V>> selector);
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes);

    }
}
