using FlagExplorer.Core.Common;
using FlagExplorer.Core.Interfaces;
using FlagExplorer.WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace FlagExplorer.WebAPI.Repositories.Shared
{

    public class GenericRepository<T> : IBaseRepository<T, QueryOptions> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _entities;

        public GenericRepository(AppDbContext context, DbSet<T> entities)
        {
            _context = context;
            _entities = entities;
        }
        public virtual async Task<PaginatedResult<T>> GetAllAsync(QueryOptions options)
        {
            IQueryable<T> query = _entities;
            var totalCount = await query.CountAsync();
            query = query.Skip((options.Page - 1) * options.PageSize).Take(options.PageSize);
            var results = await query.ToListAsync();
            return new(results, totalCount);
        }
        public virtual async Task<T> CreateAsync(T entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _entities.FindAsync(id) ?? throw AppException.NotFound();
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _entities.FindAsync(id);
            if (entity == null)
                return false;
            _entities.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
        public virtual Task<bool> ExistsAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual Task<T?> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
