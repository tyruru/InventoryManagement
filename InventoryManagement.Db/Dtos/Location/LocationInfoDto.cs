namespace InventoryManagement.Db.Dtos.Location;

public sealed class LocationInfoDto
{
    public int  LocationId { get; set; }
    public string LocationName { get; set; }
    public string LocationAddress { get; set; }

    public LocationInfoDto(int locationId, string locationName, string locationAddress)
    {
        LocationId = locationId;
        LocationName = locationName;
        LocationAddress = locationAddress;
    }
}