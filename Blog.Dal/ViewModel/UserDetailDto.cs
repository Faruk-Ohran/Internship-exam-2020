using Blog.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Dal.ViewModel
{
    public class UserDetailDto
    {
        public UserDetailDto()
        {

        }
        public UserDetailDto(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Age = user.Age;
            Email = user.Email;
            Blogs = user.Blogs;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime PublishedAt { get; set; }
        public IReadOnlyCollection<UserBlog> Blogs { get; set; }
        public string LinkProfile { get; set; }
    }
}
