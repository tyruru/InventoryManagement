using FluentValidation;
using InventoryManagement.Api.RestModels.Location;

namespace InventoryManagement.Api.RestModels.Validators.Location;

public class CreateLocationRequestValidator : AbstractValidator<CreateLocationRequest>
{
   public CreateLocationRequestValidator()
   {
      RuleFor(x => x.LocationAddress)
         .NotNull()
         .NotEmpty()
         .WithMessage("LocationAddress is required");
      
      RuleFor(x => x.LocationId)
         .NotNull()
         .NotEmpty()
         .WithMessage("Quantity is required");
      
      RuleFor(x => x.LocationName)
         .NotNull()
         .NotEmpty()
         .WithMessage("Quantity is required");
   }
}