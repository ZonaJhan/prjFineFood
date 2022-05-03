using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class PocketListDetail
    {
        public int PocketListDetailId { get; set; }
        public int PocketListId { get; set; }
        public int? CityId { get; set; }
        public int RestaurantId { get; set; }

        public virtual City City { get; set; }
        public virtual PocketList PocketList { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
