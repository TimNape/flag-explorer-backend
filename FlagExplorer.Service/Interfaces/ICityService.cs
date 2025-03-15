using FlagExplorer.Core.Common;
using FlagExplorer.Service.DTOs;

namespace FlagExplorer.Service.Interfaces
{
    public interface ICityService : IReadOnlyBaseService<CityReadDto, QueryOptions>
    {
    }
}
