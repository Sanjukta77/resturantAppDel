using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resturantAppDel.ViewModel
{
    public class OrderViewModel
    {
        public int CustomerId { get; set; }
        public int PaymentTypeId { get; set; }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> FinalTotal { get; set; }

        public IEnumerable<OrderDetailViewModel> ListOfOrderDetailViewModel { get; set; }
    }
}