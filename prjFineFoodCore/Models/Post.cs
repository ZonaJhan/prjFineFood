using System;
using System.Collections.Generic;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }
        public int MemberId { get; set; }
        public int RestaurantId { get; set; }
        public string PostContent { get; set; }
        public string Rating { get; set; }
        public string PostDate { get; set; }
        public string Photos { get; set; }
        public int ZipCode { get; set; }

        public virtual Member Member { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
