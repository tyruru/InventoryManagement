namespace InventoryManagement.Api.RestModels.Location;

public class CreateLocationRequest
{
    public int  LocationId { get; set; }
    public string LocationName { get; set; }
    public string LocationAddress { get; set; }
}