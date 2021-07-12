using System.Collections.Generic;

namespace Models{
    public class Order{
        public int Id { get; set; }

        public Store Store { get ; set; }

        public List<Item> Items { get; } = new List<Item>();

        public double Price { get; set; }

        public Order(){
        }

        public Order(Store store, List<Item> items){
            Store = store;
            Items = items;

        }
        
    }
}