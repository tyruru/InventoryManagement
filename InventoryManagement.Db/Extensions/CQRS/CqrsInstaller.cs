namespace InventoryManagement.Db.Extensions.CQRS;

public static class CqrsInstaller
{
    public static IServiceCollection AddCQRS(this IServiceCollection services)
    {
        services
            .AddInventoryItemCommands()
            .AddInventoryItemQueries()

            .AddLocationCommands()
            .AddLocationQueries()

            .AddProductCommands()
            .AddProductQueries()

            .AddProviderCommands()
            .AddProviderQueries();

        return services;

    }
}