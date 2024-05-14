namespace Pruebas.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int? HomeTeamId { get; set; }
        public Team? HomeTeam { get; set; }
        public int? AwayTeamId { get; set; }
        public Team? AwayTeam { get; set; }
        public int? HomeGoals { get; set; }
        public int? AwayGoals { get; set; }
        public DateTime? Date { get; set; }
        public string? Status { get; set; }
        public int? LeagueId { get; set; }
        public League? League { get; set; }

        public Match() { }

        public Match(int id, int homeTeamId, int awayTeamId, int homeGoals, int awayGoals, DateTime date, string status, int leagueId)
        {
            Id = id;
            HomeTeamId = homeTeamId;
            AwayTeamId = awayTeamId;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
            Date = date;
            Status = status;
            LeagueId = leagueId;
        }
    }
}
