namespace FootballSeasonBuilder.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }
        public string Position { get; set; }
        public int NumTries { get; set; }
        public int NumGoals { get; set; }
        public int NumFieldGoals { get; set; }
        public int MatchesPlayed { get; set; }
    }
}
