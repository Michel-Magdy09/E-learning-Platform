﻿// <auto-generated />
using System;
using E_learning_Platform.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_learning_Platform.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241016111005_AddVideoUrlColumToCourseTableAndSeeding")]
    partial class AddVideoUrlColumToCourseTableAndSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_learning_Platform.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("E_learning_Platform.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CourseRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FieldOfStudy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstructorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseRate = 0m,
                            Description = "Learn the basics of Python programming, from syntax to algorithms.",
                            FieldOfStudy = "Computer Science",
                            ImageUrl = "python.jpg",
                            InstructorName = "John Doe",
                            Name = "Introduction to Python",
                            Price = 199.99m,
                            VideoUrl = "https://www.youtube.com/watch?v=kqtD5dpn9C8&ab_channel=ProgrammingwithMosh"
                        },
                        new
                        {
                            Id = 2,
                            CourseRate = 0m,
                            Description = "A beginner's guide to digital marketing and online strategies.",
                            FieldOfStudy = "Marketing",
                            ImageUrl = "digital_marketing.jpg",
                            InstructorName = "Jane Smith",
                            Name = "Digital Marketing 101",
                            Price = 149.99m,
                            VideoUrl = "https://www.youtube.com/watch?v=nU-IIXBWlS4&ab_channel=Simplilearn"
                        },
                        new
                        {
                            Id = 3,
                            CourseRate = 0m,
                            Description = "Explore data analysis techniques, statistics, and machine learning basics.",
                            FieldOfStudy = "Data Science",
                            ImageUrl = "data_science.jpg",
                            InstructorName = "Dr. Sarah Lee",
                            Name = "Data Science Fundamentals",
                            Price = 499.99m,
                            VideoUrl = "https://www.youtube.com/watch?v=ua-CiDNNj30&ab_channel=Simplilearn"
                        },
                        new
                        {
                            Id = 4,
                            CourseRate = 0m,
                            Description = "Improve your creative writing skills through interactive sessions.",
                            FieldOfStudy = "Literature",
                            ImageUrl = "creative_writing.jpg",
                            InstructorName = "Robert Martin",
                            Name = "Creative Writing Workshop",
                            Price = 129.99m,
                            VideoUrl = "https://www.youtube.com/watch?v=b2fyFJ_GHz8&ab_channel=TheCreativePenn"
                        },
                        new
                        {
                            Id = 5,
                            CourseRate = 0m,
                            Description = "An introductory course on financial accounting and bookkeeping.",
                            FieldOfStudy = "Finance",
                            ImageUrl = "financial_accounting.jpg",
                            InstructorName = "Anna Brown",
                            Name = "Financial Accounting for Beginners",
                            Price = 299.99m,
                            VideoUrl = "https://www.youtube.com/watch?v=YYFb82XDpAc&ab_channel=AccountingStuff"
                        },
                        new
                        {
                            Id = 6,
                            CourseRate = 0m,
                            Description = "Master advanced JavaScript concepts such as closures, asynchronous programming, and more.",
                            FieldOfStudy = "Computer Science",
                            ImageUrl = "javascript.jpg",
                            InstructorName = "Michael Johnson",
                            Name = "Advanced JavaScript",
                            Price = 249.99m,
                            VideoUrl = "https://www.youtube.com/watch?v=QO4NXhWo_NM&ab_channel=TraversyMedia"
                        },
                        new
                        {
                            Id = 7,
                            CourseRate = 0m,
                            Description = "Learn the fundamentals of UX/UI design and how to create user-friendly interfaces.",
                            FieldOfStudy = "Design",
                            ImageUrl = "uiux.jpg",
                            InstructorName = "Emily Clark",
                            Name = "Introduction to UX/UI Design",
                            Price = 179.99m,
                            VideoUrl = "https://www.youtube.com/watch?v=3gHgxAf3e9Q&ab_channel=AJ%26Smart"
                        },
                        new
                        {
                            Id = 8,
                            CourseRate = 0m,
                            Description = "A course for beginners to understand the basics of project management methodologies and tools.",
                            FieldOfStudy = "Management",
                            ImageUrl = "project_management.jpg",
                            InstructorName = "David Williams",
                            Name = "Project Management Essentials",
                            Price = 199.99m,
                            VideoUrl = "https://www.youtube.com/watch?v=_ljLREvx5zo&ab_channel=Simplilearn"
                        },
                        new
                        {
                            Id = 9,
                            CourseRate = 0m,
                            Description = "Learn the essentials of Adobe Photoshop for image editing and graphic design.",
                            FieldOfStudy = "Design",
                            ImageUrl = "photoshop.jpg",
                            InstructorName = "Sophia White",
                            Name = "Mastering Adobe Photoshop",
                            Price = 159.99m,
                            VideoUrl = "https://www.youtube.com/watch?v=Ouv4qkDQ-w8&ab_channel=EnvatoTuts%2B"
                        },
                        new
                        {
                            Id = 10,
                            CourseRate = 0m,
                            Description = "An introductory course to understand blockchain technology and cryptocurrencies.",
                            FieldOfStudy = "Finance",
                            ImageUrl = "cryptocurrency.jpg",
                            InstructorName = "Chris Thompson",
                            Name = "Blockchain and Cryptocurrency Basics",
                            Price = 399.99m,
                            VideoUrl = "https://www.youtube.com/watch?v=SSo_EIwHSd4&ab_channel=Simplilearn"
                        });
                });

            modelBuilder.Entity("E_learning_Platform.Models.Enrollement", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal>("CourseRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Enrollement");
                });

            modelBuilder.Entity("E_learning_Platform.Models.UserCoursesCart", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCoursesCart");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "84fd0f35-5948-4fd2-819b-9d38693a2f9c",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "0c9ad23a-d23e-4c9d-aaa8-485e04f3e005",
                            Name = "student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("E_learning_Platform.Models.Enrollement", b =>
                {
                    b.HasOne("E_learning_Platform.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_learning_Platform.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_learning_Platform.Models.UserCoursesCart", b =>
                {
                    b.HasOne("E_learning_Platform.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_learning_Platform.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("E_learning_Platform.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("E_learning_Platform.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_learning_Platform.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("E_learning_Platform.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
