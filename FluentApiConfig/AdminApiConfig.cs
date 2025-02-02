using EF_LibManagmentProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LibManagmentProject.FluentApiConfig
{
    internal class AdminApiConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Admin> builder)
        {
            

            builder.HasOne(M => M.Manager)
                   .WithMany(c => c.Admins)
                   .HasForeignKey(f => f.ManagerId)
                   .OnDelete(DeleteBehavior.NoAction); //Cascade





        }
    }
}
