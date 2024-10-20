using CompanyMicroserviceAPI.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data
        modelBuilder.Entity<Product>().HasData(
            new Product { id = 1, Name = "Product 1", Description = "Description 1", Price = 10.99m, Stock = 100 },
            new Product { id = 2, Name = "Product 2", Description = "Description 2", Price = 20.99m, Stock = 150 },
            new Product { id = 3, Name = "Product 3", Description = "Description 3", Price = 30.99m, Stock = 200 }
        );
    }
}
