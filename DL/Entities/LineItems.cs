using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class LineItems
    {
        public int LineItemsId { get; set; }
        public int? OrderId { get; set; }
        public int? ItemId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }

        public virtual Items Item { get; set; }
        public virtual Orders Order { get; set; }
    }
}
