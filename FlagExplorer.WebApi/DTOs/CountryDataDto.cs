namespace FlagExplorer.WebAPI.DTOs
{
    public class CountryDataDto
    {
        public Dictionary<string, string>? name { get; set; }
        public Dictionary<string, string>? flags { get; set; }
        public int population { get; set; }
        public CapitalInfoDto? capitalInfo { get; set; }

    }
}
