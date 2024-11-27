using FlagExplorer.Core.Common;
using FlagExplorer.Core.Entities;
using FlagExplorer.Service.DTOs;

namespace FlagExplorer.Service.Interfaces
{
    public interface ICountryService : IReadOnlyBaseService<CountryReadDto, QueryOptions>
    {
        Task<CountryDetails> GetByNameAsync(string countryName);
    }
}
