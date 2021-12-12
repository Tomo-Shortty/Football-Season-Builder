using Microsoft.AspNetCore.Mvc;
using FootballSeasonBuilder.Models;

namespace FootballSeasonBuilder.Controllers
{
    public class TeamController : Controller
    {
        private static readonly IList<Team> teams;

        static TeamController()
        {
            teams = new List<Team>()
            {
                new Team() { Id = 1, Name = "Brisbane Broncos", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 1, SeasonPowerRanking = 0, PrimaryColour = "Maroon", SecondaryColour = "Gold"} ,
                new Team() { Id = 2, Name = "Canberra Raiders", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 2, SeasonPowerRanking = 0, PrimaryColour = "Lime", SecondaryColour = "Blue"} ,
                new Team() { Id = 3, Name = "Canterbury-Bankstown Bulldogs", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 3, SeasonPowerRanking = 0, PrimaryColour = "White", SecondaryColour = "Blue"} ,
                new Team() { Id = 4, Name = "Cronulla-Sutherland Sharks", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 4, SeasonPowerRanking = 0, PrimaryColour = "SkyBlue", SecondaryColour = "Black"} ,
                new Team() { Id = 5, Name = "Gold Coast Titans", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 5, SeasonPowerRanking = 0, PrimaryColour = "SkyBlue", SecondaryColour = "Gold"} ,
                new Team() { Id = 6, Name = "Manly Warringah Sea Eagles", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 6, SeasonPowerRanking = 0, PrimaryColour = "White", SecondaryColour = "Maroon"} ,
                new Team() { Id = 7, Name = "Melbourne Storm", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 7, SeasonPowerRanking = 0, PrimaryColour = "Purple", SecondaryColour = "Indigo"} ,
                new Team() { Id = 8, Name = "Newcastle Knights", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 8, SeasonPowerRanking = 0, PrimaryColour = "Blue", SecondaryColour = "Red"} ,
                new Team() { Id = 9, Name = "New Zealand Warriors", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 9, SeasonPowerRanking = 0, PrimaryColour = "Blue", SecondaryColour = "Green"} ,
                new Team() { Id = 10, Name = "North Queensland Cowboys", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 10, SeasonPowerRanking = 0, PrimaryColour = "MidnightBlue", SecondaryColour = "Yellow"} ,
                new Team() { Id = 11, Name = "Parramatta Eels", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 11, SeasonPowerRanking = 0, PrimaryColour = "Blue", SecondaryColour = "Gold"} ,
                new Team() { Id = 12, Name = "Penrith Panthers", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 12, SeasonPowerRanking = 0, PrimaryColour = "Black", SecondaryColour = "Gold"} ,
                new Team() { Id = 13, Name = "South Sydney Rabbitohs", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 13, SeasonPowerRanking = 0, PrimaryColour = "Green", SecondaryColour = "Red"} ,
                new Team() { Id = 14, Name = "St. George Illawarra Dragons", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 14, SeasonPowerRanking = 0, PrimaryColour = "White", SecondaryColour = "Red"} ,
                new Team() { Id = 15, Name = "Sydney Roosters", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 15, SeasonPowerRanking = 0, PrimaryColour = "Red", SecondaryColour = "Blue"} ,
                new Team() { Id = 16, Name = "Wests Tigers", /*League =,*/ NumWins = 0, NumDraws = 0, NumLoses = 0, LeaguePoints = 0, PointsDifference = 0,
                PointsFor = 0, PointsAgainst = 0, LadderPosition = 16, SeasonPowerRanking = 0, PrimaryColour = "Orange", SecondaryColour = "Black"} ,
            };
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
