﻿// <auto-generated />
using System;
using Blog.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.Dal.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20201109100516_DataSeedAdded")]
    partial class DataSeedAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blog.Dal.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            Email = "ohran.faruk@hotmail.com",
                            Name = "Faruk"
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            Email = "jasir.buric@hotmail.com",
                            Name = "Jasir"
                        },
                        new
                        {
                            Id = 3,
                            Age = 22,
                            Email = "muhamed.halkic@hotmail.com",
                            Name = "Muhamed"
                        },
                        new
                        {
                            Id = 4,
                            Age = 22,
                            Email = "mirzad.varupa@hotmail.com",
                            Name = "Mirzad"
                        },
                        new
                        {
                            Id = 5,
                            Age = 22,
                            Email = "haris.mlaco@hotmail.com",
                            Name = "Haris"
                        },
                        new
                        {
                            Id = 6,
                            Age = 22,
                            Email = "ahmed.terzic@hotmail.com",
                            Name = "Ahmed"
                        },
                        new
                        {
                            Id = 7,
                            Age = 22,
                            Email = "ajdin.tabak@hotmail.com",
                            Name = "Ajdin"
                        });
                });

            modelBuilder.Entity("Blog.Dal.Domain.UserBlog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Prvi blog content",
                            PublishedAt = new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(4543),
                            Summary = "Summary",
                            Title = "Naslov1",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Prvi blog content",
                            PublishedAt = new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5200),
                            Summary = "Summary",
                            Title = "Naslov2",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "Prvi blog content",
                            PublishedAt = new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5215),
                            Summary = "Summary",
                            Title = "Naslov3",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Content = "Prvi blog content",
                            PublishedAt = new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5217),
                            Summary = "Summary",
                            Title = "Naslov4",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            Content = "Prvi blog content",
                            PublishedAt = new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5219),
                            Summary = "Summary",
                            Title = "Naslov1",
                            UserId = 3
                        },
                        new
                        {
                            Id = 6,
                            Content = "Prvi blog content",
                            PublishedAt = new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5224),
                            Summary = "Summary",
                            Title = "Naslov2",
                            UserId = 3
                        },
                        new
                        {
                            Id = 7,
                            Content = "Prvi blog content",
                            PublishedAt = new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5225),
                            Summary = "Summary",
                            Title = "Naslov3",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Blog.Dal.Domain.UserBlog", b =>
                {
                    b.HasOne("Blog.Dal.Domain.User", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
