using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;

namespace UnivarsityManagemantSystem.BLL
{
    public class SemesterManager
    {
        SemesterGateway aSemesterGateway = new SemesterGateway();
        public List<Semester> GetAllSemester() 
        {
            return aSemesterGateway.getAllSemester();
        }
    }
}