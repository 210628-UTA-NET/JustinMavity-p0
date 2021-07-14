using System;

namespace Models {
    public class LineItem {
        private Item items;
        private int quantity;

        public int LineItemId { get; set; }
        public Item Items{
            get{
                return items;
            }
            set {
                items = value;
            }
        }
        public int Quantity{
            get{
                return quantity;
            }
            set{
                quantity = value;
            }
        }
        public override string ToString()
        {
            return $"{Items}, Quantity: {Quantity}";
        }
    }
}