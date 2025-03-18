namespace FlagExplorer.Core.Entities
{
    public class City : BaseEntity
    {
        public virtual string? Name { get; set; }
        public virtual Guid? ProvinceId { get; set; }
        public virtual int PostalCode { get; set; }
        public virtual int? Population { get; set; }

        public virtual Province? Province { get; set; }


    }
}
