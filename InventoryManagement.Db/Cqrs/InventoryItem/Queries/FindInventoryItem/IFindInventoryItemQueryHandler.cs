using InventoryManagement.Db.Cqrs.Core.Query;
using InventoryManagement.Db.Dtos.InventoryItem;

namespace InventoryManagement.Db.Cqrs.Core.InventoryItem.Queries.FindInventoryItem;

public interface IFindInventoryItemQueryHandler : IQueryHandler<FindInventoryItemQuery, InventoryItemInfoDto?>
{
    
}