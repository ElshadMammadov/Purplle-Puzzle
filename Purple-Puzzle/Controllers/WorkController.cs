using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Purple_Puzzle.Data;
using Purple_Puzzle.Models;
using System.Threading.Tasks;

namespace Purple_Puzzle.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;
        public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Work> works = await _context.Works.ToListAsync();
            return View(works);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();
            Work work = await _context.Works.Include(m=>m.Category).FirstOrDefaultAsync(m => m.Id == id);
            if (work is null) return NotFound();
            return View(work);

        }
    }
}
