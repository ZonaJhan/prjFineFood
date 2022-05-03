using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class ActionType
    {
        public ActionType()
        {
            PocketListActions = new HashSet<PocketListAction>();
        }

        public int ActionId { get; set; }
        public string ActionName { get; set; }

        public virtual ICollection<PocketListAction> PocketListActions { get; set; }
    }
}
