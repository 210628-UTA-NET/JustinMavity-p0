using System;
using System.Collections.Generic;
using Models;
using DL;

namespace BL {
    public class ItemBL : IItemBL{
        private IItemRepository itemrepo;

        public ItemBL(IItemRepository itemrepo){
            this.itemrepo = itemrepo;
        }

        public IEnumerable<Item> AllItems() {
            return itemrepo.GetAllItems();
        }

        public Item ItemByName(string name){
            return itemrepo.FindItemByName(name);
        }

        public Item ItemById(int itemid){
            return itemrepo.FindItemById(itemid);
        }
    }
}