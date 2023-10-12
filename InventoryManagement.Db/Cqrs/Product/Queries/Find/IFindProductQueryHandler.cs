using InventoryManagement.Db.Cqrs.Core.Query;
using InventoryManagement.Db.Dtos.Product;

namespace InventoryManagement.Db.Cqrs.Product.Queries.Find;

public interface IFindProductQueryHandler : IQueryHandler<FindProductQuery, ProductInfoDto?>
{
    
}