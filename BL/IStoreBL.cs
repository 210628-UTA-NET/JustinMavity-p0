using System.Collections.Generic;
using Models;

namespace BL{
    public interface IStoreBL{
        IEnumerable<Store> GetStores();

        Store GetStoreById(int storeid);

        Store GetStoreByName(string name);

        void delete(int storeid);

        void deleteAll();

    }
}
