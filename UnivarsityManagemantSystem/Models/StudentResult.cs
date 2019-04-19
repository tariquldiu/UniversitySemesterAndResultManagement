using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnivarsityManagemantSystem.Models
{
    public class StudentResult
    {
        public int ResultId { get; set; } 
        public int StudentId { get; set; }
        public string RegNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string DepartmentName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string GradeId { get; set; } 
    }
}