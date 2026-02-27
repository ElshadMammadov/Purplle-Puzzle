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
            List<Work> works = await _context.Works.ToListAsync(); 
            List<Category> categories = await _context.Categories.ToListAsync();

            HomeVM response = new()
            {
                Works = works,
                Categories = categories
            };

            return View(response);
        }
    }
}
