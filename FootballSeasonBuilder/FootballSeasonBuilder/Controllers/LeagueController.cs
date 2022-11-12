using FootballSeasonBuilder.Services;
using Microsoft.AspNetCore.Mvc;

namespace FootballSeasonBuilder.Controllers
{
    public class LeagueController : Controller
    {
        private readonly LeagueService _leagueService;

        public LeagueController(LeagueService leagueService)
        {
            _leagueService = leagueService;
        }

        public IActionResult LeagueView()
        {
            return View();
        }

        public IActionResult AddLeague()
        {
            return View();
        }
    }
}
