using CaloriesCalculator.Models;

namespace CaloriesCalculator.Interface.Repository
{
    public interface IEntityRepository<T> where T : IEntity
    {
        int Create(T entity);
        void Update(int id, T entity);
        void Delete(params int[] id);
        T Get(int id);
        IEnumerable<T> GetAll();

    }
}
