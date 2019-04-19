using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.BLL;

namespace UnivarsityManagemantSystem.Controllers
{
    public class TeacherController : Controller
    {
        DesignationManager aDesignationManger = new DesignationManager();
        TeacherManager aTeacherManager = new TeacherManager();
        DepartmentManager aDepartmrntManager = new DepartmentManager();

        [HttpGet]
       public ActionResult Create()
        {
            ViewBag.Designations = aDesignationManger.GetAllDesignation();
            ViewBag.Departments = aDepartmrntManager.GetAllDepartment();
            return View();
        }
        [HttpPost]
       public ActionResult Create(Teacher teacher)
       {
           ViewBag.Message = aTeacherManager.Save(teacher);
           ViewBag.Designations = aDesignationManger.GetAllDesignation();
           ViewBag.Departments = aDepartmrntManager.GetAllDepartment();
           return View();
       }

        public ActionResult Index()
        {
            return View();
        }
	}
}