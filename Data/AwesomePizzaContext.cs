using EFGetStarted.Models;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted.Data;

public class AwesomePizzaContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;

    public DbSet<Order> Orders { get; set; } = null!;

    public DbSet<Product> Products { get; set; } = null!;

    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=CIMP;Database=AwesomePizzaDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
