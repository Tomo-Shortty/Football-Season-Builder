namespace FootballSeasonBuilder.Models
{
    public class Round
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Season { get; set; }
        public bool IsPlayoff { get; set; }
        public bool IsChampionship { get; set; }
        public bool IsPremiershipFinal { get; set; }
    }
}
