namespace FlagExplorer.Core.Entities
{
    public class CountryDetails : BaseEntity
    {
        public string? CountryName { get; set; }
        public string? Capital { get; set; }
        public int Population { get; set; }
    }
}
