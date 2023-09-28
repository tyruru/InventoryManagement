namespace InventoryManagement.Api.RestModels.Provider;

public class CreateProviderRequest
{
    public int  SupplierId { get; set; }
    public string SupplierName { get; set; }
    public string SupplierPhone { get; set; }
}