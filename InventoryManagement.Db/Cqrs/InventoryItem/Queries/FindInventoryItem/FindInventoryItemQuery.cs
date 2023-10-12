using InventoryManagement.Db.Cqrs.Core.Query;

namespace InventoryManagement.Db.Cqrs.Core.InventoryItem.Queries.FindInventoryItem;

public class FindInventoryItemQuery : IQuery
{
    public int Id { get; }

    public FindInventoryItemQuery(int id)
    {
        Id = id;
    }
}