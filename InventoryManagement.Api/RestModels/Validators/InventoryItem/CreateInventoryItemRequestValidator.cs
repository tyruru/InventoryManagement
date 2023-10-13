using FluentValidation;

namespace InventoryManagement.Api.RestModels.Validators.InventoryItem;

public class CreateInventoryItemRequestValidator : AbstractValidator<CreateInventoryItemRequest>
{
    public CreateInventoryItemRequestValidator()
    {
        RuleFor(x => x.ProductId)
            .NotNull()
            .NotEmpty()
            .WithMessage("ProductId is required");
        
        RuleFor(x => x.LocationId)
            .NotNull()
            .NotEmpty()
            .WithMessage("LocationID is required");
        
        RuleFor(x => x.Quantity)
            .NotNull()
            .NotEmpty()
            .WithMessage("Quantity is required");
        
        RuleFor(x => x.InventoryItemId)
            .NotNull()
            .NotEmpty()
            .WithMessage("InventoryItemId is required");
    }
}