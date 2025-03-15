using AutoMapper;
using FlagExplorer.Core.Common;
using FlagExplorer.Core.Entities;
using FlagExplorer.Core.Interfaces;
using FlagExplorer.Service.DTOs;
using FlagExplorer.Service.Interfaces;
using FlagExplorer.Service.Services.Common;

namespace FlagExplorer.Service.Services
{
    public class VehicleService: ReadOnlyBaseService<Vehicle, VehicleReadDto, QueryOptions>, IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleService(IVehicleRepository vehicleRepository, IMapper mapper) : base(vehicleRepository, mapper){
            _vehicleRepository = vehicleRepository;
        }
    }
}
