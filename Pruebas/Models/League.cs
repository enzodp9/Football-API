namespace Pruebas.Models
{
    public class League
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Logo { get; set; }
        public int CountryId { get; set; }
        public Country? Country { get; set; }
        public Team[]? Teams { get; set; }

        public League() { }

        public League(int id, string name, string logo, int countryid)
        {
            Id = id;
            Name = name;
            Logo = logo;
            CountryId = countryid;
        }
    }
}
