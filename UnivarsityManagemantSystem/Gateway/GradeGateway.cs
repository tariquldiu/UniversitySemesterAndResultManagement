using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using System.Data.SqlClient;

namespace UnivarsityManagemantSystem.Gateway
{
    public class GradeGateway:Gateway
    {
        public List<Grade> GetAllGrades() 
        {
            Query = "Select * FROM Grade_tb";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Grade> gradeList = new List<Grade>();
            while (Reader.Read())
            {
                Grade grade = new Grade();
                grade.GradeId = (int)Reader["GradeId"];
                grade.GradeLetter = Reader["GradeLetter"].ToString();
                gradeList.Add(grade);
            }
            Reader.Close();
            Connection.Close();
            return gradeList;
        }
    }
}