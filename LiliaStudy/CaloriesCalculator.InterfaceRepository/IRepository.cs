namespace CaloriesCalculator.Interface.Repository
{
    public interface IRepository<T>
    {
        int Create(T entity);
        void Update(int id, T entity);
        void Delete(params int[] id);
        T Get(int id);
        IEnumerable<T> GetAll();

    }
}
