using Microsoft.EntityFrameworkCore;

namespace Purple_Puzzle.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }
    }
}
