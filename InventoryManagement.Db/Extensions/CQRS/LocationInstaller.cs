using InventoryManagement.Db.Cqrs.Location.Commands.Create;
using InventoryManagement.Db.Cqrs.Location.Queries.FindLocation;
using InventoryManagement.Db.Cqrs.Provider.Commands;

namespace InventoryManagement.Db.Extensions.CQRS;

public static class LocationInstaller
{
    public static IServiceCollection AddLocationCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateLocationCommandHandler, CreateLocationCommandHandler>();

        return services;
    }

    public static IServiceCollection AddLocationQueries(this IServiceCollection services)
    {
        services
            .AddScoped<IFindLocationQueryHandler, FindLocationQueryHandler>();

        return services;
    }
}