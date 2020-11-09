using Blog.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Dal.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel(IReadOnlyCollection<User> users)
        {
            Collection = users.Select(user => new UserDto(user)).ToList();
        }
        public IReadOnlyCollection<UserDto> Collection { get; set; }
    }
}
