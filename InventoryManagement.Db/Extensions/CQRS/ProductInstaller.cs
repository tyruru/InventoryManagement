using InventoryManagement.Db.Cqrs.Product.Commands.Create;
using InventoryManagement.Db.Cqrs.Product.Queries.Find;

namespace InventoryManagement.Db.Extensions.CQRS;

public static class ProductInstaller
{
    public static IServiceCollection AddProductCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateProductCommandHandler, CreateProductCommandHandler>();

        return services;
    }

    public static IServiceCollection AddProductQueries(this IServiceCollection services)
    {
        services
            .AddScoped<IFindProductQueryHandler, FindProductQueryHandler>();

        return services;
    }
}