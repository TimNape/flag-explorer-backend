namespace FlagExplorer.Service.DTOs
{
    public class CityReadDto
    {
        public virtual string? Name { get; set; }
        public virtual Guid? ProvinceId { get; set; }
        public virtual int PostalCode { get; set; }
        public virtual int? Population { get; set; }
        public virtual ProvinceReadDto? Province { get; set; }

    }
}
