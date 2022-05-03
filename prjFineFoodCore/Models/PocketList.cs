using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class PocketList
    {
        public PocketList()
        {
            PocketListActions = new HashSet<PocketListAction>();
            PocketListDetails = new HashSet<PocketListDetail>();
        }

        public int PocketListId { get; set; }
        public string PocketListName { get; set; }
        public int MemberId { get; set; }
        public bool IsPublic { get; set; }

        public virtual Member Member { get; set; }
        public virtual ICollection<PocketListAction> PocketListActions { get; set; }
        public virtual ICollection<PocketListDetail> PocketListDetails { get; set; }
    }
}
