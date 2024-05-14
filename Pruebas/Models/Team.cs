namespace Pruebas.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Founded { get; set; }
        public string? Logo { get; set; }
        public string? Stadium { get; set; }
        public string? Coach { get; set; }
        public int? CountryId { get; set; }
        public Country? Country { get; set; }
        public League[]? Leagues { get; set; }

        public Team() { }

        public Team(int id, string name, int countryId, int founded, string logo, string stadium, string coach)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
            Founded = founded;
            Logo = logo;
            Stadium = stadium;
            Coach = coach;
        }
    }
}
