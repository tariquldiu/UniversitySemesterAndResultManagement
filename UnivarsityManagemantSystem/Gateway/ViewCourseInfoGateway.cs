using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using UnivarsityManagemantSystem.Models;


namespace UnivarsityManagemantSystem.Gateway
{
    public class ViewCourseInfoGateway:Gateway
    {
        public List<ViewCourseInfo> GetAllCoursesByDepartmentId(int departmentId)
        {
            Query = "Select c.DepartmentId , c.CourseCode, c.CourseName , s.SemesterName , t.TeacherName From Course_tb as c Left Join CourseAssign_tb as ca On c.Id=ca.CourseId Inner Join Semester_tb as s On s.SemesterId=c.SemesterId left Join Teacher_tb as t On ca.TeacherId=t.Id Inner Join Department_tb as d On d.Id=c.DepartmentId Where d.Id= " + departmentId;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<ViewCourseInfo> ViewCourseInfoList = new List<ViewCourseInfo>();
            while (Reader.Read())
            {
                ViewCourseInfo aViewCourseInfo = new ViewCourseInfo();
                //aViewCourseInfo.ViewcourseId = (int)Reader["ViewcourseId"];             
                aViewCourseInfo.DepartmentId = (int)Reader["DepartmentId"];
                aViewCourseInfo.CourseCode = Reader["CourseCode"].ToString();
                aViewCourseInfo.CourseName = Reader["CourseName"].ToString();
                aViewCourseInfo.SemesterName = Reader["SemesterName"].ToString();
                aViewCourseInfo.TeacherName = Reader["TeacherName"].ToString();

                var x = Reader["TeacherName"].ToString();
                if (Reader["TeacherName"].ToString() == "")
                {
                    x = "Not Assigned Yet";
                }
                aViewCourseInfo.TeacherName = x;

                ViewCourseInfoList.Add(aViewCourseInfo);

            }
            Reader.Close();
            Connection.Close();
            return ViewCourseInfoList;

        }
    }
}