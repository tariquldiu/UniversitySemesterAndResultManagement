using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;


namespace UnivarsityManagemantSystem.BLL
{
    public class AllocateClassroomManager
    {
        AllocateClassroomGateway aAllocateClassroomGateway = new AllocateClassroomGateway();
        public string Save(AllocateClassroom classroom)
        {
            if(aAllocateClassroomGateway.Save(classroom)>0)
            {
                return "Classroom Allocated";
            }
            else
            {
                return "Not Allocated";
            }
        }
       
    }
}