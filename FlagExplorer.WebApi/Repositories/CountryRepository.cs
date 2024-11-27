using FlagExplorer.Core.Common;
using FlagExplorer.Core.Entities;
using FlagExplorer.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text;
using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FlagExplorer.WebAPI.DTOs;
using FlagExplorer.Service.DTOs; // Nuget Package

namespace FlagExplorer.WebAPI.Repositories
{
    public class CountryRepository : ICountryRepository
    {

        private List<Country> _countries = new List<Country>();
        private List<CountryDetails> _countryDetails = new List<CountryDetails>();

        public async Task InitAsync()
        {
            var url = "https://restcountries.com/v3.1/all";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    if (response != null)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var obj =  JsonConvert.DeserializeObject<object>(jsonString);
                    }
                }
            }
            catch (Exception ex)
            {
                InitFromFile();
            }
        }

        private void InitFromFile()
        {
            try
            {
                using (StreamReader r = new StreamReader("Data/countryData.json"))
                {
                    string json = r.ReadToEnd();
                    InitFromJson(json);
                }
            }
            catch
            {
                Console.WriteLine("Failed to initialize Country Data from file");
            }
  
        }

        private void InitFromJson(string countryData)
        {

            var anonymousType = new[] { new
                {
                    name = new { common = "" },
                    flags = new {png = "", svg = ""},
                    capitalInfo = new {latlng = new string[2]},
                    population = 0
                }};


            this._countries = new List<Country>();
            this._countryDetails = new List<CountryDetails>();

            var countries = JsonConvert.DeserializeAnonymousType(countryData, anonymousType);
            foreach(var country in countries)
            {
                this._countries.Add(new Country
                {
                    Name = country.name.common,
                    Flag = country.flags.svg
                });

                this._countryDetails.Add(new CountryDetails
                {
                    CountryName = country.name.common,
                    Population = country.population,
                    Capital = country.capitalInfo.latlng != null ? $"{country.capitalInfo.latlng[0]},{country.capitalInfo.latlng[1]}" : null
                });
            }
        }
      
        public async Task<PaginatedResult<Country>> GetAllAsync(QueryOptions options)
        {
            var totalCount = this._countries.Count;
            var countries =  this._countries;
            return new PaginatedResult<Country>(countries, totalCount);
        }

        public async Task<Country> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<CountryDetails> GetByNameAsync(string countryName)
        {
            return _countryDetails.FirstOrDefault(x => string.Equals(countryName, x.CountryName, StringComparison.OrdinalIgnoreCase));
        }
        public Task<bool> ExistsAsync(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
