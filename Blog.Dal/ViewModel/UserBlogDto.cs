using Blog.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Dal.ViewModel
{
    public class UserBlogDto
    {
        public UserBlogDto()
        {

        }
        public UserBlogDto(UserBlog blog)
        {
            Id = blog.Id;
            Title = blog.Title;
            Summary = blog.Summary;
            PublishedAt = blog.PublishedAt;
            Content = blog.Content;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
