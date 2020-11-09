using Blog.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Dal.ViewModel
{
    public class UserBlogUpdateViewModel
    {
        public UserBlogUpdateViewModel(UserBlog blog)
        {
            Blog = new UserBlogUpdateDto(blog);
        }
        
        public UserBlogUpdateDto Blog { get; set; }
    }
}
