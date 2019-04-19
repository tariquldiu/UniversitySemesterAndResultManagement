using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;


namespace UnivarsityManagemantSystem.BLL
{
    
    public class ViewCourseInfoManager
    {
        ViewCourseInfoGateway aViewCourseInfoGateway = new ViewCourseInfoGateway();
        public List<ViewCourseInfo> getAllCoursesByDepartmentId(int departmentId)
        {
            return aViewCourseInfoGateway.GetAllCoursesByDepartmentId(departmentId);
        }
    }
}