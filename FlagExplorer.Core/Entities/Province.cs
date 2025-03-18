namespace FlagExplorer.Core.Entities
{
    public class Province : BaseEntity
    {
        public virtual string? Name { get; set; }
        public virtual Guid? CountryId { get; set; }
        public virtual string? ShortName { get; set; }
        public virtual int? Population { get; set; }
        public virtual decimal? GDP { get; set; }

        public virtual Country? Country { get; set; }

        public virtual List<City>? Cities { get; set; } = new();

    }
}
