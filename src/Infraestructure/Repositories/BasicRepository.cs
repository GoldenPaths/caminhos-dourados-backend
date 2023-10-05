using GoldenPaths.Domain.Interfaces.Repositories;
using GoldenPaths.Infraestructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace GoldenPaths.Infraestructure.Repositories
{
    internal abstract class BasicRepository<T, TKey> : IBasicRepository<T, TKey> where T : class
    {

        protected readonly GPContext _context;

        protected BasicRepository(GPContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(TKey id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
