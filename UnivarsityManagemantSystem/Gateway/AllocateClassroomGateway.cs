using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.BLL;
using System.Data.SqlClient;

namespace UnivarsityManagemantSystem.Gateway
{
    public class AllocateClassroomGateway:Gateway
    {
        public int Save(AllocateClassroom classroom)
        {
            Query ="INSERT INTO AllocateClassroom_tb(DepartmentId,CourseId,RoomId,DayId,FromTime,ToTime) VALUES(@departmentId,@courseId,@roomId,@dayId,@fromTime,@toTime)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("@departmentId", classroom.DepartmentId);
            Command.Parameters.AddWithValue("@courseId", classroom.CourseId);
            Command.Parameters.AddWithValue("@roomId", classroom.RoomId);
            Command.Parameters.AddWithValue("@dayId", classroom.DayId);
            Command.Parameters.AddWithValue("@fromTime", classroom.FromTime);
            Command.Parameters.AddWithValue("@toTime", classroom.ToTime);
           
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

      
    }
}