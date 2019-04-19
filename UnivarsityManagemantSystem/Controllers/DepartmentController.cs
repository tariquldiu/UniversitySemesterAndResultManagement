using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.BLL;

namespace UnivarsityManagemantSystem.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentManager aDepartmentManager = new DepartmentManager();
     

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Departments = aDepartmentManager.GetAllDepartment();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department department)
        {
            ViewBag.Message = aDepartmentManager.Save(department);
            ViewBag.Departments = aDepartmentManager.GetAllDepartment();
            return View();
        }

        public List<Department> GetAllDepartment()
        {
            return aDepartmentManager.GetAllDepartment();
        }
       
        public ActionResult Index()
        {
            List<Department> dept = GetAllDepartment();
            ViewBag.DepartmentList = dept;
            return View();
        }
        
	}
}