using prjFineFoodCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjMVCCoreClass.Models
{
    public class CShoppingCartItem
    {
        public int foodId { get; set; }
        [DisplayName("數量")]
        public int count { get; set; }

        [DisplayName("價格")]
        public decimal price { get; set; }
        public decimal 小計 { get { return this.count * this.price; } }
        public Food food { get; set; }
    }
}
