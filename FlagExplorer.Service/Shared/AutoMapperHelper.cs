using AutoMapper;
using FlagExplorer.Core.Entities;
using FlagExplorer.Service.DTOs;

namespace FlagExplorer.Service.Shared
{
    internal class AutoMapperHelper
    {
        public static void MapDtos(Profile profile)
        {
            profile.CreateMap<Country, CountryReadDto>();
            profile.CreateMap<Province, ProvinceReadDto>();
            profile.CreateMap<City, CityReadDto>();

        }
    }


}
