using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Items
    {
        public Items()
        {
            LineItems = new HashSet<LineItems>();
            StoreItems = new HashSet<StoreItems>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? Price { get; set; }
        public string ItemDescription { get; set; }
        public string ItemCatagory { get; set; }

        public virtual ICollection<LineItems> LineItems { get; set; }
        public virtual ICollection<StoreItems> StoreItems { get; set; }
    }
}
