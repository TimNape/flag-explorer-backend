using FlagExplorer.Core.Common;
using FlagExplorer.Service.DTOs;
using FlagExplorer.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlagExplorer.Controller
{
    [ApiController]
    [Route("api/v1/vehicle")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<VehicleReadDto>>> GetAllVehicleListAsync([FromQuery] QueryOptions options)
        {
            var vehicleList = await _vehicleService.GetAllAsync(options);
            return Ok(vehicleList);
        }
    }
}
