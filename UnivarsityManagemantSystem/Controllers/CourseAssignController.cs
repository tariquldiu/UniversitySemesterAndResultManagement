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
    public class CourseAssignController : Controller
    {
        CourseAssignManager aCourseAssignManager = new CourseAssignManager();
        CourseManager aCourseManager = new CourseManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();
        TeacherManager aTeacherManager = new TeacherManager();

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Departments = aDepartmentManager.GetAllDepartment();
            ViewBag.Teachers = aTeacherManager.GetAllTeacher();
            ViewBag.Courses = aCourseManager.GetAllCourse();
            return View();
        }
        [HttpPost]
        public ActionResult Create(CourseAssign courseAssign )
        {
           
            ViewBag.Departments = aDepartmentManager.GetAllDepartment();
            ViewBag.Teachers = aTeacherManager.GetAllTeacher();
            ViewBag.Courses = aCourseManager.GetAllCourse();
            ViewBag.Message = aCourseAssignManager.Save(courseAssign);
            return View();
        }
        public JsonResult GetTeacherByDepartmentId(Department department)
        {
            var teachers = aTeacherManager.GetAllTeacher();
            var teacherList = teachers.Where(t =>t.DepartmentId == department.DeptId).ToList();
            return Json(teacherList);
        }
        public JsonResult GetTeacherById(int teacherId)
        {
            List<Teacher> teachers =aTeacherManager.GetAllTeacher();
            Teacher aTeacher = teachers.ToList().Find(t => t.TeacherId == teacherId);
            return Json(aTeacher);

        }
        public JsonResult GetCourseById(int courseId)
        {
            List<Course> courses = aCourseManager.GetAllCourse();
            Course aCourse = courses.ToList().Find(c => c.CourseId == courseId);
            return Json(aCourse);
        }
        public ActionResult Index()
        {
            return View();
        }
	}
}