using AutoMapper;
using FlagExplorer.Core.Entities;
using FlagExplorer.Service.DTOs;

namespace FlagExplorer.Service.Shared
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Country, CountryReadDto>();
            CreateMap<CountryDetails, CountryDetailsReadDto>();

            AutoMapperHelper.MapDtos(this);
        }
    }
}
