using System.Collections.Generic;

namespace Models{
    public class Order{
        public int Id { get; set; }

        public int? StoreId { get ; set; }

        public int? CustomerId {get; set;}

        public decimal Price{get; set;}

        public List<Item> Items { get; set; } 


        public Order(){
        }

        public Order(int storeId, int customerId){
            StoreId= storeId;
            CustomerId = customerId;
        }
        
    }
}