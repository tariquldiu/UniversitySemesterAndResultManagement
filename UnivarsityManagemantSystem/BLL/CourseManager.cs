using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;

namespace UnivarsityManagemantSystem.BLL
{
    public class CourseManager
    {
        CourseGateway aCourseGateway = new CourseGateway();

        public bool IsExistCode(string code)
        {
            return aCourseGateway.IsExistCode(code);
        }
        //public bool IsExistName(string name)
        //{
        //    return aCourseGateway.IsExistName(name);
        //}
        public string Save(Course course) 
        {
            if (IsExistCode(course.CourseCode))
            {
                return "The Course Already Exist";
            }
            //if (IsExistName(course.CourseName))
            //{
            //    return "The Course Already Exist";
            //}
            if (aCourseGateway.Save(course) > 0)
            {
                return "Course Saved";
            }
            else
            {
                return "Not Saved";
            }
        }

        public List<Course> GetAllCourse()
        {
            return aCourseGateway.getAllCourse();
        }
        //public List<Course> GetAllCourses(int studentId)
        //{
        //    return aCourseGateway.getAllCourses(studentId);
        //}
    }
}