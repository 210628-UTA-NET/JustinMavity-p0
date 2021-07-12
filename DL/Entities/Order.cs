using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Order
    {
        public Order()
        {
            LineItems = new HashSet<LineItem>();
        }

        public int OrderId { get; set; }
        public int? CustId { get; set; }
        public int? StoreId { get; set; }
        public decimal? Price { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}
