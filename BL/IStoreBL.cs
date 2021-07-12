using System.Collections.Generic;
using Models;

namespace BL{
    public interface IStoreBL{
        List<Store> GetAllStores();

        Store FindStoreById(int storeid);

        Store FindStoreByName(string name);

        void delete(int storeid);

        void deleteAll();

        List<Store> GetStoreInventory();
    }
}
