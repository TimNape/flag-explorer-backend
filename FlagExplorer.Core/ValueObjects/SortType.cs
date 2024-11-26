using System.Text.Json.Serialization;

namespace FlagExplorer.Core.ValueObjects
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortType
    {
        byName
    }
}
