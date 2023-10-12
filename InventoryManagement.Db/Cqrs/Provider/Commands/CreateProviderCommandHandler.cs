using InventoryManagement.Db.Data.UnitOfWork;
using InventoryManagement.Db.Cqrs.Core.Command;
using InventoryManagement.Db.Data.Entities;
using InventoryManagement.Db.Data.Repositories.Provider;

namespace InventoryManagement.Db.Cqrs.Provider.Commands;

public class CreateProviderCommandHandler : ICreateProviderCommandHandler
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateProviderCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    async Task ICommandHandler<CreateProviderCommand>.Handle(CreateProviderCommand command)
    {
        ProviderEntity providerEntity = new()
        {
            SupplierId = command.SupplierId,
            SupplierName = command.SupplierName,
            SupplierPhone = command.SupplierPhone
        };

        await ((IProviderRepository) _unitOfWork.Repository<ProviderEntity>()).Create(providerEntity);

        await _unitOfWork.Commit();
    }
}