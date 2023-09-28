using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using WebApplication1_mvcwithdatabase.Models;

namespace WebApplication1_mvcwithdatabase.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext():base("dbase")
        {

        }
        public DbSet<Student> Student { get; set; }
        public  DbSet<Subject> Subject { get; set; }

    }
}