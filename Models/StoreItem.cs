namespace Models {
    public class StoreItem {
       
        public int Id { get; set; }
        
        private Store store;
        
        private List<Item> items;

        public StoreItem(){
        }

        public StoreItem(Store store, Item item){
            this.store = store;
            this.item = item;
        }

        public Store GetStore(){
            return store;
        }

        public void SetStore(Store store){
            this.store = store;
        }

        public void SetStore(Store store){
            this.store = store;
        }

        public List<Item> GetItems(){
            return item;
        }

        public void SetItem(List<Item> items){
            this.item = item;
        }

    }
}