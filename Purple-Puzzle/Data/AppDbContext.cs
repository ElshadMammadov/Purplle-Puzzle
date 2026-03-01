using Microsoft.EntityFrameworkCore;
using Purple_Puzzle.Models;

namespace Purple_Puzzle.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Work> Works { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }
    }
}
