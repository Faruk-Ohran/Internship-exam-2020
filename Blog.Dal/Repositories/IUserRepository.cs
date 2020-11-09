using Blog.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.Dal.Repositories
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetTopTen(CancellationToken cancellationToken = default);
        Task<UserViewModel> Search(string name, CancellationToken cancellationToken = default);
        Task<UserDetailsViewModel> GetById(int id, CancellationToken cancellationToken = default);
    }
}
