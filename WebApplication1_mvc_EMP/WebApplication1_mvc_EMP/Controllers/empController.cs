using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_mvc_EMP.Models;

namespace WebApplication1_mvc_EMP.Controllers
{
    public class empController : Controller
    {
        // GET: emp
        public ActionResult Index()
        {
            List<Employee> obj = new List<Employee>();
            obj.Add(new Employee { empno = 1, Name = "Amit", Address = "chd", salary = 5000 });
            obj.Add(new Employee { empno = 2, Name = "Sachin", Address = "matour", salary = 4000 });
            obj.Add(new Employee { empno = 3, Name = "thaman", Address = "mohali", salary = 3000 });
            obj.Add(new Employee { empno = 4, Name = "sumant", Address = "chd", salary = 2000 });


            
           return View(obj);
        }
    }
}