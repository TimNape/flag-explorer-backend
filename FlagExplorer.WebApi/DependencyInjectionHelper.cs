using FlagExplorer.Core.Interfaces;
using FlagExplorer.Service.Interfaces;
using FlagExplorer.Service.Services;
using FlagExplorer.WebAPI.Repositories;
using HostInitActions;

namespace FlagExplorer.WebAPI
{
    public class DependencyInjectionHelper
    {
        public static void RegisterEntities(WebApplicationBuilder builder)
        {

            // Province
            builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
            builder.Services.AddScoped<IProvinceService, ProvinceService>();


            // City
            builder.Services.AddScoped<ICityRepository, CityRepository>();
            builder.Services.AddScoped<ICityService, CityService>();


            // Vehicle
            builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
            builder.Services.AddScoped<IVehicleService, VehicleService>();

        }
    }
}
