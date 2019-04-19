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
    public class ViewCourseInfoController : Controller
    {
        ViewCourseInfo aViewCourseInfo = new ViewCourseInfo();
        DepartmentManager aDepartmentManager = new DepartmentManager();
        ViewCourseInfoManager aViewCourseInfoManager = new ViewCourseInfoManager();


        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.DepartmentList = aDepartmentManager.GetAllDepartment();
            return View();
        }
        [HttpPost]
        public ActionResult Index(int departmentId)
        {
            ViewBag.DepartmentList = aDepartmentManager.GetAllDepartment();
            return View();
        }
        public JsonResult GetAllCoursesByDepartmentId(int departmentId)
        {
            var CourseInfo = aViewCourseInfoManager.getAllCoursesByDepartmentId(departmentId);
            var CourseList = CourseInfo.Where(c => c.DepartmentId == departmentId).ToList();
            return Json(CourseList);
        }
	}
}