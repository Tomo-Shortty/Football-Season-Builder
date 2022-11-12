namespace FootballSeasonBuilder.Models
{
    public class Standings
    {
        public int Id { get; set; }
        public string Team { get; set; }
        public string Season { get; set; }
        public string League { get; set; }
        public int LeagueStanding { get; set; }
        public string? Conference { get; set; }
        public int ConferenceStanding { get; set; }
        public string? Division { get; set; }
        public int DivisionStanding { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public string? HomeRecord { get; set; }
        public int HomeWins { get; set; }
        public int HomeLosses { get; set; }
        public int HomeTies { get; set; }
        public string? AwayRecord { get; set; }
        public int AwayWins { get; set; }
        public int AwayLosses { get; set; }
        public int AwayTies { get; set; }
        public int TotalPointsFor { get; set; }
        public int TotalPointsAgainst { get; set; }
        public int NetPoints { get; set; }
    }
}
