using FlagExplorer.Core.Entities;
using FlagExplorer.Core.Interfaces;
using FlagExplorer.WebAPI.Data;
using FlagExplorer.WebAPI.Repositories.Shared;

namespace FlagExplorer.WebAPI.Repositories
{
    public class CityRepository(AppDbContext context)
        : GenericRepository<City>(context, context.CityCtx), ICityRepository
    {
    }
}
