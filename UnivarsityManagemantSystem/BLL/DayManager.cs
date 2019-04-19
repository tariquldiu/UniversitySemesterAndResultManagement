using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;


namespace UnivarsityManagemantSystem.BLL
{
    public class DayManager
    {
        DayGateway aDayGateway = new DayGateway();

        public List<Day> GetAllDays()
        {
            return aDayGateway.GetAllDays();
        }
    }
}