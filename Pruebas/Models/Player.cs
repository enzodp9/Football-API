namespace Pruebas.Models
{
    public class Player
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public int? Number { get; set; }
        public int? Age { get; set; }
        public string? Position { get; set; }
        public int? TeamId { get; set; }
        public Team? Team { get; set; }
        public int? CountryId { get; set; }
        public Country? Country { get; set; }

        public Player() { }
        public Player(int id, string name, string image, int number, int age, string position, int teamId, int countryId)
        {
            Id = id;
            Name = name;
            Image = image;
            Number = number;
            Age = age;
            Position = position;
            TeamId = teamId;
            CountryId = countryId;
        }

    }
}
