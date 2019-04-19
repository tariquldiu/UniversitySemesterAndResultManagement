using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace UnivarsityManagemantSystem.Models
{
    public class Department
    {
        public int DeptId { get; set; }
      
        public string DeptCode { get; set; }
       
        public string DeptName { get; set; }
    }
}