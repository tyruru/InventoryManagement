using InventoryManagement.Db.Cqrs.Core.Query;
using InventoryManagement.Db.Dtos.Location;

namespace InventoryManagement.Db.Cqrs.Location.Queries.FindLocation;

public interface IFindLocationQueryHandler : IQueryHandler<FindLocationQuery, LocationInfoDto?>
{
    
}