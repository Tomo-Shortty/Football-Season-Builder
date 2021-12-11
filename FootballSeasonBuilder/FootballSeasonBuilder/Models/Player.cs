using System.ComponentModel.DataAnnotations;

namespace FootballSeasonBuilder.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }
        public string Position { get; set; }

        [Display(Name = "Tries")]
        public int NumTries { get; set; }

        [Display(Name = "Goals")]
        public int NumGoals { get; set; }

        [Display(Name = "Field Goals")]
        public int NumFieldGoals { get; set; }

        [Display(Name = "Matches Played")]
        public int MatchesPlayed { get; set; }
    }
}
