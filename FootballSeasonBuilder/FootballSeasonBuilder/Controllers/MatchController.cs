using Microsoft.AspNetCore.Mvc;

namespace FootballSeasonBuilder.Controllers
{
    public class MatchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
