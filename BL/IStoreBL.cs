using System.Collections.Generic;
using Models;

namespace BL{
    public interface IStoreBL{
        IEnumerable<Store> GetStores();

        List<Item> GetInventory(int storeid);

        Store GetStoreById(int storeid);

        Store GetStoreByName(string name);

        void delete(int storeid);

        void deleteAll();

    }
}
