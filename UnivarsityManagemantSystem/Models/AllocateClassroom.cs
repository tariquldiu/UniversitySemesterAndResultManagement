using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace UnivarsityManagemantSystem.Models
{
    public class AllocateClassroom
    {
        public int AllocateId { get; set; } 
        public int DepartmentId { get; set; }     
        public int CourseId { get; set; }
        public int RoomId { get; set; }
        public int DayId { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
    }
}