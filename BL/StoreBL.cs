using System.Collections.Generic;
using Models;
using DL;

namespace BL{
    public class StoreBL : IStoreBL{
        private IStoreRepository storerepo;

        public IEnumerable<Store> GetStores(){
            return storerepo.GetAllStores();
        }

        public Store GetStoreById(int storeid){
            return storerepo.FindStoreById(storeid);
        }

        public Store GetStoreByName(string name){
            return storerepo.FindStoreByName(name);
        }

        public List<Item> GetInventory(int id){
            return storerepo.GetStoreInventory(id);
        }

        public void delete(int id){
            storerepo.DeleteStore(id);
        }

        public void deleteAll(){
            storerepo.DeleteAllStores();
        }
    }
}