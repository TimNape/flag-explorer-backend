using AutoMapper;
using FlagExplorer.Core.Common;
using FlagExplorer.Core.Entities;
using FlagExplorer.Core.Interfaces;
using FlagExplorer.Service.DTOs;
using FlagExplorer.Service.Interfaces;
using FlagExplorer.Service.Services.Common;

namespace FlagExplorer.Service.Services
{
    public class CityService: ReadOnlyBaseService<City, CityReadDto, QueryOptions>, ICityService
    {
        private readonly ICityRepository _cityRepository;
        public CityService(ICityRepository cityRepository, IMapper mapper) : base(cityRepository, mapper){
            _cityRepository = cityRepository;
        }
    }
}
