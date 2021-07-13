using System.Collections.Generic;
using System.Linq;
using Model = Models;
using Entity = DL.Entities;

namespace DL{
    public class StoreRepository : IStoreRepository{

        private Entity.StoreManagerDbContext context;

        private ItemRepository itemrepo;

        public StoreRepository(Entity.StoreManagerDbContext context){
            this.context = context;
        }
        public IEnumerable<Model.Store> GetAllStores(){
            return context.Stores.Select(
                store => 
                    new Model.Store() {
                        Id = store.StoreId,
                        Name = store.StoreName,
                        Address = store.StoreAddress
                    }
                ).ToList();
        }
        public Model.Store FindStoreById(int storeid) {
            var listOfStores = GetAllStores();
            Model.Store store = new Model.Store();
            foreach(var ele in listOfStores) {
                if(ele.Id == storeid){
                    Model.Store s =  new Model.Store() {
                        Id = ele.Id,
                        Name = ele.Name,
                        Address = ele.Address
                    };
                    return store = s;
                } 
                else {
                   throw new System.Exception($"There was no store with the id of {storeid}");
                }
            } 
            return store;
        }

        public Model.Store FindStoreByName(string name){
            var listOfStores = GetAllStores();
            Model.Store store = new Model.Store();
            foreach(var ele in listOfStores) {
                if(ele.Name == name){
                    Model.Store s =  new Model.Store() {
                        Id = ele.Id,
                        Name = ele.Name,
                        Address = ele.Address
                    };
                    return store = s;
                } 
                else {
                   throw new System.Exception($"There was no store with the id of {name}");
                }
            } 
            return store;
        }

        public List<Model.Item> GetStoreInventory(int id){
            Model.Store store = FindStoreById(id);
            return itemrepo.GetItems(store.Id);

        }

        public void DeleteStore(int id){
            Model.Store store = new Model.Store();
            store.Id = id;
            context.Stores.Find(store.Id);
            context.Remove(store);
        }

        public void DeleteAllStores(){
            context.Stores.ToList().Clear();
        }

        public void AddInventory(Model.Store store, Model.Item item) {
            store.Inventory.Add(item);
            context.SaveChanges();
        }
    }
}