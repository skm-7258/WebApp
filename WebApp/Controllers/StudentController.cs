using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        private AppDbContext dbContext;
        public StudentController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Student>
                stu = dbContext.Student.ToList();
            return View(stu);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Student stu)
        {
            if (ModelState.IsValid)
            {
                dbContext.Student.Add(stu);
                dbContext.SaveChanges();
                return RedirectToAction("index");

            }
            else
            {
                return View(stu);
            }
        }
        public IActionResult Edit(int id)
        {

            var stu = dbContext.Student.SingleOrDefault(e => e.ID == id);
            return View(stu);
        }
        [HttpPost]
        public IActionResult Edit(Student stu)
        {
            dbContext.Student.Update(stu);
            dbContext.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int ID)
        {
            var emp = dbContext.Student.SingleOrDefault(e => e.ID == ID);
            if (emp != null)
            {
                dbContext.Student.Remove(emp);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

    }
}

