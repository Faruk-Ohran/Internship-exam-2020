using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Dal.Domain
{
    public class UserBlog : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
