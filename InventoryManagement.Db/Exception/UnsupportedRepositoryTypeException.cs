namespace InventoryManagement.Db.Exception;

public sealed class UnsupportedRepositoryTypeException : System.Exception
{
    public UnsupportedRepositoryTypeException(string typeName) : base(typeName)
    {
        
    }
}