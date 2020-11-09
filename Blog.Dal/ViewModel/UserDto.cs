using Blog.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Dal.ViewModel
{
    public class UserDto
    {
        public UserDto()
        {

        }
        public UserDto(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Age = user.Age;
            Email = user.Email;
            Blogs = user.Blogs.Count;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Blogs { get; set; }
    }
}
