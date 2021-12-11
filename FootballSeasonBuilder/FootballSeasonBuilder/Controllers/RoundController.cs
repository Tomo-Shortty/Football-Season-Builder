using Microsoft.AspNetCore.Mvc;

namespace FootballSeasonBuilder.Controllers
{
    public class RoundController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
