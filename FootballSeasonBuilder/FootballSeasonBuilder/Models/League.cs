using FootballSeasonBuilder.Enums;

namespace FootballSeasonBuilder.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string LeagueType { get; set; }
        public int NumberOfConferences { get; set; }
        public int NumberOfDivisions { get; set; }
    }
}
