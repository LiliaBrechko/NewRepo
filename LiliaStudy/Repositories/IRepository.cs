namespace Repositories
{
    public interface IRepository<T>
    {
        int Create(T entity);
        void Update(int id, T entity);
        void Delete(params int[] ids);
       
        T Get(int id);
        IEnumerable<T> GetAll();

    }
}
