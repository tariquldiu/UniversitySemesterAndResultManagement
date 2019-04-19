using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;

namespace UnivarsityManagemantSystem.BLL
{
    public class CourseAssignManager
    {
        CourseAssignGateway aCourseAssignGateway = new CourseAssignGateway();
        public string Save(CourseAssign courseAssign) 
        {
            if (aCourseAssignGateway.Save(courseAssign) > 0)
            {
                return "Course Assigned";
            }
            else
            {
                return "Not Assigned";
            }
        }

        public List<CourseAssign> getAllCourseAssignTeacher()
        {
            return aCourseAssignGateway.GetAllCourseAssignTeacher();
        }
    }
}