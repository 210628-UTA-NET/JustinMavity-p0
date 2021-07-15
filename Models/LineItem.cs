using System;

namespace Models {
    public class LineItem {

        private Store store;
        private Item item;
        private int quantity;

        public int LineItemId { get; set; }
        
        public LineItem(Store store, Item item){
            this.store = store;
            this.item = item;
        }

        public Store GetStore(){
            return store;
        }

        public void SetStore(Store store){
            this.store = store;
        }

        public Item GetItem(){
            return item;
        }

        public void SetItem(Item item){
            this.item = item;
        }

        public int GetQuantity(){
            return quantity;
        }

        public void SetQuantity(int quantity){
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return $"{GetItem()}, Quantity: {GetQuantity()}";
        }
    }
}