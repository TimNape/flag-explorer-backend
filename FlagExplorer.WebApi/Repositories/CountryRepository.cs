using FlagExplorer.Core.Common;
using FlagExplorer.Core.Entities;
using FlagExplorer.Core.Interfaces;

namespace FlagExplorer.WebAPI.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        public async Task<PaginatedResult<Country>> GetAllAsync(QueryOptions options)
        {
            var totalCount = 10;
            var countries = new List<Country>
            {
                new Country {Title = "South Africa"},
                new Country {Title = "Botswana"},

            };
            return new PaginatedResult<Country>(countries, totalCount);
        }

        public async Task<Country> GetByIdAsync(Guid id)
        {
            return new Country { Title = "South Africa" };
        }

        public async Task<IEnumerable<Country>> GetByNameAsync(string countryName)
        {
            var countries = new List<Country>
            {
                new Country {Title = "South Africa"},
                new Country {Title = "Botswana"},

            };

            return countries;
        }
        public Task<bool> ExistsAsync(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
