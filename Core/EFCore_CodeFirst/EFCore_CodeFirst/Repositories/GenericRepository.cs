
using EFCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_CodeFirst.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //context object
        private readonly EFCoreCodeContext _context;
        //dbset object
        private readonly DbSet<T> _dbSet;

        //initialize the context and dbset objects
        public GenericRepository(EFCoreCodeContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task DeleteAsync(object id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task InsertAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
