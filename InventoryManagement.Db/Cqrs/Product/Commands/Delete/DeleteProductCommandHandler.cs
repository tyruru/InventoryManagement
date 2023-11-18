using InventoryManagement.Db.Data.UnitOfWork;
using InventoryManagement.Db.Cqrs.Core.Command;
using InventoryManagement.Db.Data.Entities;
using InventoryManagement.Db.Data.Repositories.ProductiId;

namespace InventoryManagement.Db.Cqrs.Product.Commands.Delete;

public sealed class DeleteProductCommandHandler : IDeleteProductCommandHandler
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    async Task ICommandHandler<DeleteProductCommand>.Handle(DeleteProductCommand command)
    {
        ProductEntity product =
            await ((IProductRepository)_unitOfWork.Repository<ProductEntity>()).FindSingle(command.ProductId);

        if (product != null)
        {
            await ((IProductRepository)_unitOfWork.Repository<ProductEntity>()).Delete(product);
            await _unitOfWork.Commit();
        }
    }
}