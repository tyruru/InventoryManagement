namespace InventoryManagement.Db.Commands.Product.Delete;

public class DeleteProductDto
{
    public int ProductId { get; set; }

    public DeleteProductDto(int productId)
    {
        ProductId = productId;
    }
}