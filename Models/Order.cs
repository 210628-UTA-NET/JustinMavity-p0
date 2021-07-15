using System.Collections.Generic;

namespace Models{
    public class Order{
        public int Id { get; set; }

        private Store store;

        private Customer customer;

        private decimal price;

        private List<Item> items;


        public Order(){
        }

        public Order(Store store, Customer customer){
            this.store= store;
            this.customer = customer;
        }
        
        public Store GetStore(){
            return store;
        }

        public void SetStore(Store store){
            this.store = store;
        }

        public Customer GetCustomer(){
            return customer;
        }

        public void SetCustomer(Customer customer){
            this.customer = customer;
        }

        public decimal GetPrice(){
            return price;
        }

        public void SetPrice(decimal price){
            this.price = price;
        }

        public List<Item> GetItems(){
            return items;
        }

        public void SetItems(List<Item> items){
            this.items = items;
        }
    }
}