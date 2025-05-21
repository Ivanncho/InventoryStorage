using InventoryAPI.Entity;
using Microsoft.EntityFrameworkCore;

namespace InventoryAPI.DataContext
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
