namespace ItemsDetails.Models
{
    public interface IItemsImportDatabaseSettings
    {
        string ItemsImportCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
