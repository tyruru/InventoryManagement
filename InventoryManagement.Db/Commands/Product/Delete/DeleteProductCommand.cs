using InventoryManagement.Db.Data;
using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Commands.Product.Delete;

public sealed class DeleteProductCommand : IDeleteProductCommand
{
    private readonly InventoryManagementDbContext _context;

    public DeleteProductCommand(InventoryManagementDbContext context)
    {
        _context = context;
    }

    public async Task Execute(DeleteProductDto data)
    {
        ProductEntity entity = await _context.Products.FindAsync(data.ProductId);

        if (entity != null)
        {
            _context.Products.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}