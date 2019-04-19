using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.BLL;
using System.Data.SqlClient;

namespace UnivarsityManagemantSystem.Gateway
{
    public class EnrollCourseGateway:Gateway
    {
        DepartmentManager aDepartmentManager = new DepartmentManager();
        CourseManager aCourseManager = new CourseManager();
        public int Save(EnrollCourse enrollCourse) 
        {

            Query = "Insert Into EnrollCourse_tb(StudentId,CourseId,Date) Values(@studentId,@courseId,@date)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("studentId", enrollCourse.StudentId);
            Command.Parameters.AddWithValue("courseId", enrollCourse.CourseId);
            Command.Parameters.AddWithValue("date", enrollCourse.Date);          
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }
        public List<EnrollCourse> GetEnroll(int studentId)  
        {
            Query = "Select s.StudentId,s.RegNo, s.StudentName, s.Email,d.Name From Student_tb as s Inner Join Department_tb as d On d.Id=s.DepartmentId Where s.StudentId = "+studentId;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<EnrollCourse> EnrollCourseList = new List<EnrollCourse>();
            while (Reader.Read())
            {
                EnrollCourse aEnrollCourse = new EnrollCourse();
                aEnrollCourse.StudentId =(int) Reader["StudentId"];
                aEnrollCourse.RegNo = Reader["RegNo"].ToString();
                aEnrollCourse.StudentName = Reader["StudentName"].ToString();
                aEnrollCourse.Email = Reader["Email"].ToString();
                aEnrollCourse.DepartmentName = Reader["Name"].ToString();
         

                EnrollCourseList.Add(aEnrollCourse);

            }
            Reader.Close();
            Connection.Close();
            return EnrollCourseList;

        }
    }
}