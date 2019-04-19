using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.BLL;

namespace UnivarsityManagemantSystem.Controllers
{
    public class EnrollCourseController : Controller
    {
        EnrollCourseManager aEnrollCourseManager = new EnrollCourseManager();
        StudentManager aStudentManager = new StudentManager();
        CourseManager aCourseManager = new CourseManager();
        [HttpGet]
        public ActionResult Enroll()
        {
            ViewBag.StudentList = aStudentManager.GetAllStudent(); 
            //ViewBag.CourseList = aEnrollCourseManager.GetCourseByDept(student);
            return View();
        }
        [HttpPost]
        public ActionResult Enroll(EnrollCourse enrollCourse , int studentId)
        {
            ViewBag.StudentList = aStudentManager.GetAllStudent();
          
            ViewBag.Message = aEnrollCourseManager.Save(enrollCourse);
            return View();
        }
        public JsonResult GetStudentById(int studentId) 
        {
            
            List<EnrollCourse> students = aEnrollCourseManager.getEnroll(studentId);
            EnrollCourse aStudent = students.ToList().Find(e => e.StudentId ==studentId);
            return Json(aStudent);
        }
        public JsonResult GetCourseById(Student student )
        {
            var courses = aCourseManager.GetAllCourse();
            var courseList=courses.Where(c => c.DepartmentId ==student.DepartmentId).ToList();
            return Json(courses);
        }
	}
}