using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            LineItems = new HashSet<LineItems>();
        }

        public int OrderId { get; set; }
        public int? CustId { get; set; }
        public int? StoreId { get; set; }
        public decimal? Price { get; set; }

        public virtual Customers Cust { get; set; }
        public virtual Stores Store { get; set; }
        public virtual ICollection<LineItems> LineItems { get; set; }
    }
}
