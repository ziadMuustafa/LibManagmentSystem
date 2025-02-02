using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LibManagmentProject.Models
{
    internal class Author
    {
        [Key]
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Nationality { get; set; }



        public List<Book> Books { get; set; }   
    }
}
