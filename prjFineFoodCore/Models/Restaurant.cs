using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Banners = new HashSet<Banner>();
            Coupons = new HashSet<Coupon>();
            Foods = new HashSet<Food>();
            Orders = new HashSet<Order>();
            PocketListDetails = new HashSet<PocketListDetail>();
            Posts = new HashSet<Post>();
            ShoppingCarts = new HashSet<ShoppingCart>();
            TypeReferences = new HashSet<TypeReference>();
        }

        public int RestaurantId { get; set; }
        public string RestaurantAccount { get; set; }
        public string Password { get; set; }
        public int ZipCode { get; set; }
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Photos { get; set; }
        public string Description { get; set; }
        public string WeekDayOff { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool OrderAvailable { get; set; }
        public string RegistrationDate { get; set; }
        public bool Activited { get; set; }

        public virtual Region ZipCodeNavigation { get; set; }
        public virtual ICollection<Banner> Banners { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PocketListDetail> PocketListDetails { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
        public virtual ICollection<TypeReference> TypeReferences { get; set; }
    }
}
