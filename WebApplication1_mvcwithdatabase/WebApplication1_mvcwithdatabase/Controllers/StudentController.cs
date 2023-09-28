using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_mvcwithdatabase.Data;

namespace WebApplication1_mvcwithdatabase.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _Context;
        // GET: Student
        public StudentController()
        {
            _Context = new ApplicationDbContext();
           
        }
        public ActionResult Index()
        {
            var StudentList = _Context.Student.ToList();

            return View(StudentList);
        }
    }
}