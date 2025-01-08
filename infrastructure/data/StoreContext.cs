using core.entities;
using infrastructure.config;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.data;

public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
        
        base.OnModelCreating(modelBuilder);
    }
}
