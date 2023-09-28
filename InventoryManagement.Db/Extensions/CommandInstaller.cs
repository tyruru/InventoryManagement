using InventoryManagement.Db.Commands.InventoryItem.Create;
using InventoryManagement.Db.Commands.Location.Create;
using InventoryManagement.Db.Commands.Product.Create;
using InventoryManagement.Db.Commands.Product.Delete;
using InventoryManagement.Db.Commands.Provider;

namespace InventoryManagement.Db.Extensions;

public static class CommandInstaller
{
    public static IServiceCollection AddInventoryItemCommads(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateInventoryItemCommand, CreateInventoryItemCommand>();

        return services;
    }

    public static IServiceCollection AddLocationCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateLocationCommand, CreateLocationCommand>();

        return services;
    }

    public static IServiceCollection AddProductCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateProductCommand, CreateProductCommand>()
            .AddScoped<IDeleteProductCommand, DeleteProductCommand>();

        return services;
    }

    public static IServiceCollection AddProviderCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateProviderCommand, CreateProviderCommand>();

        return services;
    }
}