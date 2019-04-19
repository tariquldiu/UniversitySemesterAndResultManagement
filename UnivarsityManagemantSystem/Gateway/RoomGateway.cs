using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using System.Data.SqlClient;


namespace UnivarsityManagemantSystem.Gateway
{
    public class RoomGateway:Gateway
    {

        public List<Room> GetAllRooms()
        {
            Query = "Select * FROM Room_tb";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Room> roomList = new List<Room>();
            while (Reader.Read())
            {
                Room room = new Room();
                room.RoomId = (int)Reader["RoomId"];
                room.RoomNo = Reader["RoomNo"].ToString();
                roomList.Add(room);
            }
            Reader.Close();
            Connection.Close();
            return roomList;
        }
    }
}