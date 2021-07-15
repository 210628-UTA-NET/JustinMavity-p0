using System.Collections.Generic;

namespace Models{
    public class Store{
        public int Id { get; set; }
        private string name;
        private string address;

        private List<Item> inventory;
        
        private List<Order> orders;

        public Store(){
        }

        public Store(string name, string address){
            this.name = name;
            this.address = address;
        }

        public string GetName(){
            return name;
        }

        public void SetName(string name){
            this.name = name;
        }

        public string GetAddress(){
            return address;
        }

        public void SetAddress(string address){
            this.address = address;
        }

        public List<Item> GetInventory(){
            return inventory;
        }

        public void SetInventory(List<Item> inventory){
            this.inventory = inventory;
        }

        public List<Order> GetOrders(){
            return orders;
        }

        public void SetOrders(List<Order> orders){
            this.orders = orders;
        }
    }
}