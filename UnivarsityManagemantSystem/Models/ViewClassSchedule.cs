using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnivarsityManagemantSystem.Models
{
    public class ViewClassSchedule
    {
        public int ScheduleId { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string RoomNo { get; set; }
        public string DayName { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; } 

    }
}