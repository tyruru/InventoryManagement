using InventoryManagement.Db.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Db.Data.Configurations;

public sealed class ProviderEntityConfiguration : IEntityTypeConfiguration<ProviderEntity>
{
    public void Configure(EntityTypeBuilder<ProviderEntity> builder)
    {
        builder.HasKey(e => e.SupplierId);
        builder.HasKey(e => e.SupplierName);
        builder.HasKey(e => e.SupplierPhone);
    }
}