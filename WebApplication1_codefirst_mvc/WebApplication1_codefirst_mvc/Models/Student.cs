using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1_codefirst_mvc.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Student Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Student Address")]
        public string Address { get; set; }
        [Required]
        [Display (Name ="Email")]
        public string Email { get; set; }

        
    }
}