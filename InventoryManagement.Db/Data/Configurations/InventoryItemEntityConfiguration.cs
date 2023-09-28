using InventoryManagement.Db.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Db.Data.Configurations;

public sealed class InventoryItemEntityConfiguration : IEntityTypeConfiguration<InventoryItemEntity>
{
    public void Configure(EntityTypeBuilder<InventoryItemEntity> builder)
    {
        builder.HasKey(e => e.InventoryItemId);
        builder.HasKey(e => e.LocationId);
        builder.HasKey(e => e.Quantity);
        builder.HasKey(e => e.ProductId);
    }
}