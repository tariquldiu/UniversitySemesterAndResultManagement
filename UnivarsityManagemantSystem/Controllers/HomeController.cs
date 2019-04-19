using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.BLL;


namespace UnivarsityManagemantSystem.Controllers
{
    public class HomeController : Controller
    {
        StudentManager aStudentManager = new StudentManager();
        CourseManager aCourseManager = new CourseManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();
        TeacherManager aTeacherManager = new TeacherManager();
        DesignationManager aDesignationManger = new DesignationManager();
        RoomManager aRoomManager = new RoomManager();
        SemesterManager aSemesterManager = new SemesterManager();
        DayManager aDayManager = new DayManager();

        public ActionResult Index()
        {
            ViewBag.Students = aStudentManager.GetAllStudent();
            ViewBag.Courses = aCourseManager.GetAllCourse();
            ViewBag.Departments = aDepartmentManager.GetAllDepartment();
            ViewBag.Teachers = aTeacherManager.GetAllTeacher();
            ViewBag.Designations = aDesignationManger.GetAllDesignation();
            ViewBag.Rooms = aRoomManager.GetAllRooms();
            ViewBag.Semesters = aSemesterManager.GetAllSemester();
            ViewBag.Days = aDayManager.GetAllDays();

            return View();
        }

       
    }
}