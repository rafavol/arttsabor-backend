using ArttSabor.Domain.Entities;

namespace ArttSabor.Persistence.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<List<T>> Get();
    }
}