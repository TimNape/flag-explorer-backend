namespace FlagExplorer.Service.Interfaces
{
    public interface IBaseService<TReadDTO, TCreateDTO, TUpdateDTO, QueryOptions> : IReadOnlyBaseService<TReadDTO, QueryOptions>
    {
        Task<TReadDTO> CreateOneAsync(TCreateDTO createDto);
        Task<TReadDTO> UpdateOneAsync(Guid id, TUpdateDTO updateDto);
        Task<bool> DeleteOneAsync(Guid id);
    }
}
