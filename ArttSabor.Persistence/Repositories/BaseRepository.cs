using ArttSabor.Domain.Entities;
using ArttSabor.Infrastructure.Context;
using ArttSabor.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArttSabor.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationContext _context;

        public BaseRepository()
        {

        }

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
        }
        public virtual async Task<List<T>> Get()
        {
            return await _context.Set<T>()
                                 .AsNoTracking()
                                 .ToListAsync();
        }
    }
}
