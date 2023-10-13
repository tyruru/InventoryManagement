namespace InventoryManagement.Api.RestModels.Product;

public class DeleteProductResponse
{
    public int ProductId { get; set; }

    public DeleteProductResponse(int productId)
    {
        ProductId = productId;
    }
}