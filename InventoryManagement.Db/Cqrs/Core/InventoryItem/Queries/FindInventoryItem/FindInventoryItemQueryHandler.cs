using InventoryManagement.Db.Data.Entities;
using InventoryManagement.Db.Data.Repositories.InventoryItem;
using InventoryManagement.Db.Dtos.InventoryItem;

namespace InventoryManagement.Db.Cqrs.Core.InventoryItem.Queries.FindInventoryItem;

public class FindInventoryItemQueryHandler : IFindInventoryItemQueryHandler
{
    private readonly IInventoryItemRepository _repository;

    public FindInventoryItemQueryHandler(IInventoryItemRepository repository)
    {
        _repository = repository;
    }

    public async Task<InventoryItemInfoDto?> Handle(FindInventoryItemQuery query)
    {
        InventoryItemEntity? entity = await _repository.FindSingle(query.Id);

        return entity != null
            ? new InventoryItemInfoDto(entity.InventoryItemId, entity.ProductId, entity.LocationId, entity.Quantity)
            : default;
    }
}