using FootballSeasonBuilder.Enums;

namespace FootballSeasonBuilder.Models
{
    public class Stadium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Climate { get; set; }
        public string? City { get; set; }
        public string? StateOrCountry { get; set; }
    }
}
