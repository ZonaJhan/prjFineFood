using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class ShoppingCart
    {
        public int CartId { get; set; }
        public int MemberId { get; set; }
        public int RestaurantId { get; set; }
        public int FoodId { get; set; }
        public decimal SalePrice { get; set; }
        public int Quantity { get; set; }

        public virtual Food Food { get; set; }
        public virtual Member Member { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
