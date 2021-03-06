﻿using DrugaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugaMVC.Controllers
{
    public class StudentController : Controller
    {
        List<Student> seznam = new List<Student>();
        // GET: Student
        public ActionResult Index()
        {
            seznam = new List<Student>
            {
                new Student()
                {
                    StudentID=1,
                    StudentIme="Janez",
                    Leta=18
                },
                new Student()
                {
                    StudentID=2,
                    StudentIme="Metka",
                    Leta=22
                },
                new Student()
                {
                    StudentID=3,
                    StudentIme="Smetka",
                    Leta=20
                },
            };
            return View(seznam);
        }

        public ActionResult TestRazorja()
        {
            return View();
        }

        public ActionResult UporabaModela()
        {
            Student x = new Student()
            { StudentID = 1, StudentIme = "Janez", Leta = 18 };
            return View(x);
        }

        public ActionResult Edit(int id)
        {
            Student x = seznam.Where(a => a.StudentID == id).FirstOrDefault();

            return View(x);
        }

        [HttpPost]
        public ActionResult Edit(Student a)
        {
            Student x = new Student();
            x.StudentID = a.StudentID;
            x.StudentIme = a.StudentIme;
            x.Leta = a.Leta;
            return RedirectToAction("Index");
        }
    }

}