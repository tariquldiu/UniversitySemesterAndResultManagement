using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnivarsityManagemantSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Cradit { get; set; }
        public int DepartmentId { get; set; }
        public int SemesterId { get; set; }

    }
}