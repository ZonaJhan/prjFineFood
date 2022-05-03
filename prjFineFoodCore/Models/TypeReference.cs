using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class TypeReference
    {
        public int ReferenceId { get; set; }
        public int RestaurantId { get; set; }
        public int RestaurantSubtypeId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual RestaurantSubtype RestaurantSubtype { get; set; }
    }
}
