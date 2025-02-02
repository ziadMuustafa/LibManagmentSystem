﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LibManagmentProject.Models
{
    internal class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }


        public List<Book> Books { get; set; }
    }
}
