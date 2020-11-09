using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Blog.Dal.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public IReadOnlyCollection<UserBlog> Blogs { get; set; }
    }
}
