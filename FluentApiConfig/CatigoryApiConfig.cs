using Microsoft.EntityFrameworkCore;
using EF_LibManagmentProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LibManagmentProject.FluentApiConfig
{
    internal class CatigoryApiConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            
        }
    }
}
