namespace FootballSeasonBuilder.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public League League { get; set; }
        public int NumWins { get; set; }
        public int NumDraws { get; set; }
        public int NumLoses { get; set; }
        public int LeaguePoints { get; set; }
        public int PointsDifference { get; set; }
        public int PointsFor { get; set; }
        public int PointsAgainst { get; set; }
        public int LadderPosition { get; set; }
        public int SeasonPowerRanking { get; set; }
        public string PrimaryColour { get; set; }
        public string SecondaryColour { get; set; }
    }
}
