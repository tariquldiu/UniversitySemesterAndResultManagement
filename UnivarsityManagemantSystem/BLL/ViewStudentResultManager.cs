using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;


namespace UnivarsityManagemantSystem.BLL
{
    
    public class ViewStudentResultManager
    {

        ViewStudentResultGateway aViewResultGateway = new ViewStudentResultGateway();
        public List<ViewStudentResult> viewResultByStudentId(int studentId) 
        {
            return aViewResultGateway.ViewResultByStudentId(studentId);
        }
    }
}