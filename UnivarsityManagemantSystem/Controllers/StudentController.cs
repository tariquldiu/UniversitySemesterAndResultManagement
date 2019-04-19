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
    public class StudentController : Controller
    {
        StudentManager aStudentManager = new StudentManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();

       [HttpGet]
        public ActionResult Create() 
        {
            ViewBag.Departments = aDepartmentManager.GetAllDepartment(); 
            return View();
        }
        [HttpPost] 
        public ActionResult Create(Student student)
        { 
            ViewBag.Departments = aDepartmentManager.GetAllDepartment();
            ViewBag.Message = aStudentManager.Save(student);
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
	}
}