using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;

namespace UnivarsityManagemantSystem.BLL
{
    public class GradeManager
    {
        GradeGateway aGradeGateway = new GradeGateway();
        public List<Grade> getAllGrades()
        {
            return aGradeGateway.GetAllGrades();
        }
    }
}