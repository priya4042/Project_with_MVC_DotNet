using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1_codefirst_mvc.Models;

namespace WebApplication1_codefirst_mvc.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("min")
        {
                
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject>Subjects{ get; set; }
    }
}