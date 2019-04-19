using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;

namespace UnivarsityManagemantSystem.BLL
{
    public class StudentManager
    {
       StudentGateway aStudentGateway=new StudentGateway();
       public bool IsExit(string email)
       {
           return aStudentGateway.IsExit(email);
       }
        public string Save(Student student)  
       {
           if (IsExit(student.Email))
           {
               return "Already This Email Exit";
           }
            if(aStudentGateway.Save(student)>0)
            {
                return "Student Registered";
            }
            else
            {
                return "Not Registered";
            }
       } 
        public List<Student> GetAllStudent() 
        {
            return aStudentGateway.getAllStudent();
        }
    }
}