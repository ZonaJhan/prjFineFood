using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class Viplevel
    {
        public Viplevel()
        {
            Members = new HashSet<Member>();
        }

        public int ViplevelId { get; set; }
        public int Viplevel1 { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
