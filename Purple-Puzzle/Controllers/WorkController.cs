using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Purple_Puzzle.Data;
using Purple_Puzzle.Models;

namespace Purple_Puzzle.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;
        public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Detail(int id)
        {
            Work work = await _context.Works.FirstOrDefaultAsync(m => m.Id == id);
            return View(work);
        }
    }
}
