using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentsCatalog.Models.Entities;

namespace StudentsCatalog.Controllers
{
    public class StudentController : Controller
    {
        // Model
        List<Student> students = new List<Student>();
        
        public IActionResult Index()
        {
            students.Add(new Student{FirstName="Claus", LastName = "Bove", Age = 33});
            students.Add(new Student{FirstName="Henning", LastName = "Jensen", Age = 63});
            students.Add(new Student{FirstName="Anna", LastName = "Toft", Age = 17});

            ViewBag.stud = students;
            
            return View();
        }
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