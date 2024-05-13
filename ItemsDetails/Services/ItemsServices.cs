using ItemsDetails.Models;
using MongoDB.Driver;

namespace ItemsDetails.Services
{
    public class ItemsServices : IItemsServices
    {
        private readonly IMongoCollection<Items> _items;

        public ItemsServices(IItemsImportDatabaseSettings itemsImportDatabaseSettings,IMongoClient mongoClient)
        {
            var database=mongoClient.GetDatabase(itemsImportDatabaseSettings.DatabaseName);
            _items = database.GetCollection<Items>(itemsImportDatabaseSettings.ItemsImportCollectionName);
        }

        public Items Create(Items item)
        {
            _items.InsertOne(item);
            return item;
        }

        public void Delete(string id)
        {
            _items.DeleteOne(items => items.Id == id);
        }

        public List<Items> Get()
        {
            return _items.Find(items=>true).ToList();
        }

        public Items GetById(string id)
        {
            return _items.Find(items => items.Id==id).FirstOrDefault();
        }

        public void Update(string id, Items item)
        {
            _items.ReplaceOne(items => items.Id == id, item);
        }
    }
}
