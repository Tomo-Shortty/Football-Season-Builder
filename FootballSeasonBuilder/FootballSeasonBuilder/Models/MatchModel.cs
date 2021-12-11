namespace FootballSeasonBuilder.Models
{
    public class MatchModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoundModel Round { get; set; }
        public TeamModel HomeTeam { get; set; }
        public TeamModel AwayTeam { get; set; }
        public int HomeTeamPoints { get; set; }
        public int AwayTeamPoints { get; set;}
        public int NumTeamTries { get; set; }
        public int NumTeamGoals { get; set; }
    }
}
