using InventoryManagement.Db.Cqrs.Core.Query;

namespace InventoryManagement.Db.Cqrs.Product.Queries.Find;

public class FindProductQuery : IQuery
{
    public int Id { get; }

    public FindProductQuery(int id)
    {
        Id = id;
    }
}