using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.BLL;
using System.Data.SqlClient;


namespace UnivarsityManagemantSystem.Gateway
{
    public class ViewStudentResultGateway:Gateway
    {

        public List<ViewStudentResult> ViewResultByStudentId(int studentId)
        {
            Query = "Select s.StudentId,s.RegNo,s.StudentName,s.Email,d.Name,c.Id,c.CourseCode,c.CourseName,g.GradeLetter From StudentResult_tb as sr Inner Join Course_tb as c On sr.CourseId=c.Id Inner Join Grade_tb as g On sr.GradeId=g.GradeId Inner Join Student_tb as s On sr.StudentId=s.StudentId Inner Join Department_tb as d On s.DepartmentId=d.Id Where s.StudentId= " + studentId;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<ViewStudentResult> ViewResultSheet = new List<ViewStudentResult>();
            while (Reader.Read())
            {
                ViewStudentResult aViewResult = new ViewStudentResult();
                aViewResult.StudentId = (int)Reader["StudentId"];
                aViewResult.RegNo = Reader["RegNo"].ToString();
                aViewResult.StudentName = Reader["StudentName"].ToString();
                aViewResult.Email = Reader["Email"].ToString();
                aViewResult.DepartmentName = Reader["Name"].ToString();
                aViewResult.CourseId = (int)Reader["Id"];
                aViewResult.CourseCode = Reader["CourseCode"].ToString();
                aViewResult.CourseName = Reader["CourseName"].ToString();
                aViewResult.GradeLetter = Reader["GradeLetter"].ToString();

                ViewResultSheet.Add(aViewResult);

            }
            Reader.Close();
            Connection.Close();
            return ViewResultSheet;

        }

    }
}