using InventoryManagement.Db.Data.UnitOfWork;
using InventoryManagement.Db.Cqrs.Core.Command;
using InventoryManagement.Db.Data.Entities;
using InventoryManagement.Db.Data.Repositories.ProductiId;

namespace InventoryManagement.Db.Cqrs.Product.Commands.Create;

public class CreateProductCommandHandler : ICreateProductCommandHandler
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    async Task ICommandHandler<CreateProductCommand>.Handle(CreateProductCommand command)
    {
        ProductEntity productEntity = new()
        {
            ProductId = command.ProductId,
            Price = command.Price,
            Quantity = command.Quantity,
            Name = command.Name
        };

        await ((IProductRepository) _unitOfWork.Repository<ProductEntity>()).Create(productEntity);

        await _unitOfWork.Commit();
    }
}