using System.Collections.Generic;
using Models;
using Entity = DL.Entities;
using System.Linq;

namespace DL{
    public class ItemRepository : IItemRepository{

        private Entity.StoreManagerDbContext context;

        private IStoreRepository storerepo;

        public ItemRepository(Entity.StoreManagerDbContext context){
            this.context = context;
        }
        public void AddItem(Item item){
            context.Add<Item>(item);
        }

        public Item FindItemByName(string name){
            return context.Find<Item>(name);
        }

        public Item FindItemById(int itemid){
            return context.Find<Item>(itemid);
        }

        public List<Item> GetItems(int storeid){
            Store store = storerepo.FindStoreById(storeid);

            var listOfItems = new List<Item>();
            foreach(var ele in store.GetInventory()){
                listOfItems.Append<Item>(ele);
            } 
            return listOfItems;
        }

        public IEnumerable<Item> GetAllItems() {
            return (IEnumerable<Item>)context.Items.ToList();
        }
    }
}