using AutoMapper;
using FlagExplorer.Core.Common;
using FlagExplorer.Core.Entities;
using FlagExplorer.Core.Interfaces;
using FlagExplorer.Service.Interfaces;

namespace FlagExplorer.Service.Services.Common
{
    public class ReadOnlyBaseService<TEntity, TReadDTO, QueryOptions>: IReadOnlyBaseService<TReadDTO, QueryOptions>
       where TEntity : BaseEntity, new()
    {
        protected readonly IReadOnlyBaseRepository<TEntity, QueryOptions> _repository;
        protected readonly IMapper _mapper;
        public ReadOnlyBaseService(IReadOnlyBaseRepository<TEntity, QueryOptions> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public virtual async Task<PaginatedResult<TReadDTO>> GetAllAsync(QueryOptions options)
        {
            var paginatedResult = await _repository.GetAllAsync(options);
            var mappedItems = _mapper.Map<IEnumerable<TReadDTO>>(paginatedResult!.Items);
            return new PaginatedResult<TReadDTO>(mappedItems, paginatedResult.TotalCount);
        }
        public virtual async Task<TReadDTO> GetOneByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id) ?? throw AppException.NotFound();
            return _mapper.Map<TReadDTO>(entity);
        }
    }
}
