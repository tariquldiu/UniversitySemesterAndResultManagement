using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.BLL;
using System.Data.SqlClient;

namespace UnivarsityManagemantSystem.Gateway
{
    public class ViewScheduleGateway:Gateway
    {
        public List<ViewClassSchedule> GetSchedule(int departmentId)
        {
            Query = "Select dp.Id , c.CourseCode,c.CourseName ,r.RoomNo,d.DayName , a.FromTime, a.ToTime From Course_tb as c Inner Join AllocateClassroom_tb as a ON c.DepartmentId=a.DepartmentId Inner Join Room_tb as r ON a.RoomId=r.RoomId Inner Join Day_tb as d ON a.DayId = d.DayId Inner Join Department_tb as dp ON dp.Id=a.DepartmentId Where dp.Id= " + departmentId;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader(); 
            List<ViewClassSchedule> classSchedules = new List<ViewClassSchedule>();
            while (Reader.Read())
            {
                ViewClassSchedule aSchedule = new ViewClassSchedule();
                //{
                //DepartmentId = Convert.ToInt32(Reader["Id"].ToString()),
                //CourseCode = Reader["Code"].ToString(),
                //CourseName = Reader["Name"].ToString(),
                //RoomNo = Reader["RoomNo"].ToString(),
                //DayName = Reader["DayName"].ToString(),
                //FromTime = Convert.ToDateTime(Reader["FromTime"].ToString()),
                //ToTime = Convert.ToDateTime(Reader["ToTime"].ToString())
                //};
                //classSchedules.Add(aSchedule);
              
                aSchedule.DepartmentId = (int)Reader["Id"];
                aSchedule.CourseCode = Reader["CourseCode"].ToString();
                aSchedule.CourseName = Reader["CourseName"].ToString();
                aSchedule.RoomNo = Reader["RoomNo"].ToString();
                aSchedule.DayName = Reader["DayName"].ToString();
                aSchedule.FromTime = Reader["FromTime"].ToString();
                aSchedule.ToTime = Reader["ToTime"].ToString();
                classSchedules.Add(aSchedule);

               
                
            }
            Reader.Close();
            Connection.Close();
            return classSchedules;
        }
    }
}