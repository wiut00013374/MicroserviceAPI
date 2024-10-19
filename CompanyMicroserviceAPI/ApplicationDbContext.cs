using CompanyMicroserviceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyMicroserviceAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
