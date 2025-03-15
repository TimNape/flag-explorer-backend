using AutoMapper;
using FlagExplorer.Core.Common;
using FlagExplorer.Core.Entities;
using FlagExplorer.Core.Interfaces;
using FlagExplorer.Service.DTOs;
using FlagExplorer.Service.Interfaces;
using FlagExplorer.Service.Services.Common;

namespace FlagExplorer.Service.Services
{
    public class ProvinceService: ReadOnlyBaseService<Province, ProvinceReadDto, QueryOptions>, IProvinceService
    {
        private readonly IProvinceRepository _provinceRepository;
        public ProvinceService(IProvinceRepository provinceRepository, IMapper mapper) : base(provinceRepository, mapper){
            _provinceRepository = provinceRepository;
        }
    }
}
