using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class PocketListAction
    {
        public int ActionRecordId { get; set; }
        public int MemberId { get; set; }
        public int ActionId { get; set; }
        public int PocketListId { get; set; }

        public virtual ActionType Action { get; set; }
        public virtual Member Member { get; set; }
        public virtual PocketList PocketList { get; set; }
    }
}
