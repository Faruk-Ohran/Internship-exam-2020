using Blog.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Dal.Configuration
{
    public class UserBlogConfiguration : BaseEntityConfiguration<UserBlog>
    {
        public override void Configure(EntityTypeBuilder<UserBlog> builder)
        {
            base.Configure(builder);

            builder
                .Property(b => b.UserId)
                .IsRequired();

            builder
                .Property(b => b.Title)
                .IsRequired();

            builder
                .Property(b => b.Summary)
                .IsRequired();

            builder
                .HasOne(u => u.User)
                .WithMany(b => b.Blogs)
                .HasForeignKey(u => u.UserId);

            builder
                .HasData(new List<UserBlog> { 
                new UserBlog { Id = 1, UserId = 1, Title = "Naslov1", Summary = "Summary", Content = "Prvi blog content", PublishedAt = DateTime.UtcNow },
                new UserBlog { Id = 2, UserId = 1, Title = "Naslov2", Summary = "Summary", Content = "Prvi blog content", PublishedAt = DateTime.UtcNow },
                new UserBlog { Id = 3, UserId = 1, Title = "Naslov3", Summary = "Summary", Content = "Prvi blog content", PublishedAt = DateTime.UtcNow },
                new UserBlog { Id = 4, UserId = 1, Title = "Naslov4", Summary = "Summary", Content = "Prvi blog content", PublishedAt = DateTime.UtcNow },
                new UserBlog { Id = 5, UserId = 3, Title = "Naslov1", Summary = "Summary", Content = "Prvi blog content", PublishedAt = DateTime.UtcNow },
                new UserBlog { Id = 6, UserId = 3, Title = "Naslov2", Summary = "Summary", Content = "Prvi blog content", PublishedAt = DateTime.UtcNow },
                new UserBlog { Id = 7, UserId = 3, Title = "Naslov3", Summary = "Summary", Content = "Prvi blog content", PublishedAt = DateTime.UtcNow },
                });
        }
    }
}
