using FlagExplorer.Core.Common;
using FlagExplorer.Service.DTOs;
using FlagExplorer.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlagExplorer.Controller
{
    [ApiController]
    [Route("api/v1/city")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CityReadDto>>> GetAllCityListAsync([FromQuery] QueryOptions options)
        {
            var cityList = await _cityService.GetAllAsync(options);
            return Ok(cityList);
        }
    }
}
