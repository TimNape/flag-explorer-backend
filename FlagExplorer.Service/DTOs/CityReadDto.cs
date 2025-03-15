namespace FlagExplorer.Service.DTOs
{
    public class CityReadDto
    {
        public string? Name { get; set; }
        public Guid? StateId { get; set; }
        public int PostalCode { get; set; }
        public int? PopulationDensity { get; set; }

    }
}
