using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;

namespace UnivarsityManagemantSystem.BLL
{
    public class EnrollCourseManager
    {
        EnrollCourseGateway aEnrollCourseGateway = new EnrollCourseGateway();
        public string Save(EnrollCourse enrollCourse) 
        {
            if (aEnrollCourseGateway.Save(enrollCourse) > 0)
            {
                return "Course Enrolled";
            }
            else
            {
                return "Not Enrolled";
            }
        }
      public List<EnrollCourse> getEnroll(int studentId)
        {
            return aEnrollCourseGateway.GetEnroll(studentId);
        }
    }
    
}