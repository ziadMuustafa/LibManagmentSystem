using EF_LibManagmentProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LibManagmentProject.FluentApiConfig
{
    internal class BookApiConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
        {

            builder.HasMany(m => m.members)
                   .WithMany(c => c.Books);


        }


    }
}
