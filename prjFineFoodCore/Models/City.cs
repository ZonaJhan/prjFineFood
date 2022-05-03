using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class City
    {
        public City()
        {
            PocketListDetails = new HashSet<PocketListDetail>();
            Regions = new HashSet<Region>();
        }

        public int CityId { get; set; }
        public string City1 { get; set; }
        public string CityPhoto { get; set; }

        public virtual ICollection<PocketListDetail> PocketListDetails { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
