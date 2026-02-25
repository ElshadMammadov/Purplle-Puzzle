using Microsoft.AspNetCore.Mvc;

namespace Purple_Puzzle.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
