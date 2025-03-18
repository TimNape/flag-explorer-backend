namespace FlagExplorer.Service.DTOs
{
    public class CountryReadDto
    {
        public virtual string? Name { get; set; }
        public virtual string? Flag { get; set; }

        public virtual List<ProvinceReadDto>? Provinces { get; set; } = new();

    }
}
