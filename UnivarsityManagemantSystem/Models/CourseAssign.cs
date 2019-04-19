using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnivarsityManagemantSystem.Models
{
    public class CourseAssign
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int TeacherId { get; set; }   
        public int CourseId { get; set; }
     
    }
}