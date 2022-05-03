using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class Food
    {
        public Food()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ShoppingCarts = new HashSet<ShoppingCart>();
        }

        public int FoodId { get; set; }
        public int RestaurantId { get; set; }
        [DisplayName("餐點名稱")]
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public bool Available { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
