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
    public class ViewScheduleController : Controller
    {
        ViewScheduleManager aViewScheduleManager = new ViewScheduleManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();
             
        [HttpGet]
        public ActionResult Schedule()
        {
            ViewBag.DepartmentList = aDepartmentManager.GetAllDepartment();
            //ViewBag.Schedules = aViewScheduleManager.getSchedule();

            return View();
        }

        [HttpPost]
        public ActionResult Schedule(int department) 
        {
            ViewBag.DepartmentList = aDepartmentManager.GetAllDepartment();
            //ViewBag.Schedules = aViewScheduleManager.getSchedule();
            return View();
        }
        public JsonResult GetScheduleByDeptId(int departmentId)
        {
            var Schedules = aViewScheduleManager.getSchedule(departmentId);
            var SchedulesList = Schedules.Where(s =>s.DepartmentId== departmentId).ToList();
            return Json(SchedulesList);
        }
	}
}