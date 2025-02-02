using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LibManagmentProject.Models
{
    internal class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberEmail { get; set; }


        //[ForeignKey("Book")]
        //public int BookId { get; set; }
        public List<Book> Books { get; set; }



    }
}
