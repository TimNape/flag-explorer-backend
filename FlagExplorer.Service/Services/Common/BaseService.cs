using AutoMapper;
using FlagExplorer.Core.Common;
using FlagExplorer.Core.Entities;
using FlagExplorer.Core.Interfaces;
using FlagExplorer.Service.Interfaces;

namespace FlagExplorer.Service.Services.Common
{
    public class BaseService<TEntity, TReadDTO, TCreateDTO, TUpdateDTO, QueryOptions> : ReadOnlyBaseService<TEntity, TReadDTO, QueryOptions>, IBaseService<TReadDTO, TCreateDTO, TUpdateDTO, QueryOptions>
     where TEntity : BaseEntity, new()
    {
        protected new readonly IBaseRepository<TEntity, QueryOptions> _repository;

        public BaseService(IBaseRepository<TEntity, QueryOptions> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        public virtual async Task<TReadDTO> CreateOneAsync(TCreateDTO createDto)
        {
            var entity = _mapper.Map<TEntity>(createDto);
            if (await _repository.ExistsAsync(entity))
            {
                throw AppException.DuplicateException();
            }
            entity = await _repository.CreateAsync(entity);
            return _mapper.Map<TReadDTO>(entity);
        }

        public virtual async Task<bool> DeleteOneAsync(Guid id)
        {
            if (!await _repository.DeleteAsync(id))
            {
                return false;
                throw AppException.NotFound();
            }
            return true;
        }

        public virtual async Task<TReadDTO> UpdateOneAsync(Guid id, TUpdateDTO updateDto)
        {
            var existingEntity = await _repository.GetByIdAsync(id) ?? throw AppException.NotFound();
            var updatedEntity = _mapper.Map(updateDto, existingEntity);
            foreach (var property in updateDto!.GetType().GetProperties())
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(updateDto);
                var entityProperty = updateDto.GetType().GetProperty(propertyName);
                if (entityProperty != null && entityProperty.CanWrite)
                {
                    entityProperty.SetValue(updateDto, propertyValue);
                }
            }
            var result = await _repository.UpdateAsync(updatedEntity);
            return _mapper.Map<TReadDTO>(result);
        }
    }
}
