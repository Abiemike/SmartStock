using Microsoft.EntityFrameworkCore;
using SmartStock.Entities;

namespace SmartStock.Data;

public class SmartStockDbContext : DbContext
{
    public SmartStockDbContext(
        DbContextOptions<SmartStockDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    public DbSet<Warehouse> Warehouses => Set<Warehouse>();

    public DbSet<InventoryBalance> InventoryBalances => Set<InventoryBalance>();

    public DbSet<InventoryTransaction> InventoryTransactions => Set<InventoryTransaction>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(SmartStockDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}