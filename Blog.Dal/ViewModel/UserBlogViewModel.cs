using Blog.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Dal.ViewModel
{
    public class UserBlogViewModel
    {
        public UserBlogViewModel(UserBlog blog)
        {
            Blog = new UserBlogDto(blog);
        }
        public UserBlogViewModel(IReadOnlyCollection<UserBlog> blogs )
        {
            Collection = blogs.Select(blog => new UserBlogDto(blog)).ToList();
        }
        public IReadOnlyCollection<UserBlogDto> Collection { get; set; }
        public UserBlogDto Blog { get; set; }
    }
}
