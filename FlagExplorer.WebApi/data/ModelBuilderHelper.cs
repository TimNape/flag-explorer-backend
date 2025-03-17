using FlagExplorer.WebAPI.Data.EntityModelBuilders;
using Microsoft.EntityFrameworkCore;

namespace FlagExplorer.WebAPI.Data
{
    public class ModelBuilderHelper
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            CountryModelBuilder.Configure(modelBuilder);
            ProvinceModelBuilder.Configure(modelBuilder);
            CityModelBuilder.Configure(modelBuilder);
            VehicleModelBuilder.Configure(modelBuilder);

        }
    }
}
