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
    public class StudentResultController : Controller
    {
        StudentManager aStudentManager = new StudentManager();
        CourseManager aCourseManager = new CourseManager();
        StudentResultManager aStudentResultManager = new StudentResultManager();
        GradeManager aGradeManager = new GradeManager();
        [HttpGet]
        public ActionResult SaveResult()
        {
            ViewBag.GradeList = aGradeManager.getAllGrades();
            ViewBag.StudentList = aStudentManager.GetAllStudent();
            return View();
        }
        [HttpPost]
        public ActionResult SaveResult(StudentResult studentResult , int studentId)  
        {
            ViewBag.GradeList = aGradeManager.getAllGrades();
            ViewBag.StudentList = aStudentManager.GetAllStudent();
            ViewBag.Message = aStudentResultManager.Save(studentResult);
            return View();
        }
        public JsonResult GetStudentById(int studentId)
        {

            List<StudentResult> students = aStudentResultManager.getResult(studentId);
            StudentResult aStudent = students.ToList().Find(e => e.StudentId == studentId);
            return Json(aStudent);
        }
        public JsonResult GetCourseById(Student student)
        {
            var courses = aCourseManager.GetAllCourse();
            var courseList = courses.Where(c => c.DepartmentId == student.DepartmentId).ToList();
            return Json(courses);
        }
	}
}