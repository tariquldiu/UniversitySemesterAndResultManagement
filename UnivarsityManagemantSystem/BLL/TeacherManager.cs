using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;

namespace UnivarsityManagemantSystem.BLL
{
    public class TeacherManager
    {
        TeacherGateway aTeacherGateway = new TeacherGateway();
        public bool IsExit(string email)
        {
            return aTeacherGateway.IsExit(email);
        }
        public string Save(Teacher teacher)
        {
            if (IsExit(teacher.Email))
            {
                return "Already This Email Exit";
            }
            if (aTeacherGateway.Save(teacher) > 0)
            {
                return "Teacher Saved";
            }
            else
            {
                return "Not Saved";
            }
        }
        public List<Teacher> GetAllTeacher()
        {
            return aTeacherGateway.getAllTeacher();
        }

    }
}