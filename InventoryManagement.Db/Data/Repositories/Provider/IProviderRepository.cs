using InventoryManagement.Db.Data.Entities;

namespace InventoryManagement.Db.Data.Repositories.Provider;

public interface IProviderRepository : IRepository
{
    Task Create(ProviderEntity entity);

    Task<ProviderEntity?> FindSingle(int providerId);
}