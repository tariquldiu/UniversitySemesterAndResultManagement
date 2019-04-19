using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using System.Data.SqlClient;


namespace UnivarsityManagemantSystem.Gateway
{
    public class TeacherGateway:Gateway
    {
        public int Save(Teacher teacher) 
        {

            Query = "Insert Into Teacher_tb(TeacherName,Address,Email,ContactNo,DesignationId,DepartmentId,CraditTaken) Values(@teacherName,@address,@email,@contactNo,@designationId,@departmentId,@craditTaken)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("teacherName", teacher.TeacherName);
            Command.Parameters.AddWithValue("address", teacher.Address);
            Command.Parameters.AddWithValue("email", teacher.Email);
            Command.Parameters.AddWithValue("contactNo", teacher.ContactNo);
            Command.Parameters.AddWithValue("designationId", teacher.DesignationId);
            Command.Parameters.AddWithValue("departmentId", teacher.DepartmentId);
            Command.Parameters.AddWithValue("craditTaken", teacher.CraditTaken);
           
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }
        public List<Teacher> getAllTeacher() 
        {
            Query = "SELECT * FROM Teacher_tb";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Teacher> teachers = new List<Teacher>();
            while (Reader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.TeacherId = (int)Reader["Id"];
                teacher.TeacherName = Reader["TeacherName"].ToString();
                teacher.Address = Reader["Address"].ToString();
                teacher.Email = Reader["Email"].ToString();
                teacher.ContactNo = Reader["ContactNo"].ToString();
                teacher.DepartmentId = (int)Reader["DepartmentId"];
                teacher.CraditTaken = (int)Reader["CraditTaken"];
             
                teachers.Add(teacher);
            }
            Reader.Close();
            Connection.Close();
            return teachers;
        }
        public bool IsExit(string email)
        {
            Query = "SELECT * FROM Teacher_tb WHERE Email='" + email + "'";
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


    }
}