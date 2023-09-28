using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_mvc_EMP.Models;

namespace WebApplication1_mvc_EMP.Controllers
{
    public class emp2Controller : Controller
    {
        // GET: emp2
        public ActionResult Index2()
        {
            List<Employee2> obj = new List<Employee2>();
            obj.Add(new Employee2 { Id = 1, Name = "amit", Address = "chd", salary = 3000 });
            obj.Add(new Employee2 { Id = 2, Name = "subhas", Address = "mohali", salary = 4000 });
            obj.Add(new Employee2 { Id = 3, Name = "aman", Address = "chd", salary = 5000 });
            obj.Add(new Employee2 { Id = 4, Name = "sumit", Address = "mohali", salary = 6000 });

            return View(obj);
        }
    }
}