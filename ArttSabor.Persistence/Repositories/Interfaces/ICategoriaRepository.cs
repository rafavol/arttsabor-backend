using ArttSabor.Domain.Entities;

namespace ArttSabor.Persistence.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> Get();
    }
}