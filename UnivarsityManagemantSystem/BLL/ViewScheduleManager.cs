using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;

namespace UnivarsityManagemantSystem.BLL
{
    public class ViewScheduleManager
    {
        ViewScheduleGateway aViewScheduleGateway = new ViewScheduleGateway();

        public List<ViewClassSchedule> getSchedule(int departmentId)
        {
            return aViewScheduleGateway.GetSchedule(departmentId);
        }
    }
}