using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class Member
    {
        public Member()
        {
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
            PocketListActions = new HashSet<PocketListAction>();
            PocketLists = new HashSet<PocketList>();
            Posts = new HashSet<Post>();
            ShoppingCarts = new HashSet<ShoppingCart>();
        }

        public int MemberId { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string MemberPhoto { get; set; }
        public string Phone { get; set; }
        public string RegistrationDate { get; set; }
        public int ViplevelId { get; set; }

        public virtual Viplevel Viplevel { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PocketListAction> PocketListActions { get; set; }
        public virtual ICollection<PocketList> PocketLists { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
