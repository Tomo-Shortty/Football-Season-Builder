namespace FootballSeasonBuilder.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TeamModel Team { get; set; }
        public string Position { get; set; }
        public int NumTries { get; set; }
        public int NumGoals { get; set; }
        public int NumFieldGoals { get; set; }
    }
}
