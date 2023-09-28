using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_mvc_12.Models;

namespace web_mvc_12.Controllers
{
    public class empController : Controller
    {
        // GET: emp
        public ActionResult Index()
        {
            List<Employee> obj = new List<Employee>();
            obj.Add(new Employee { empno = 1, empname = "amit", empaddress = "chd", empsalary = 30000 });
            obj.Add(new Employee { empno = 2, empname = "namit", empaddress = "mohali", empsalary = 5000 });
            obj.Add(new Employee { empno = 3, empname = "samit", empaddress = "kanhra", empsalary = 70000 });
            obj.Add(new Employee { empno = 4, empname = "ramit", empaddress = "dangal", empsalary = 8000 });
            return View(obj);
        }
    }
}