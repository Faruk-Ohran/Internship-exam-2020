using Blog.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Dal.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder
                .Property(b => b.Name)
                .IsRequired();

            builder
                .Property(b => b.Age)
                .IsRequired();

            builder
                .Property(b => b.Email)
                .IsRequired();

            builder
                .HasMany(b => b.Blogs)
                .WithOne(u => u.User)
                .HasForeignKey(b => b.UserId);

            builder
                .HasData(new List<User> { 
                new User { Id = 1, Name = "Faruk", Age = 22, Email = "ohran.faruk@hotmail.com" },
                new User { Id = 2, Name = "Jasir", Age = 22, Email = "jasir.buric@hotmail.com" },
                new User { Id = 3, Name = "Muhamed", Age = 22, Email = "muhamed.halkic@hotmail.com" },
                new User { Id = 4, Name = "Mirzad", Age = 22, Email = "mirzad.varupa@hotmail.com" },
                new User { Id = 5, Name = "Haris", Age = 22, Email = "haris.mlaco@hotmail.com" },
                new User { Id = 6, Name = "Ahmed", Age = 22, Email = "ahmed.terzic@hotmail.com" },
                new User { Id = 7, Name = "Ajdin", Age = 22, Email = "ajdin.tabak@hotmail.com" },
                });
        }
    }
}
