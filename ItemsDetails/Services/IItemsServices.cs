using ItemsDetails.Models;

namespace ItemsDetails.Services
{
    public interface IItemsServices
    {
        List<Items> Get();
        Items GetById(string id);
        Items Create(Items item);
        void Update(string id, Items item);
        void Delete(string id);

    }
}
