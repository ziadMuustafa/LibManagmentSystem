﻿// <auto-generated />
using EF_LibManagmentProject.MyContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_LibManagmentProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241224155246_Mig5")]
    partial class Mig5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookMember", b =>
                {
                    b.Property<int>("BooksBookID")
                        .HasColumnType("int");

                    b.Property<int>("membersMemberId")
                        .HasColumnType("int");

                    b.HasKey("BooksBookID", "membersMemberId");

                    b.HasIndex("membersMemberId");

                    b.ToTable("BookMember");
                });

            modelBuilder.Entity("EF_LibManagmentProject.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("AdminEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EF_LibManagmentProject.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("EF_LibManagmentProject.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("EF_LibManagmentProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EF_LibManagmentProject.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"));

                    b.Property<string>("MemberEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("BookMember", b =>
                {
                    b.HasOne("EF_LibManagmentProject.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_LibManagmentProject.Models.Member", null)
                        .WithMany()
                        .HasForeignKey("membersMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_LibManagmentProject.Models.Admin", b =>
                {
                    b.HasOne("EF_LibManagmentProject.Models.Admin", "Manager")
                        .WithMany("Admins")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("EF_LibManagmentProject.Models.Book", b =>
                {
                    b.HasOne("EF_LibManagmentProject.Models.Author", "author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_LibManagmentProject.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("author");
                });

            modelBuilder.Entity("EF_LibManagmentProject.Models.Admin", b =>
                {
                    b.Navigation("Admins");
                });

            modelBuilder.Entity("EF_LibManagmentProject.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EF_LibManagmentProject.Models.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
