using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Purple_Puzzle.Data;
using Purple_Puzzle.Models;

namespace Purple_Puzzle.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Work> datas = await _context.Works.ToListAsync();    
            return View(datas);
        }
    }
}
