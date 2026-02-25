using Microsoft.AspNetCore.Mvc;

namespace Purple_Puzzle.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
