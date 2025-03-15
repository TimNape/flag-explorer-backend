namespace FlagExplorer.Core.Entities
{
    public class City : BaseEntity
    {
        public string? Name { get; set; }
        public Guid? ProvinceId { get; set; }
        public int PostalCode { get; set; }
        public int? Population { get; set; }

    }
}
