using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class LineItem
    {
        public int LineItemsId { get; set; }
        public int? OrderId { get; set; }
        public int? ItemId { get; set; }
        public int? Quantity { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
