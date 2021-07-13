using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Stores
    {
        public Stores()
        {
            Orders = new HashSet<Orders>();
            StoreItems = new HashSet<StoreItems>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<StoreItems> StoreItems { get; set; }
    }
}
