using FlagExplorer.Core.Common;
using FlagExplorer.Core.Entities;

namespace FlagExplorer.Core.Interfaces
{
    public interface IVehicleRepository : IReadOnlyBaseRepository<Vehicle, QueryOptions>
    {
    }
}
