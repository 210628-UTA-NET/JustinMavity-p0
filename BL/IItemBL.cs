using Models;
using System.Collections.Generic;

namespace BL{
    public interface IItemBL{
        IEnumerable<Item> AllItems();

        Item ItemByName(string name);

        Item ItemById(int itemid);
    }
}