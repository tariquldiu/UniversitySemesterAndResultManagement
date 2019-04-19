using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;


namespace UnivarsityManagemantSystem.BLL
{
    public class StudentResultManager
    {
        StudentResultGateway aStudentResultGateway = new StudentResultGateway();
        public string Save(StudentResult studentResult) 
        {
            if (aStudentResultGateway.Save(studentResult) > 0) 
            {
                return "Result Saved";
            }
            else
            {
                return "Not Saved";
            }
        }
        public List<StudentResult> getResult(int studentId)
        {
            return aStudentResultGateway.GetResult(studentId); 
        }

    }
}