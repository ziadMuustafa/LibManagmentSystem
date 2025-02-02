using EF_LibManagmentProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LibManagmentProject.FluentApiConfig
{
    internal class MemberApiConfig : IEntityTypeConfiguration<Member>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Member> builder)
        {
            
        }
    }
}
