using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using InventoryManagement.Db.Data;

namespace InventoryManagement.Db.Extensions;

public static class InventoryManagementDataInstaller
{
    public static IServiceCollection AddInventoryManagementData(this IServiceCollection services,
        string connectionString)
    {
        services.AddDbContextPool<InventoryManagementDbContext>(options =>
            options
                .UseNpgsql(connectionString, builder => builder.MigrationsAssembly("InventoryManagement.Db"))
        );

        return services;
    }
}