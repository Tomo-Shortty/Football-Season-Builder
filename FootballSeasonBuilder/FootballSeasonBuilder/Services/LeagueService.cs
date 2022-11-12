using FootballSeasonBuilder.Constants;
using FootballSeasonBuilder.Enums;
using FootballSeasonBuilder.Models;
using System.Text.Json;

namespace FootballSeasonBuilder.Services
{
    public class LeagueService
    {
        public LeagueService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "leagues.json"); }
        }

        public List<League> GetLeagues()
        {
            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<List<League>>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public void AddLeague(string name, string? description, string leagueType, int numberOfConferences, int numberOfDivisions)
        {
            var leagueTypeAccepted = CheckEnteredLeagueType(leagueType);
            if (leagueTypeAccepted)
            {
                var leagues = GetLeagues();
                if (leagues != null)
                {
                    var lastLeagueInList = leagues[leagues.Count - 1];
                    var league = CreateLeague(lastLeagueInList.Id + 1, name, description, leagueType, numberOfConferences, numberOfDivisions);
                    WriteLeagueToFile(league, leagues);
                }
                else
                {
                    var league = CreateLeague(1, name, description, leagueType, numberOfConferences, numberOfDivisions);
                    var newData = new List<League>();
                    WriteLeagueToFile(league, newData);
                }
            }
            else
            {
                throw new Exception(ErrorMessages.IncorrectLeagueType);
            }
        }

        private League CreateLeague(int id, string name, string? description, string leagueType, int numberOfConferences, int numberOfDivisions)
        {
            var league = new League()
            {
                Id = id,
                Name = name,
                Description = description,
                LeagueType = leagueType,
                NumberOfConferences = numberOfConferences,
                NumberOfDivisions = numberOfDivisions
            };
            return league;
        }

        private void WriteLeagueToFile(League league, List<League> leagues)
        {
            leagues.Add(league);
            //var json = JsonSerializer.Serialize(leagues);
            //File.WriteAllText(JsonFileName, json);
            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize(new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = true,
                    Indented = true
                }), leagues);
            }

        }

        private bool CheckEnteredLeagueType(string input)
        {
            if (!input.Equals(LeagueType.League.ToString()) && !input.Equals(LeagueType.Conference.ToString()) && !input.Equals(LeagueType.Division.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
