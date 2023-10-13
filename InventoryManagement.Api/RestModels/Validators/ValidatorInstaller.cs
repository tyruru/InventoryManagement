using FluentValidation;
using InventoryManagement.Api.RestModels.Location;
using InventoryManagement.Api.RestModels.Product;
using InventoryManagement.Api.RestModels.Provider;
using InventoryManagement.Api.RestModels.Validators.InventoryItem;
using InventoryManagement.Api.RestModels.Validators.Location;
using InventoryManagement.Api.RestModels.Validators.Product;
using InventoryManagement.Api.RestModels.Validators.Provider;

namespace InventoryManagement.Api.RestModels.Validators;

public static class ValidatorInstaller
{
    public static IServiceCollection AddValidators(this IServiceCollection service)
    {
        service
            .AddScoped<IValidator<CreateInventoryItemRequest>, CreateInventoryItemRequestValidator>()
            .AddScoped<IValidator<CreateLocationRequest>, CreateLocationRequestValidator>()
            .AddScoped<IValidator<CreateProductRequest>, CreateProductRequestValidator>()
            .AddScoped<IValidator<CreateProviderRequest>, CreateProviderRequestValidator>();

        return service;
    }
}