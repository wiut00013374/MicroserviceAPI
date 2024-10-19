using Microsoft.EntityFrameworkCore;

namespace CompanyMicroserviceAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } // Add your DbSet properties here
    }
}
