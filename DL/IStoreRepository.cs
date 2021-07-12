using System.Collections.Generic;
using Models;

namespace DL{
    public interface IStoreRepository{
         List<Store> GetAllStores();

         Store GetStoreById(int storeid);

         Store GetStoreInventory(Store store);
    }
}