using Microsoft.AspNetCore.Mvc;

namespace FootballSeasonBuilder.Controllers
{
    public class SeasonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
