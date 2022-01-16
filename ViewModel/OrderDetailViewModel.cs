using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resturantAppDel.ViewModel
{
    public class OrderDetailViewModel
    {
        public int OrderDetailsId { get; set; }       
        public Nullable<int> ItemId { get; set; }
        public Nullable<int> UnitPrice { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<int> Quantity { get; set; }

    }
}