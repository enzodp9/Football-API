namespace Pruebas.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Logo { get; set; }
        public League[]? Leagues { get; set; }
        public Team[]? Teams { get; set; }
        public Player[]? Players { get; set; }

        public Country() { }

        public Country(int id, string name, string logo)
        {
            Id = id;
            Name = name;
            Logo = logo;
        }
    }

}
