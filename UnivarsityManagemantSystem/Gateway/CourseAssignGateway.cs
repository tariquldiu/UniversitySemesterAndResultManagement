using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.BLL;
using System.Data.SqlClient;

namespace UnivarsityManagemantSystem.Gateway
{
    public class CourseAssignGateway:Gateway
    {
        TeacherManager aTeacherManager = new TeacherManager();
        public int Save(CourseAssign courseAssign) 
        {

            Query = "Insert Into CourseAssign_tb(DepartmentId,TeacherId,CourseId) Values(@departmentId,@teacherId,@courseId)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("departmentId",courseAssign.DepartmentId );
            Command.Parameters.AddWithValue("teacherId", courseAssign.TeacherId);
            
            Command.Parameters.AddWithValue("courseId", courseAssign.CourseId);
            
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            //int updateTeacher = UpdateTeacher(courseAssign);
            Connection.Close();
            return rowAffected;

        }

        //private int UpdateTeacher(CourseAssign courseAssign)
        //{
        //    Teacher teacher = aTeacherManager.GetAllTeacher().ToList().Find(t => t.TeacherId == courseAssign.TeacherId);
        //    double creditTakenbyTeacher = teacher.RemainingCradit +courseAssign.Credit;
        //    Command.CommandText = "Update Teacher Set RemainingCradit='" + creditTakenbyTeacher + "' WHERE TeacherId='" +
        //                             courseAssign.TeacherId + "'";
        //    return Command.ExecuteNonQuery();

        //}

        public List<CourseAssign> GetAllCourseAssignTeacher()
        {
            Query = "Select * From CourseAssign_tb";
            Command = new SqlCommand(Query,Connection);
            List<CourseAssign> assignList = new List<CourseAssign>();
            Connection.Open();
            Reader = Command.ExecuteReader();
            while(Reader.Read())
            {
                CourseAssign aCourseAssign = new CourseAssign();
                aCourseAssign.Id =(int) Reader["Id"];
                aCourseAssign.DepartmentId = (int)Reader["DepartmentId"];
                aCourseAssign.TeacherId = (int)Reader["TeacherId"];
                aCourseAssign.CourseId = (int)Reader["CourseId"];
                assignList.Add(aCourseAssign);
            }
            Reader.Close();
            Connection.Close();
            return assignList;
        }
    }
}