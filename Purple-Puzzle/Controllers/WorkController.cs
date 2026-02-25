using Microsoft.AspNetCore.Mvc;

namespace Purple_Puzzle.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
