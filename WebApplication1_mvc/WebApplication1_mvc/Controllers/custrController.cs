using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_mvc.Models;

namespace WebApplication1_mvc.Controllers
{
    public class custrController : Controller
    {
        // GET: custr
        public ActionResult Index()
        {
            List<Customer> obj = new List<Customer>();
            obj.Add(new Customer { custno = 1, custname = "nisha", custadd = "chd", salary = 4000 });
            obj.Add(new Customer { custno = 2, custname = "verma", custadd = "mohali", salary = 5000 });
            obj.Add(new Customer { custno = 3, custname = "amit", custadd = "sector 32", salary = 6000 });
            obj.Add(new Customer { custno = 4, custname = "sheetal", custadd = "chd", salary = 7000 });
            return View(obj);
        }
    }
}