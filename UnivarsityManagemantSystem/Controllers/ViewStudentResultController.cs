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
    public class ViewStudentResultController : Controller
    {
        ViewStudentResultManager aViewResultManager = new ViewStudentResultManager();
        StudentManager aStudentManager = new StudentManager();

        [HttpGet]
        public ActionResult ViewResult() 
        {
            ViewBag.StudentList = aStudentManager.GetAllStudent();
            return View();
        }
        [HttpPost]
        public ActionResult ViewResult(int studentId)
        {
            ViewBag.StudentList = aStudentManager.GetAllStudent();
            return View();
        }
        public JsonResult GetStudentById(int studentId)
        {

            List<ViewStudentResult> students = aViewResultManager.viewResultByStudentId(studentId);
            ViewStudentResult aStudent = students.ToList().Find(s => s.StudentId == studentId);
            return Json(aStudent);
        }
        public JsonResult GetResultById(int studentId)
        {
            var Result = aViewResultManager.viewResultByStudentId(studentId);
            var ResultSheet = Result.Where(r=>r.StudentId==studentId).ToList();
            return Json(ResultSheet);
        }
	}
}