namespace FootballSeasonBuilder.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string League { get; set; }
        public int NumberOfRounds { get; set; }
        public int FinalRegularSeasonRound { get; set; }
    }
}
