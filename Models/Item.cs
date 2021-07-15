namespace Models{
    public class Item{
        public int Id { get; set; }
        private string name;
        private double price;
        private string description;

        private string catagory;

        public Item(){
        }
        public Item(string name, double price){
            this.name = name;
            this.price = price;
        }

        public Item(string name, double price, string description){
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public Item(string name, double price, string description, string catagory){
            this.name = name;
            this.price = price;
            this.description = description;
            this.catagory = catagory;
        }

        public string GetName(){
            return name;
        }

        public void SetName(string name){
            this.name = name;
        }

        public double GetPrice(){
            return price;
        }

        public void SetPrice(double price){
            this.price = price;
        }

        public string GetDescription(){
            return description;
        }

        public void SetDescription(string description){
            this.description = description;
        }

        public string GetCatagory(){
            return catagory;
        }

        public void SetCatagory(string catagory){
            this.catagory = catagory;
        }
    }
}