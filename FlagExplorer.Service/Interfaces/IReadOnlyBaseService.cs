using FlagExplorer.Core.Common;

namespace FlagExplorer.Service.Interfaces
{
    public interface IReadOnlyBaseService<TReadDTO, QueryOptions>
    {
        Task<PaginatedResult<TReadDTO>> GetAllAsync(QueryOptions options);
        Task<TReadDTO> GetOneByIdAsync(Guid id);
    }
}
