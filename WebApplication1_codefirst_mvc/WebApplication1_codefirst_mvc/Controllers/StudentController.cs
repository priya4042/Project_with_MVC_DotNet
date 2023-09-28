using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_codefirst_mvc.Data;
using WebApplication1_codefirst_mvc.Models;

namespace WebApplication1_codefirst_mvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Subject

        private readonly ApplicationDbContext _Context;
        
        public StudentController()
        {
            _Context = new ApplicationDbContext();
        }

        //if we want to dispose the memory

       /* protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }*/
        public ActionResult Index()
        {
            var studentlist = _Context.Students.ToList();
            return View(studentlist);
       }
        public ActionResult Create()
        {
            
           Student student = new Student();
            return View(student);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult create(Student student)
        {
            if (student == null)
                return HttpNotFound();
            _Context.Students.Add(student);
            _Context.SaveChanges();
            return RedirectToAction("Index");

        }

        //Edit
        public ActionResult edit(int id)
        {
            var StudentInDb = _Context.Students.Find(id);
            if (StudentInDb == null)
                return HttpNotFound();
            return View(StudentInDb);
        }
        [HttpPost]
        public ActionResult edit(Student student)
        {
            if (student == null)
                return HttpNotFound();
        
            var studentfromDb = _Context.Students.Find(student.Id);
            if (studentfromDb == null)
                return HttpNotFound();
            studentfromDb.Name = student.Name;
            studentfromDb.Address = student.Address;
            studentfromDb.Email = student.Email;
            _Context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult detail(int id)
        {
            var studentInDb = _Context.Students.Find(id);
            if (studentInDb == null)
                return HttpNotFound();
            return View(studentInDb);
        }

    }
    
}