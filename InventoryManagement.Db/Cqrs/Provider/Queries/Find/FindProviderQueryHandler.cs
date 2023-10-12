using InventoryManagement.Db.Data.Entities;
using InventoryManagement.Db.Data.Repositories.Provider;
using InventoryManagement.Db.Dtos.Provider;

namespace InventoryManagement.Db.Cqrs.Provider.Queries.Find;

public class FindProviderQueryHandler : IFindProviderQueryHandler
{
    private readonly IProviderRepository _repository;

    public FindProviderQueryHandler(IProviderRepository repository)
    {
        _repository = repository;
    }
    public async Task<ProviderInfoDto?> Handle(FindProviderQuery query)
    {
        ProviderEntity? entity = await _repository.FindSingle(query.Id);

        return entity != null
            ? new ProviderInfoDto(entity.SupplierId, entity.SupplierPhone, entity.SupplierName)
            : default;
    }
}