using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using UnivarsityManagemantSystem.Models;

namespace UnivarsityManagemantSystem.Gateway
{
    public class SemesterGateway:Gateway
    {
        public List<Semester> getAllSemester() 
        {
            Query = "SELECT * FROM Semester_tb";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Semester> semesters = new List<Semester>(); 
            while (Reader.Read())
            { 
                Semester semester = new Semester();
                semester.SemesterId = (int)Reader["SemesterId"];
                semester.SemesterName = Reader["SemesterName"].ToString();

                semesters.Add(semester);
            }
            Reader.Close();
            Connection.Close();
            return semesters;
        }

    }
}