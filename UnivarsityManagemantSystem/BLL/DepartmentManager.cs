using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;

namespace UnivarsityManagemantSystem.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway aDepartmentGateway = new DepartmentGateway();


        public bool IsExistCode(string code) 
        {
            return aDepartmentGateway.IsExistCode(code);
        }
        public bool IsExistName(string name)
        {
            return aDepartmentGateway.IsExistName(name);
        }
        public string Save(Department department)
        {

            if (IsExistCode(department.DeptCode))
            {
                return "The department Already Exist";
            }
            if(IsExistName(department.DeptName))
            {
                return "The department Already Exist";
            }
            if (aDepartmentGateway.Save(department) > 0)
            {
                return "Department Saved";
            }
            else
            {
                return "Not Saved";
            }
        }
        public List<Department> GetAllDepartment()
        {
           return aDepartmentGateway.getAllDepartment();
        }
    }


}