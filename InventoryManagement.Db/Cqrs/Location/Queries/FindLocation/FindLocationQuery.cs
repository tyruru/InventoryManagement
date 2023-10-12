using InventoryManagement.Db.Cqrs.Core.Query;

namespace InventoryManagement.Db.Cqrs.Location.Queries.FindLocation;

public class FindLocationQuery : IQuery
{
    public int Id { get; }

    public FindLocationQuery(int id)
    {
        Id = id;
    }
}