using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Item
    {
        public Item()
        {
            LineItems = new HashSet<LineItem>();
            Stores = new HashSet<Store>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? Price { get; set; }
        public string ItemDescription { get; set; }
        public string ItemCatagory { get; set; }

        public virtual ICollection<LineItem> LineItems { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
