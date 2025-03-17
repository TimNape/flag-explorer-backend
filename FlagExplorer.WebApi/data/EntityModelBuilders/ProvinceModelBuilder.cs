using FlagExplorer.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlagExplorer.WebAPI.Data.EntityModelBuilders
{
    public class ProvinceModelBuilder
    {

        private readonly ModelBuilder _modelBuilder;

        public ProvinceModelBuilder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
        public void Configure()
        {
            Configure(_modelBuilder);
        }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("tbProvince");
                entity.HasKey(x => x.Id).HasName("provinceKey_pkey");
                entity.Property(c => c.Name);
                entity.Property(c => c.Population);

            });
        }

    }
}
