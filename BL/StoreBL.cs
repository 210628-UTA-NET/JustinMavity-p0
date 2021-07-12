using System.Collections.Generic;
using Models;
using DL;

namespace BL{
    public class StoreBL : IStoreBL{
        private IStoreRepository storerepo;

        private ItemRepository itemrepo;

        public StoreBL(IStoreRepository storerepo){
            this.storerepo = storerepo;
        }

        public List<Store> GetAllStores(){
            return storerepo.GetAllStores();
        }

        public Store FindStoreById(int storeid){
            return storerepo.GetStoreById(storeid);
        }

        public Store FindStoreByName(string name){
            return null;
        }


        public List<Store> GetStoreInventory(){
            return null;
        }

        public Store GetStoreInventory(Store store){
            return storerepo.GetStoreInventory(store);
        }

        public void delete(int id){

        }

        public void deleteAll(){

        }
    }
}