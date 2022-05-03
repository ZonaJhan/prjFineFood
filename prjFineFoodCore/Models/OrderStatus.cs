using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Orders = new HashSet<Order>();
        }

        public int OrderStatusId { get; set; }
        public string OrderStatus1 { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
