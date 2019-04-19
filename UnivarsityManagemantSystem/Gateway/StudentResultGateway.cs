using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.BLL;
using System.Data.SqlClient;


namespace UnivarsityManagemantSystem.Gateway
{
    public class StudentResultGateway:Gateway
    {
        DepartmentManager aDepartmentManager = new DepartmentManager();
        CourseManager aCourseManager = new CourseManager();
        public int Save(StudentResult studentResult) 
        {

            Query = "Insert Into StudentResult_tb(StudentId,CourseId,GradeId) Values(@studentId,@courseId,@gradeId)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("studentId", studentResult.StudentId);
            Command.Parameters.AddWithValue("courseId", studentResult.CourseId);
            Command.Parameters.AddWithValue("gradeId", studentResult.GradeId);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }
        public List<StudentResult> GetResult(int studentId) 
        {
            Query = "Select s.StudentId,s.RegNo, s.StudentName, s.Email,d.Name From Student_tb as s Inner Join Department_tb as d On d.Id=s.DepartmentId Where s.StudentId = " + studentId;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<StudentResult> StudentResultList = new List<StudentResult>();
            while (Reader.Read())
            {
                StudentResult aStudentResult = new StudentResult();
                aStudentResult.StudentId = (int)Reader["StudentId"];
                aStudentResult.RegNo = Reader["RegNo"].ToString();
                aStudentResult.StudentName = Reader["StudentName"].ToString();
                aStudentResult.Email = Reader["Email"].ToString();
                aStudentResult.DepartmentName = Reader["Name"].ToString();


                StudentResultList.Add(aStudentResult);

            }
            Reader.Close();
            Connection.Close();
            return StudentResultList;

        }

    }
}