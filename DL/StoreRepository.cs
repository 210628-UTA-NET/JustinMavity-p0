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
            return (IEnumerable<Model.Store>)context.Stores.ToList();
        }
        public Model.Store FindStoreById(int storeid) {
            return context.Find<Model.Store>(storeid);
        }

        public Model.Store FindStoreByName(string name){
            return context.Find<Model.Store>(name);
        }

        public List<Model.Item> GetStoreInventory(int id){
            Model.Store store = FindStoreById(id);
            return itemrepo.GetItems(store.Id);

        }

        public void DeleteStore(int id){
            context.Remove<Model.Store>(FindStoreById(id));
        }

        public void DeleteAllStores(){
            var listOfStores = GetAllStores();
            context.Remove<Model.Store>((Model.Store)listOfStores);
        }

        public void AddInventory(Model.Store store, Model.Item item) {
            store.GetInventory().Add(item);
            context.SaveChanges();
        }
    }
}