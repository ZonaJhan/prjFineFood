using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class Coupon
    {
        public Coupon()
        {
            Orders = new HashSet<Order>();
        }

        public int CouponId { get; set; }
        public int RestaurantId { get; set; }
        public string Discount { get; set; }
        public string DiscountDescription { get; set; }
        public string ValidDate { get; set; }
        public string InvalidDate { get; set; }
        public string Photo { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
