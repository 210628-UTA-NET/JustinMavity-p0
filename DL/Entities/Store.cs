﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Order>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public int? ItemId { get; set; }

        public virtual Item Item { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
