using Microsoft.AspNetCore.Mvc;

namespace Purple_Puzzle.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
