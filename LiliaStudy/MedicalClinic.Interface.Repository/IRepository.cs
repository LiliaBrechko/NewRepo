using System.Security.Principal;
using MedicalClinic.Models;

namespace MedicalClinic.Interface.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        int Create(T entity);
        void Update(int id, T entity);
        void Delete(params int[] id);
        T Get(int id);
        IEnumerable<T> GetAll();

    }
}
