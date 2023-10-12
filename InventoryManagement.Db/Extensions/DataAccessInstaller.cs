using InventoryManagement.Db.Data.Repositories.Factory;
using InventoryManagement.Db.Data.Repositories.InventoryItem;
using InventoryManagement.Db.Data.Repositories.Location;
using InventoryManagement.Db.Data.Repositories.ProductiId;
using InventoryManagement.Db.Data.Repositories.Provider;
using InventoryManagement.Db.Data.UnitOfWork;

namespace InventoryManagement.Db.Extensions;

public static class DataAccessInstaller
{
    public static IServiceCollection AddDataAccess(this IServiceCollection service)
    {
        service
            .AddScoped<IInventoryItemRepository, InventoryItemRepository>()
            .AddScoped<ILocationRepository, LocationRepository>()
            .AddScoped<IProductRepository, ProductRepository>()
            .AddScoped<IProviderRepository, ProviderRepository>();

        service
            .AddSingleton<IRepositoryFactory, RepositoryFactory>()
            .AddScoped<IUnitOfWork, UnitOfWork>();

        return service;
    }
}