namespace FlagExplorer.Service.DTOs
{
    public class CountryDetailsReadDto
    {
        public Guid Id { get; set; }
        public int Population { get; set; }
        public string? CapitalCity { get; set; }
    }
}
