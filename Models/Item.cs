namespace Models{
    public class Item{
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public string Catagory { get; set; }

        public Item(){
        }
        public Item(string name, double price){
            Name = name;
            Price = price;
        }

        public Item(string name, double price, string description){
            Name = name;
            Price = price;
            Description = description;
        }

        public Item(string name, double price, string description, string catagory){
            Name = name;
            Price = price;
            Description = description;
            Catagory = catagory;
        }
    }
}