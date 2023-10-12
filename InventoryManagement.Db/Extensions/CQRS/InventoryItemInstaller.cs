using InventoryManagement.Db.Cqrs.Core.InventoryItem.Commands.Create;
using InventoryManagement.Db.Cqrs.Core.InventoryItem.Queries.FindInventoryItem;

namespace InventoryManagement.Db.Extensions.CQRS;

public static class InventoryItemInstaller
{
    public static IServiceCollection AddInventoryItemCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateInventoryItemCommandHandler, CreateInventoryItemCommandHandler>();

        return services;
    }

    public static IServiceCollection AddInventoryItemQueries(this IServiceCollection services)
    {
        services
            .AddScoped<IFindInventoryItemQueryHandler, FindInventoryItemQueryHandler>();

        return services;
    }
}