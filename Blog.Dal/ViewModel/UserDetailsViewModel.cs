using Blog.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Dal.ViewModel
{
    public class UserDetailsViewModel
    {
        public UserDetailsViewModel(User user)
        {
            User = new UserDetailDto(user);
        }
        public UserDetailsViewModel(IReadOnlyCollection<User> users)
        {
            Collection = users.Select(user => new UserDetailDto(user)).ToList();
        }
        public IReadOnlyCollection<UserDetailDto> Collection { get; set; }
        public UserDetailDto User { get; set; }
    }
}
