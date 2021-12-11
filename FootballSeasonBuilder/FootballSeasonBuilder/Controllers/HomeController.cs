using Microsoft.AspNetCore.Mvc;
using FootballSeasonBuilder.Models;

namespace FootballSeasonBuilder.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IList<League> leagues;

        static HomeController()
        {
            leagues = new List<League>()
            {
                new League() {Id = 1, Name = "Telstra Premiership", NumTeams = 16, NumRounds = 28}
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult League()
        {
            return View(leagues);
        }

        [HttpPost]
        public ActionResult League(League league)
        {
            league.Id = leagues.Count + 1;
            league.NumTeams = 0;
            league.NumRounds = 0;
            leagues.Add(league);
            return View(leagues);
        }
    }
}
