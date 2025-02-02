﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LibManagmentProject.Models
{
    internal class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }


        //[ForeignKey("Member")]  
        //public int MemberId { get; set; }   
        public List<Member> members { get; set; }


        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }



        [ForeignKey("Author")]
        public int AuthorId { get; set; }   
        public Author author { get; set; }
    }
}
