using Front_to_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Front_to_Back.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Product> Products { get; set; }
        public object Sliders { get; internal set; }
    }
}
