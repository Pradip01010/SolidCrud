using Microsoft.EntityFrameworkCore;
using SolidCrud.Models; // 👈 Make sure this matches your namespace

namespace SolidCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 👇 Add your DbSets (tables) here
        public DbSet<Product> Products { get; set; }
    }
}

