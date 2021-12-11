namespace FootballSeasonBuilder.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Round Round { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public int HomeTeamPoints { get; set; }
        public int AwayTeamPoints { get; set;}
        public int NumTeamTries { get; set; }
        public int NumTeamGoals { get; set; }
        public int NumTeamFieldGoals { get; set; }
        public bool IsDraw { get; set; }
        public string? MatchWinner { get; set; }
    }
}
