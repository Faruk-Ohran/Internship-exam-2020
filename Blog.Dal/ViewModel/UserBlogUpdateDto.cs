using Blog.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Dal.ViewModel
{
    public class UserBlogUpdateDto
    {
        public UserBlogUpdateDto()
        {

        }
        public UserBlogUpdateDto(UserBlog blog)
        {
            Id = blog.Id;
            UserId = blog.UserId;
            Title = blog.Title;
            Summary = blog.Summary;
            Content = blog.Content;
            PublishedAt = blog.PublishedAt;
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
