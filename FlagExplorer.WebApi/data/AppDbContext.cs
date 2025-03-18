using FlagExplorer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FlagExplorer.WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _config;
        #region DbSet
        public DbSet<Country> CountryCtx { get; set; } = null!;
        public DbSet<Province> ProvinceCtx { get; set; } = null!;
        public DbSet<City> CityCtx { get; set; } = null!;

        #endregion

        #region constructors
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration config) : base(options)
        {
            _config = config;
            ChangeTracker.LazyLoadingEnabled = true;
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(System.AppContext.BaseDirectory)
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _config = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
            optionsBuilder.UseSqlServer(_config.GetConnectionString("Dev"), m => { m.EnableRetryOnFailure(); });

            OnConfiguring(optionsBuilder);

        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            ModelBuilderHelper.Configure(modelBuilder);
        }


    }
}
