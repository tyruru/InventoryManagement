using InventoryManagement.Db.Data;
using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Commands.Product.Create;

public class CreateProductCommand : ICreateProductCommand
{
    private readonly InventoryManagementDbContext _context;

    public CreateProductCommand(InventoryManagementDbContext context)
    {
        _context = context;
    }

    public async Task Execute(CreateProductDto data)
    {
        ProductEntity entity = new();

        _context.Products.Add(entity);
        _context.SaveChangesAsync();
    }
}