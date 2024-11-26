using FlagExplorer.Core.Common;

namespace FlagExplorer.Core.Interfaces
{
    public interface IReadOnlyBaseRepository<T, QueryOptions> where T : class
    {
        Task<PaginatedResult<T>> GetAllAsync(QueryOptions options);
        Task<T> GetByIdAsync(Guid id);
        Task<bool> ExistsAsync(T entity);
    }
}
