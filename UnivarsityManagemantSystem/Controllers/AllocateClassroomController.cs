using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.BLL;

namespace UnivarsityManagemantSystem.Controllers
{
    public class AllocateClassroomController : Controller
    {

        DepartmentManager aDepartmentManager = new DepartmentManager();
        CourseManager aCourseManager = new CourseManager();
        RoomManager aRoomManager = new RoomManager();
        DayManager aDayManager = new DayManager();
        AllocateClassroomManager aAllocateClassroomManager = new AllocateClassroomManager();
       [HttpGet]
        public ActionResult Alocate() 
        {
            ViewBag.Departments = aDepartmentManager.GetAllDepartment();         
            ViewBag.Courses = aCourseManager.GetAllCourse();
            ViewBag.Rooms = aRoomManager.GetAllRooms();
            ViewBag.Days = aDayManager.GetAllDays();
            return View();
        }
        [HttpPost]
        public ActionResult Alocate(AllocateClassroom classroom)
        {
            ViewBag.Departments = aDepartmentManager.GetAllDepartment();
            ViewBag.Courses = aCourseManager.GetAllCourse();
            ViewBag.Rooms = aRoomManager.GetAllRooms();
            ViewBag.Days = aDayManager.GetAllDays();
            ViewBag.Message = aAllocateClassroomManager.Save(classroom);

            return View();
        }
	}
}