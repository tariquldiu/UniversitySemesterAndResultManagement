using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnivarsityManagemantSystem.Models
{
    public class ViewStudentResult
    {
        public int ViewResultId { get; set; }
        public int StudentId { get; set; }
        public string RegNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string DepartmentName { get; set; }
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string GradeLetter { get; set; }

    }
}