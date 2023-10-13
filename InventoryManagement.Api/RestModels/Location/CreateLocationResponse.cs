namespace InventoryManagement.Api.RestModels.Location;

public class CreateLocationResponse
{
    public int  LocationId { get; set; }
    public string LocationName { get; set; }
    public string LocationAddress { get; set; }

    public CreateLocationResponse(int locationId, string locationName, string locationAddress)
    {
        LocationId = locationId;
        LocationName = locationName;
        LocationAddress = locationAddress;
    }
}