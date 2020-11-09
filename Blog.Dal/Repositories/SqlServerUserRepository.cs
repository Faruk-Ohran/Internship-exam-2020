using Blog.Dal.Context;
using Blog.Dal.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.Dal.Repositories
{
    public class SqlServerUserRepository : IUserRepository
    {
        private readonly BlogDbContext _blogDbContext;
        public SqlServerUserRepository(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }

        public async Task<UserDetailsViewModel> GetById(int id, CancellationToken cancellationToken = default)
        {
            var user = await _blogDbContext.Users.Include(b => b.Blogs).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            return new UserDetailsViewModel(user);
        }

        public async Task<UserViewModel> GetTopTen(CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;
            var collection = 
                await _blogDbContext.Users
                .Take(maxTop)
                .Include(blog => blog.Blogs)
                .OrderBy(n => n.Name)
                .ToListAsync(cancellationToken);
            return new UserViewModel(collection);
        }

        public async Task<UserViewModel> Search(string name, CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;

            var booksNameCollection =
                await _blogDbContext.Users
                .Where(b => b.Name.ToLower()
                .IndexOf(name.ToLower()) != -1 
                || 
                b.Email.ToLower()
                .IndexOf(name.ToLower()) != -1)
                .Include(blog => blog.Blogs)
                .ToListAsync(cancellationToken);

            var collection = booksNameCollection.Take(maxTop).ToList();
            return new UserViewModel(collection);
        }
    }
}
