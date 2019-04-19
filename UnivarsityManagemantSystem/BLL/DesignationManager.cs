using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;

namespace UnivarsityManagemantSystem.BLL
{
    public class DesignationManager
    {
        DesignationGateway aDesignationGateway = new DesignationGateway();

        public List<Designation> GetAllDesignation()
        {
            return aDesignationGateway.getAllDesignation();

        }
    }
}