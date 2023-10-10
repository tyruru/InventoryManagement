using InventoryManagement.Db.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Db.Data.Repositories.InventoryItem;

public sealed class InventoryItemRepository : IInventoryItemRepository
{
    private readonly InventoryManagementDbContext _context;

    public InventoryItemRepository(InventoryManagementDbContext context)
    {
        _context = context;
    }

    public async Task Create(InventoryItemEntity entity)
    {
        await _context.InventoryItems.AddAsync(entity);
    }

    public async Task<InventoryItemEntity?> FindSingle(int inventoryItemId)
    {
        return await _context.InventoryItems.SingleOrDefaultAsync(p => p.InventoryItemId == inventoryItemId);
    }
}