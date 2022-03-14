using FootballSeasonBuilder.Models;

namespace FootballSeasonBuilder.Processors
{
    public static class TeamProcessor
    {
        public static void AddTeamToLeague(Team team, League league, List<Team> teamsList)
        {
            team.Id = teamsList.Count + 1;
            team.League = league;
            team.NumWins = 0;
            team.NumLoses = 0;
            team.NumDraws = 0;
            team.LeaguePoints = 0;
            team.PointsDifference = 0;
            team.PointsFor = 0;
            team.PointsAgainst = 0;
            teamsList.Add(team);
            league.NumTeams += 1;
        }

        public static void DeleteTeam(Team team, League league, List<Team> teamsList)
        {
            teamsList.Remove(team);
            league.NumTeams -= 1;
        }

        public static void ChangeLeague(Team team, League oldLeague, League newLeague)
        {
            team.League = newLeague;
            newLeague.NumTeams += 1;
            oldLeague.NumTeams -= 1;
        }
    }
}
