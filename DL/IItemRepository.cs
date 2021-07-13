using System;
using System.Collections.Generic;
using Models;
namespace DL{
    public interface IItemRepository {
        IEnumerable<Item> GetAllItems();

        List<Item> GetItems(int storeid);

        void AddItem(Item item);

        Item FindItemByName(string name);

        Item FindItemById(int itemid); 
    }
}