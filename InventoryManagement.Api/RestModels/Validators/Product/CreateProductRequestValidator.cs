using FluentValidation;
using InventoryManagement.Api.RestModels.Product;

namespace InventoryManagement.Api.RestModels.Validators.Product;

public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    public CreateProductRequestValidator()
    {
        RuleFor(x => x.Quantity)
            .NotNull()
            .NotEmpty()
            .WithMessage("Quantity is required");
        
        RuleFor(x => x.ProductId)
            .NotNull()
            .NotEmpty()
            .WithMessage("ProductId is required");
        
        RuleFor(x => x.Name)
            .NotNull()
            .NotEmpty()
            .WithMessage("Name is required");
        
        RuleFor(x => x.Price)
            .NotNull()
            .NotEmpty()
            .WithMessage("Price is required");
    }
}