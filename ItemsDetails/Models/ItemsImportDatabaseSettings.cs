namespace ItemsDetails.Models
{
    public class ItemsImportDatabaseSettings : IItemsImportDatabaseSettings
    {
        public string ItemsImportCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
