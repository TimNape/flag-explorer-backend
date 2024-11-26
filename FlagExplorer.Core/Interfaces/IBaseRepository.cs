namespace FlagExplorer.Core.Interfaces
{
    public interface IBaseRepository<T, QueryOptions>: IReadOnlyBaseRepository<T, QueryOptions>
        where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T?> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid id);
    }
}
