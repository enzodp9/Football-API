using Pruebas.Models;

namespace Pruebas.Services.DTOs
{
    public class GoalscorerDTO
    {
        public string? Time { get; set; }
        public string? Home_Scorer { get; set; }
        public string? Home_Scorer_Id { get; set; }
        public string? Home_Assist { get; set; }
        public string? Home_Assist_Id { get; set; }
        public string? Score { get; set; }
        public string? Away_Scorer { get; set; }
        public string? Away_Scorer_Id { get; set; }
        public string? Away_Assist { get; set; }
        public string? Away_Assist_Id { get; set; }
        public string? Info { get; set;}
        public string? Score_Info_Time { get; set; }
    }

    public class CardDTO
    {
        public string? Time { get; set; }
        public string? Home_Fault { get; set; }
        public string? Card { get; set; }
        public string? Away_Fault { get; set; }
        public string? Home_Player_Id { get; set; }
        public string? Away_Player_Id { get; set; }
        public string? Score_Info_Time { get; set; }
    }

    public class SubstitutionsDTO
    {
        public List<SubstitutionDTO>? Home { get; set; }
        public List<SubstitutionDTO>? Away { get; set; }
    }

    public class SubstitutionDTO
    {
        public string? Time { get; set; }
        public string? Substitution { get; set; }
        public string? Substitution_Player_Id { get; set; }
    }

    public class LineupDTO
    {
        public List<LineupTeamDTO>? Home { get; set; }
        public List<LineupTeamDTO>? Away { get; set; }
    }
    public class LineupTeamDTO
    {
        public List<LineupPlayerDTO>? Starting_Lineups { get; set; }
        public List<LineupPlayerDTO>? Substitutes { get; set; }
        public List<LineupPlayerDTO>? Coach { get; set; }
        public List<LineupPlayerDTO>? Missing_Players { get; set; }
    }

    public class LineupPlayerDTO
    {
        public string? Lineup_Player { get; set; }
        public string? Lineup_Number { get; set; }
        public string? Lineup_Position { get; set; }
        public string? Player_Key { get; set; }
    }

    public class StatisticDTO
    {
        public string? Type { get; set; }
        public string? Home { get; set; }
        public string? Away { get; set; }
    }

    public class MatchDTO
    {
        public string? Match_Id { get; set; }
        public string? Country_Id { get; set; }
        public string? Country_Name { get; set; }
        public string? League_Id { get; set; }
        public string? League_Name { get; set; }
        public string? Match_Date { get; set; }
        public string? Match_Status { get; set; }
        public string? Match_Time { get; set; }
        public string? Match_Hometeam_Id { get; set; }
        public string? Match_Hometeam_Name { get; set; }
        public string? Match_Hometeam_Score { get; set; }
        public string? Match_Awayteam_Name { get; set; }
        public string? Match_Awayteam_Id { get; set; }
        public string? Match_Awayteam_Score { get; set; }
        public string? Match_Hometeam_Halftime_Score { get; set; }
        public string? Match_Awayteam_Halftime_Score { get; set; }
        public string? Match_Hometeam_Extra_Score { get; set; }
        public string? Match_Awayteam_Extra_Score { get; set; }
        public string? Match_Hometeam_Penalty_Score { get; set; }
        public string? Match_Awayteam_Penalty_Score { get; set; }
        public string? Match_Hometeam_Ft_Score { get; set; }
        public string? Match_Awayteam_Ft_Score { get; set; }
        public string? Match_Hometeam_System { get; set; }
        public string? Match_Awayteam_System { get; set; }
        public string? Match_Live { get; set; }
        public string? Match_Round { get; set; }
        public string? Match_Stadium { get; set; }
        public string? Match_Referee { get; set; }
        public string? Team_Home_Badge { get; set; }
        public string? Team_Away_Badge { get; set; }
        public string? League_Logo { get; set; }
        public string? Country_Logo { get; set; }
        public string? League_Year { get; set; }
        public string? Fk_Stage_Key { get; set; }
        public string? Stage_Name { get; set; }
        public List<GoalscorerDTO>? Goalscorer { get; set; }
        public List<CardDTO>? Cards { get; set; }
        public SubstitutionsDTO? Substitutions { get; set; }
        public LineupDTO? Lineup { get; set; }
        public List<StatisticDTO>? Statistics { get; set; }
        public List<StatisticDTO>? Statistics_1Half { get; set; }
    }
}
