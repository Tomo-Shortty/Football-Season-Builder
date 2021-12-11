namespace FootballSeasonBuilder.Models
{
    public class RoundModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LeagueModel League { get; set; }
    }
}
