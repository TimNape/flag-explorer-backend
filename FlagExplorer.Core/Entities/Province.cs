namespace FlagExplorer.Core.Entities
{
    public class Province : BaseEntity
    {
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public int? Population { get; set; }
        public decimal? GDP { get; set; }

    }
}
