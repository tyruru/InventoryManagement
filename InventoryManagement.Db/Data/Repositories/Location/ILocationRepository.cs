using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Data.Repositories.Location;

public interface ILocationRepository : IRepository
{
    Task Create(LocationEntity entity);

    Task<LocationEntity?> FindSingle(int locationId);
}