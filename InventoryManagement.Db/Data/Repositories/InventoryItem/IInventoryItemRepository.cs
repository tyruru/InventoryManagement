using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Data.Repositories.InventoryItem;

public interface IInventoryItemRepository : IRepository
{
    Task Create(InventoryItemEntity entity);
    Task<InventoryItemEntity?>  FindSingle (int inventoryItemId);
}