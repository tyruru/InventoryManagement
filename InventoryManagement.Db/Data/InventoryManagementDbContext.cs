using System.Reflection;
using InventoryManagement.Db.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Db.Data;

public class InventoryManagementDbContext : DbContext
{
    public DbSet<ProductEntity> Products { get; init; }
    public DbSet<LocationEntity> Locations { get; init; }
    public DbSet<InventoryItemEntity> InventoryItems{ get; init; }
    public DbSet<ProviderEntity> Providers { get; set; }

    public InventoryManagementDbContext(DbContextOptions<InventoryManagementDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}