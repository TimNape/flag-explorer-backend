namespace FlagExplorer.Service.DTOs
{
    public class ProvinceReadDto
    {
        public virtual string? Name { get; set; }
        public virtual Guid? CountryId { get; set; }
        public virtual int? Population { get; set; }
        public virtual CountryReadDto? Country { get; set; }

        public virtual List<CityReadDto>? Cities { get; set; } = new();

    }
}
