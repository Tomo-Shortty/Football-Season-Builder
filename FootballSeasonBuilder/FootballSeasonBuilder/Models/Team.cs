using System.ComponentModel.DataAnnotations;

namespace FootballSeasonBuilder.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public League League { get; set; }

        [Display(Name = "Wins")]
        public int NumWins { get; set; }

        [Display(Name = "Draws")]
        public int NumDraws { get; set; }

        [Display(Name = "Losses")]
        public int NumLoses { get; set; }

        [Display(Name = "League Points")]
        public int LeaguePoints { get; set; }

        [Display(Name = "Points Difference")]
        public int PointsDifference { get; set; }

        [Display(Name = "Points Gained")]
        public int PointsFor { get; set; }

        [Display(Name = "Points Conceded")]
        public int PointsAgainst { get; set; }

        [Display(Name = "Ladder Position")]
        public int LadderPosition { get; set; }
        public int SeasonPowerRanking { get; set; }
        public string PrimaryColour { get; set; }
        public string SecondaryColour { get; set; }
    }
}
