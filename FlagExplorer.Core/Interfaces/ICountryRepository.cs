using FlagExplorer.Core.Common;
using FlagExplorer.Core.Entities;

namespace FlagExplorer.Core.Interfaces
{
    public interface ICountryRepository : IReadOnlyBaseRepository<Country, QueryOptions>
    {
        Task<CountryDetails> GetByNameAsync(string countryName);
        Task InitAsync();
    }
}
