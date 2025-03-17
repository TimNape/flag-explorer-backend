using FlagExplorer.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlagExplorer.WebAPI.Data.EntityModelBuilders
{
    public class VehicleModelBuilder
    {

        private readonly ModelBuilder _modelBuilder;

        public VehicleModelBuilder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
        public void Configure()
        {
            Configure(_modelBuilder);
        }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("tbVehicle");
                entity.HasKey(x => x.Id).HasName("vehicleKey_pkey");
                entity.Property(c => c.Model);
                entity.Property(c => c.Alias);

            });
        }

    }
}
