using AutoMapper;
using FlagExplorer.Core.Common;
using FlagExplorer.Core.Entities;
using FlagExplorer.Core.Interfaces;
using FlagExplorer.Service.DTOs;
using FlagExplorer.Service.Interfaces;
using FlagExplorer.Service.Services.Common;

namespace FlagExplorer.Service.Services
{
    public class CountryService: ReadOnlyBaseService<Country, CountryReadDto, QueryOptions>, ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        public CountryService(ICountryRepository countryRepository, IMapper mapper) : base(countryRepository, mapper){
            _countryRepository = countryRepository;
        }
        public Task<IEnumerable<CountryReadDto>> GetByNameAsync(string countryName)
        {
            throw new NotImplementedException();
        }
    }
}
