using InventoryManagement.Db.Cqrs.Core.Query;

namespace InventoryManagement.Db.Cqrs.Provider.Queries.Find;

public class FindProviderQuery : IQuery
{
    public int Id { get; }

    public FindProviderQuery(int id)
    {
        Id = id;
    }
}