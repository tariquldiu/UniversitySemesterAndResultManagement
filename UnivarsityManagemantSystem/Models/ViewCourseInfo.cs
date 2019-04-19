using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnivarsityManagemantSystem.Models
{
    public class ViewCourseInfo
    {
        public int ViewcourseId { get; set; }
        public int DepartmentId { get; set; }    
        public string CourseCode { get; set; }
        public string  CourseName { get; set; }
        public string SemesterName { get; set; }
        public string TeacherName { get; set; }
    }
}