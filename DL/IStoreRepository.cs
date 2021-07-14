using System.Collections;
using System.Collections.Generic;
using Models;

namespace DL{
    public interface IStoreRepository{
         IEnumerable<Store> GetAllStores();

         Store FindStoreById(int storeid);

         List<Item> GetStoreInventory(int id);

         Store FindStoreByName(string name);

         void AddInventory(Store store, Item item);

         void DeleteStore(int id);

         void DeleteAllStores();
    }
}