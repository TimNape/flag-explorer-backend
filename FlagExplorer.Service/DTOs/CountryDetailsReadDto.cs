using FlagExplorer.Core.Entities;

namespace FlagExplorer.Service.DTOs
{
    public class CountryDetailsReadDto
    {
        public CountryDetailsReadDto() { }

        public CountryDetailsReadDto(CountryDetails countryDetails)
        {
            Population= countryDetails.Population;
            Capital = countryDetails.Capital;
        }

        public int Population { get; set; }
        public string? Capital { get; set; }
    }
}
