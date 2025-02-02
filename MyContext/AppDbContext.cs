using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EF_LibManagmentProject.FluentApiConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_LibManagmentProject.Models;

namespace EF_LibManagmentProject.MyContext
{
    internal class AppDbContext : DbContext
    {


        //1- Overried OnConfiguring() method to configure the connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var Config = new ConfigurationBuilder().AddJsonFile("Configurations\\Configurations.json")
                                                    .Build();


            string connectionString = Config.GetSection("ConnString")
                                             .Value;


            optionsBuilder.UseSqlServer(connectionString);
        }




        //2- Adding DbSets for each model class
        public DbSet<Models.Admin> Admins { get; set; }
        public DbSet<Models.Author> Authors { get; set; }
        public DbSet<Models.Book> Books { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Member> Members { get; set; }




        //3- Overried OnModelCreating() method to configure the relationships

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //1- AdminApiConfig
            new AdminApiConfig().Configure(modelBuilder.Entity<Admin>());

            //2- AuthorApiConfig
            new AuthorApiConfig().Configure(modelBuilder.Entity<Author>());

            //3- BookApiConfig
            new BookApiConfig().Configure(modelBuilder.Entity<Book>());

            //4- CategoryApiConfig
            new CatigoryApiConfig().Configure(modelBuilder.Entity<Category>());

            //5- MemberApiConfig
            new MemberApiConfig().Configure(modelBuilder.Entity<Member>());



        }


    }
}
