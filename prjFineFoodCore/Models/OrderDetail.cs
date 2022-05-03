using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public decimal SalePrice { get; set; }
        public int Quantity { get; set; }
        public string Remark { get; set; }

        public virtual Food Food { get; set; }
        public virtual Order Order { get; set; }
    }
}
