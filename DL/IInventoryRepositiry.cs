using System;
using System.Collections.Generic;
using Models;

namespace DL {
    public interface IInventoryRepositiry {
         List<Item> GetAllInventory(Store store);

         LineItem ChangeInventory(Store store, LineItem lineItems);
    }
}