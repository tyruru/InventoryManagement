using FluentValidation;
using InventoryManagement.Api.RestModels.Product;
using InventoryManagement.Api.RestModels.Provider;

namespace InventoryManagement.Api.RestModels.Validators.Provider;

public class CreateProviderRequestValidator : AbstractValidator<CreateProviderRequest>
{
    public CreateProviderRequestValidator()
    {
        RuleFor(x => x.SupplierId)
            .NotNull()
            .NotEmpty()
            .WithMessage("SupplierId is required");
        
        RuleFor(x => x.SupplierName)
            .NotNull()
            .NotEmpty()
            .WithMessage("SupplierName is required");
        
        RuleFor(x => x.SupplierPhone)
            .NotNull()
            .NotEmpty()
            .WithMessage("SupplierPhone is required");
    }
}