using FootballSeasonBuilder.Enums;

namespace FootballSeasonBuilder.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LeagueName { get; set; }
        public string? ConferenceName { get; set; }
        public string? DivisionName { get; set; }
        public int BaseStrengthRank { get; set; }
        public string PreferredClimate { get; set; }
        public string? PrimaryColour { get; set; }
        public string? SecondColour { get; set;}
        public string? ThirdColour { get; set;}
        public string? FourthColour { get; set;}
        public string? Stadium { get; set; }
        public int Championships { get; set; }
        public int Premierships { get; set; }
        public int RunnerUps { get; set; }
        public int Playoffs { get; set; }
        public int WoodenSpoons { get; set; }
    }
}
