namespace FlagExplorer.Core.Entities
{
    public class Country : BaseEntity
    {
        public virtual string? Name { get; set; }
        public virtual string? Flag { get; set; }


        public virtual List<Province>? Provinces { get; set; } = new();

    }
}
