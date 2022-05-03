using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public string CommentDate { get; set; }
        public int MemberId { get; set; }
        public string Context { get; set; }

        public virtual Member Member { get; set; }
        public virtual Post Post { get; set; }
    }
}
