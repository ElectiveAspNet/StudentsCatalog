using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentsCatalog.Models;
using StudentsCatalog.Models.Entities;

namespace StudentsCatalog.Controllers
{
    public class StudentController : Controller
    {
        // Model
        StudentDbContext db = new StudentDbContext();
        // ReadAll in db
        public IActionResult Index()
        {
            ViewBag.stud = db.Students.ToList();       
            return View();
        }
        // Create
        public IActionResult Create()
        {
            db.Students.Add(new Student{FirstName="Claus", LastName = "Bove", Age = 33});
            db.SaveChanges();
            return View();
        }

        // Delete

        // Update










        public string day2()
        {
            return "Hello from day 2";
        }

        public IActionResult mvc(int id = 1000)
        {
            // Model laget
            ViewBag.number = id;

            return View();
        }
    }
}