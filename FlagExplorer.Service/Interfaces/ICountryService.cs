using FlagExplorer.Core.Common;
using FlagExplorer.Service.DTOs;

namespace FlagExplorer.Service.Interfaces
{
    public interface ICountryService : IReadOnlyBaseService<CountryReadDto, QueryOptions>
    {
    }
}
