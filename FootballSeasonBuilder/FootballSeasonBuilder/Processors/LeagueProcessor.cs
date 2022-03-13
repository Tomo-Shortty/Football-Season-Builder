using FootballSeasonBuilder.Models;

namespace FootballSeasonBuilder.Processors
{
    public static class LeagueProcessor
    {
        public static void AddLeague(League league, List<League> leagueList)
        {
            league.Id = leagueList.Count + 1;
            league.NumTeams = 0;
            league.NumRounds = 0;
            leagueList.Add(league);
        }

        public static void DeleteLeague(League league, List<League> leagueList)
        {
            leagueList.Remove(league);
        }

        public static void EditLeague()
        {
            throw new NotImplementedException();
        }
    }
}
