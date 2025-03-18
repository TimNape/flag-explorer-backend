using FlagExplorer.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlagExplorer.WebAPI.Data.EntityModelBuilders
{
    public class CityModelBuilder
    {

        private readonly ModelBuilder _modelBuilder;

        public CityModelBuilder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
        public void Configure()
        {
            Configure(_modelBuilder);
        }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("tbCity");
                entity.HasKey(x => x.Id).HasName("cityKey_pkey");
                entity.Property(c => c.Name);
                entity.Property(c => c.ProvinceId);
                entity.Property(c => c.PostalCode);
                entity.Property(c => c.Population);

            });

            modelBuilder.Entity<City>()
            .HasOne(_ => _.Province)
            .WithMany(_ => _.Cities)
            .HasForeignKey(_ => _.ProvinceId);

        }

    }
}
