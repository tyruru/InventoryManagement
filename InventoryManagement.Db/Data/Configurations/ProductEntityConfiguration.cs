using InventoryManagement.Db.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Db.Data.Configurations;

public sealed class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
{
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.HasKey(e => e.ProductId);
        builder.HasKey(e => e.Name);
        builder.HasKey(e => e.Price);
        builder.HasKey(e => e.Quantity);
    }
}