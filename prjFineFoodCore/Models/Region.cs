using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class Region
    {
        public Region()
        {
            Restaurants = new HashSet<Restaurant>();
        }

        public int ZipCode { get; set; }
        public string AdminDisct { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
