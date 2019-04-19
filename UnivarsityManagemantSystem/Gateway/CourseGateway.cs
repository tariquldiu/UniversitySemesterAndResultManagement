using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using System.Data.SqlClient;

namespace UnivarsityManagemantSystem.Gateway
{
    public class CourseGateway:Gateway
    {
        public int Save(Course course) 
        {

            Query = "Insert Into Course_tb(CourseCode,CourseName,Cradit,DepartmentId,SemesterId) Values(@courseCode,@courseName,@cradit,@departmentId,@semesterId)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("courseCode", course.CourseCode);
            Command.Parameters.AddWithValue("courseName", course.CourseName);
            Command.Parameters.AddWithValue("cradit",course.Cradit );
            Command.Parameters.AddWithValue("departmentId",course.DepartmentId);
            Command.Parameters.AddWithValue("semesterId",course.SemesterId );
          
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }
        public List<Course> getAllCourse() 
        {
            Query = "SELECT * FROM Course_tb";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Course> courses = new List<Course>();
            while (Reader.Read())
            {
                Course course = new Course();
                course.CourseId = (int)Reader["Id"];
                course.CourseCode = Reader["CourseCode"].ToString();
                course.CourseName = Reader["CourseName"].ToString();
                course.Cradit = (int)Reader["Cradit"];
                course.DepartmentId = (int)Reader["DepartmentId"];
                courses.Add(course);
            }
            Reader.Close();
            Connection.Close();
            return courses;
        }

        public bool IsExistCode(string courseCode) 
        {
            Query = "SELECT * FROM Course_tb where CourseCode='" + courseCode + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                Connection.Close();
                return true;
            }
            else
            {
                Connection.Close();
                return false;
            }
        }

        //public bool IsExistName(string courseName)
        //{
        //    Query = "SELECT * FROM Course_tb where Name='" + courseName + "'";
        //    Command = new SqlCommand(Query, Connection);
        //    Connection.Open();
        //    Reader = Command.ExecuteReader();
        //    if (Reader.HasRows)
        //    {
        //        Connection.Close();
        //        return true;
        //    }
        //    else
        //    {
        //        Connection.Close();
        //        return false;
        //    }
        //}
        
    }
}