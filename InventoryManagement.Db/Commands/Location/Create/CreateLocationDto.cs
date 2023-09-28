namespace InventoryManagement.Db.Commands.Location.Create;

public class CreateLocationDto
{
    public int  LocationId { get; set; }
    public string LocationName { get; set; }
    public string LocationAddress { get; set; }

    public CreateLocationDto(int locationId, string locationName, string locationAddress)
    {
        LocationId = locationId;
        LocationName = locationName; 
        LocationAddress = locationAddress;
    }
    
}