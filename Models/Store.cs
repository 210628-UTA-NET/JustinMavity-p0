using System.Collections.Generic;

namespace Models{
    public class Store{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Item> Inventory { get; set; }
        
        public List<Order> Orders { get; set; }

        public Store(){
        }

        public Store(string name, string address){
            Name = name;
            Address = address;
        }
    }
}