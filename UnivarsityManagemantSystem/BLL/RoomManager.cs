using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using UnivarsityManagemantSystem.Gateway;


namespace UnivarsityManagemantSystem.BLL
{
    public class RoomManager
    {
        RoomGateway aRoomGateway = new RoomGateway();

        public List<Room> GetAllRooms()
        {
            return aRoomGateway.GetAllRooms();
        }
    }
}