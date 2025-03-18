using FlagExplorer.Core.Interfaces;
using FlagExplorer.Service.Interfaces;
using FlagExplorer.Service.Services;
using FlagExplorer.WebAPI.Repositories;

namespace FlagExplorer.WebAPI
{
    public class DependencyInjectionHelper
    {
        public static void RegisterEntities(WebApplicationBuilder builder)
        {

            // Country
            builder.Services.AddScoped<ICountryRepository, CountryRepository>();
            builder.Services.AddScoped<ICountryService, CountryService>();


            // Province
            builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
            builder.Services.AddScoped<IProvinceService, ProvinceService>();


            // City
            builder.Services.AddScoped<ICityRepository, CityRepository>();
            builder.Services.AddScoped<ICityService, CityService>();

        }
    }
}
