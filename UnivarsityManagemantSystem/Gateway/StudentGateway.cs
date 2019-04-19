using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using UnivarsityManagemantSystem.Models;

namespace UnivarsityManagemantSystem.Gateway
{
    public class StudentGateway:Gateway
    {
        public int Save(Student student)
        {

            Query = "Insert Into Student_tb(StudentName,RegNo,Email,ContactNo,Date,Address,DepartmentId) Values(@name,@regNo,@email,@contactNo,@date,@address,@departmentId)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("name",student.StudentName );
            Command.Parameters.AddWithValue("regNo", student.RegNo);
            Command.Parameters.AddWithValue("email", student.Email);
            Command.Parameters.AddWithValue("contactNo",student.ContactNo);
            Command.Parameters.AddWithValue("date", student.Date);
            Command.Parameters.AddWithValue("address", student.Address);
            Command.Parameters.AddWithValue("departmentId",student.DepartmentId);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }
        public List<Student> getAllStudent()
        {
            Query = "SELECT * FROM Student_tb";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (Reader.Read()) 
            {
                Student student = new Student();
                student.StudentId = (int)Reader["StudentId"];
                student.StudentName = Reader["StudentName"].ToString();
                student.RegNo = Reader["RegNo"].ToString();
                student.Email = Reader["Email"].ToString();
                student.ContactNo = Reader["ContactNo"].ToString();
                student.Date = Reader["Date"].ToString();
                student.Address = Reader["Address"].ToString();
                student.DepartmentId = (int)Reader["DepartmentId"];

                students.Add(student);
            }
            Reader.Close();
            Connection.Close();
            return students;
        }
        public bool IsExit(string email)
        {
            Query = "SELECT * FROM Student_tb WHERE Email='" + email + "'";
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