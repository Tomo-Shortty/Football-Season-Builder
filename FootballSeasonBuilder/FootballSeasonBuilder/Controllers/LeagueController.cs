using FootballSeasonBuilder.Models;
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

        [HttpPost]
        public ActionResult AddLeague(string name, string description, string leagueType, string numberOfConferences, string numberOfDivisions)
        {
            try
            {
                _leagueService.AddLeague(name, description, leagueType, int.Parse(numberOfConferences), int.Parse(numberOfDivisions));
                return View("LeagueView");
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.ToString();
                return View();
            }
        }
    }
}
