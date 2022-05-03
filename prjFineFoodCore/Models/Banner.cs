using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class Banner
    {
        public int BannerId { get; set; }
        public int RestaurantId { get; set; }
        public string BannerName { get; set; }
        public string BannerPhoto { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
