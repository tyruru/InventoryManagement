using InventoryManagement.Db.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Db.Data.Repositories.ProductiId;

public sealed class ProductRepository : IProductRepository
{
    private readonly InventoryManagementDbContext _context;

    public ProductRepository(InventoryManagementDbContext context)
    {
        _context = context;
    }

    public async Task Create(ProductEntity entity)
    {
        await _context.Products.AddAsync(entity);
    }

    public async Task<ProductEntity?> FindSingle(int productId)
    {
        return await _context.Products.SingleOrDefaultAsync(p => p.ProductId == productId);
    }
}