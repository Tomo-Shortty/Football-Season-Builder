using System.ComponentModel.DataAnnotations;

namespace FootballSeasonBuilder.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Number of Teams")]
        public int NumTeams { get; set; }

        [Display(Name = "Number of Rounds")]
        public int NumRounds { get; set; }
    }
}
