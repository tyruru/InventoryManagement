using InventoryManagement.Db.Data;
using InventoryManagement.Db.Data.Entities;
using Microsoft.EntityFrameworkCore.Query.Internal;


namespace InventoryManagement.Db.Commands.InventoryItem.Create;

public class CreateInventoryItemCommand : ICreateInventoryItemCommand
{
    private readonly InventoryManagementDbContext _context;

    public CreateInventoryItemCommand(InventoryManagementDbContext context)
    {
        _context = context;
    }

    public async Task Execute(CreateInventoryItemDto data)
    {
        InventoryItemEntity entity = new();

        _context.InventoryItems.Add(entity);
        await _context.SaveChangesAsync();
    }
}