using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Purple_Puzzle.Data;
using Purple_Puzzle.Models;
using Purple_Puzzle.ViewModels;

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
            return View(new HomeVM
            {
                Works = await _context.Works.ToListAsync(),
                Categories = await _context.Categories.ToListAsync(),
                Sliders = await _context.Sliders.ToListAsync(),
                SliderImage = await _context.SliderImages.FirstOrDefaultAsync()
            });
        }
    }
}
