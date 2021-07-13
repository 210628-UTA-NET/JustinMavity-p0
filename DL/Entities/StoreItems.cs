using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class StoreItems
    {
        public int Id { get; set; }
        public int? StoreId { get; set; }
        public int? ItemId { get; set; }

        public virtual Items Item { get; set; }
        public virtual Stores Store { get; set; }
    }
}
