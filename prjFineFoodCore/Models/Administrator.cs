using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class Administrator
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int UserLevel { get; set; }
    }
}
