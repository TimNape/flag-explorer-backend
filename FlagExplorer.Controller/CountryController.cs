using FlagExplorer.Core.Common;
using FlagExplorer.Service.DTOs;
using FlagExplorer.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlagExplorer.Controller
{
    [ApiController]
    [Route("api/v1/countries")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CountryReadDto>>> GetAllCountriesAsync([FromQuery] QueryOptions options)
        {
            var countries = await _countryService.GetAllAsync(options);
            return Ok(countries);
        }

        [HttpGet("{countryName}")]
        [AllowAnonymous]
        [ActionName(nameof(GetCountriesByNameAsync))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<CountryDetailsReadDto>>> GetCountriesByNameAsync([FromRoute] string countryName)
        {
            var countryDetails = await _countryService.GetByNameAsync(countryName);
            return Ok(new CountryDetailsReadDto(countryDetails));
        }
    }
}
