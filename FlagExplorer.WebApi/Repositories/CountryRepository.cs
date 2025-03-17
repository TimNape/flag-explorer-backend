using FlagExplorer.Core.Entities;
using FlagExplorer.Core.Interfaces;
using FlagExplorer.WebAPI.Data;
using FlagExplorer.WebAPI.Repositories.Shared;

namespace FlagExplorer.WebAPI.Repositories
{
    public class CountryRepository(AppDbContext context)
        : GenericRepository<Country>(context, context.CountryCtx), ICountryRepository
    {
    }
}
