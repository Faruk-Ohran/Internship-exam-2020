using Blog.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.Dal.Repositories
{
    public interface IUserBlogRepository
    {
        Task<UserBlogUpdateViewModel> Add(UserBlogUpdateDto blog, CancellationToken cancellationToken = default);
        Task Update(UserBlogUpdateDto blog, CancellationToken cancellationToken = default);
    }
}
