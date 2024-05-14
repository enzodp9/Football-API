namespace Pruebas.Services.DTOs
{
    public class VenueDTO
    {
        public string? Venue_name { get; set; }
        public string? Venue_address { get; set; }
        public string? Venue_city { get; set; }
        public string? Venue_capacity { get; set; }
        public string? Venue_surface { get; set; }
    }
    public class CoachDTO
    {
        public string? Coach_name { get; set; }
        public string? Coach_country { get; set; }
        public string? Coach_age { get; set; }
    }
    public class TeamDTO
    {
        public string? Team_key { get; set; }
        public string? Team_name { get; set; }
        public string? Team_country { get; set; }
        public string? Team_founded { get; set; }
        public string? Team_badge { get; set; }
        public VenueDTO? Venue { get; set; }
        public PlayerDTO[]? Players { get; set; }
        public CoachDTO? Coach { get; set; }
    }
}
