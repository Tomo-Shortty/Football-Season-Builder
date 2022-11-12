using Microsoft.AspNetCore.Mvc;

namespace FootballSeasonBuilder.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult TeamView()
        {
            return View();
        }
    }
}
