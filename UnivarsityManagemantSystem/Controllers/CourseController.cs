using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;
using UnivarsityManagemantSystem.BLL;

namespace UnivarsityManagemantSystem.Controllers
{
    public class CourseController : Controller
    {
        CourseManager aCourseManager = new CourseManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();
        SemesterManager aSemesterManager = new SemesterManager();
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Departments = aDepartmentManager.GetAllDepartment();
            ViewBag.Semesters = aSemesterManager.GetAllSemester();
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            ViewBag.Message = aCourseManager.Save(course);
            ViewBag.Departments = aDepartmentManager.GetAllDepartment();
            ViewBag.Semesters = aSemesterManager.GetAllSemester();
            return View();
        }


        public ActionResult Index()
        {
            return View();
        }
	}
}