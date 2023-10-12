using InventoryManagement.Db.Cqrs.Core.Query;
using InventoryManagement.Db.Cqrs.Product.Queries.Find;
using InventoryManagement.Db.Dtos.Provider;

namespace InventoryManagement.Db.Cqrs.Provider.Queries.Find;

public interface IFindProviderQueryHandler : IQueryHandler<FindProviderQuery, ProviderInfoDto?>
{
    
}