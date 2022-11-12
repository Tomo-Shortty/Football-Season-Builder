namespace FootballSeasonBuilder.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Round { get; set; }
        public string League { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int HomeStrengthRank { get; set; }
        public int AwayStrengthRank { get; set; }
        public string Stadium { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set;}
        public int TotalScoringOpportunities { get; set; }
        public int HomeTeamTries { get; set; }
        public int AwayTeamTries { get; set; }
        public int HomeTeamFieldGoals { get; set; }
        public int AwayTeamFieldGoals { get; set; }
        public int HomeTeamConversions { get; set; }
        public int AwayTeamConversions { get; set; }
        public int HomeTeamPenalties { get; set; }
        public int AwayTeamPenalties { get; set; }
    }
}
