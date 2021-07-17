using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySach.ViewModel
{
    public class SachViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Content { get; set; }
    }
}