using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class RestaurantType
    {
        public RestaurantType()
        {
            RestaurantSubtypes = new HashSet<RestaurantSubtype>();
        }

        public int RestaurantTypeId { get; set; }
        public string Types { get; set; }
        public byte[] RestaurantTypePhotos { get; set; }

        public virtual ICollection<RestaurantSubtype> RestaurantSubtypes { get; set; }
    }
}
