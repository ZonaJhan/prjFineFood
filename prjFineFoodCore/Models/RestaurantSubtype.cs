using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class RestaurantSubtype
    {
        public RestaurantSubtype()
        {
            TypeReferences = new HashSet<TypeReference>();
        }

        public int RestaurantSubtypeId { get; set; }
        public int RestaurantTypeId { get; set; }
        public string RestaurantSubtype1 { get; set; }

        public virtual RestaurantType RestaurantType { get; set; }
        public virtual ICollection<TypeReference> TypeReferences { get; set; }
    }
}
