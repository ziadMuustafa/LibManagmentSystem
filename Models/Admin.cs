using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LibManagmentProject.Models
{
    internal class Admin
    {

        [Key]
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminEmail { get; set; }



        //To performing unary relationship

        [ForeignKey("Admin")]
        public int? ManagerId { get; set; }  //ForignKey
        public Admin Manager { get; set; }  //Navigation Property
        public ICollection<Admin> Admins { get; set; }  //Navigation Property

    }
}
