using InventoryManagement.Db.Data.Entities;
using InventoryManagement.Db.Data.Repositories.ProductiId;
using InventoryManagement.Db.Data.UnitOfWork;
using InventoryManagement.Db.Dtos.Product;

namespace InventoryManagement.Db.Cqrs.Product.Queries.Find;

public class FindProductQueryHandler : IFindProductQueryHandler
{
    private readonly IProductRepository _repository;

    public FindProductQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }
    public async Task<ProductInfoDto?> Handle(FindProductQuery query)
    {
        ProductEntity? entity = await _repository.FindSingle(query.Id);

        return entity != null
            ? new ProductInfoDto(entity.ProductId, entity.Price, entity.Quantity, entity.Name)
            : default;
    }
}