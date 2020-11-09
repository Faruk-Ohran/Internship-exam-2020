using Blog.Dal.Context;
using Blog.Dal.Domain;
using Blog.Dal.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.Dal.Repositories
{
    public class SqlServerUserBlogRepository : IUserBlogRepository
    {
        private readonly BlogDbContext _blogDbContext;
        public SqlServerUserBlogRepository(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }
        public async Task<UserBlogUpdateViewModel> Add(UserBlogUpdateDto blog, CancellationToken cancellationToken = default)
        {
            var blogDomain = new UserBlog
            {
                Title = blog.Title,
                Summary = blog.Summary,
                Content = blog.Content,
                PublishedAt = blog.PublishedAt,
                UserId = blog.UserId
            };

            await _blogDbContext.Blogs.AddAsync(blogDomain, cancellationToken);
            await _blogDbContext.SaveChangesAsync(cancellationToken);
            return new UserBlogUpdateViewModel(blogDomain); 
        
        }

        public async Task Update(UserBlogUpdateDto blog, CancellationToken cancellationToken = default)
        {
            var blogDomain = await _blogDbContext.Blogs.FirstOrDefaultAsync(x => x.Id == blog.Id, cancellationToken);

            blogDomain.Id = blog.Id;
            blogDomain.UserId = blog.UserId;
            blogDomain.Title = blog.Title;
            blogDomain.Summary = blog.Summary;
            blogDomain.Content = blog.Content;
            blogDomain.PublishedAt = blog.PublishedAt;


            _blogDbContext.Blogs.Update(blogDomain);
            await _blogDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
