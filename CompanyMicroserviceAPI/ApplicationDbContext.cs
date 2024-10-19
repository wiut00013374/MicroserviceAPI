using CompanyMicroserviceAPI.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure entity properties if necessary
        modelBuilder.Entity<Product>().HasKey(p => p.id); // Ensure 'id' is the primary key
    }
}
