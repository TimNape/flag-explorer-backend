using FlagExplorer.Core.Common;
using FlagExplorer.Service.DTOs;
using FlagExplorer.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlagExplorer.Controller
{
    [ApiController]
    [Route("api/v1/province")]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceService _provinceService;

        public ProvinceController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }

        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProvinceReadDto>>> GetAllProvinceListAsync([FromQuery] QueryOptions options)
        {
            var provinceList = await _provinceService.GetAllAsync(options);
            return Ok(provinceList);
        }
    }
}
