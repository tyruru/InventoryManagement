using InventoryManagement.Db.Cqrs.Provider.Commands;
using InventoryManagement.Db.Cqrs.Provider.Queries.Find;

namespace InventoryManagement.Db.Extensions.CQRS;

public static class ProviderInstaller
{
    public static IServiceCollection AddProviderCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateProviderCommandHandler, CreateProviderCommandHandler>();

        return services;
    }

    public static IServiceCollection AddProviderQueries(this IServiceCollection services)
    {
        services.AddScoped<IFindProviderQueryHandler, FindProviderQueryHandler>();

        return services;
    }
}