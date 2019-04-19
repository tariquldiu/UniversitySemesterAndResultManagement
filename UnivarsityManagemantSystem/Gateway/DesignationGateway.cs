using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivarsityManagemantSystem.Models;
using System.Data.SqlClient;

namespace UnivarsityManagemantSystem.Gateway
{
    public class DesignationGateway:Gateway
    {
        public List<Designation> getAllDesignation() 
        {
            Query = "SELECT * FROM Designation_tb";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Designation> designations = new List<Designation>();
            while (Reader.Read())
            {
                Designation designation = new Designation();
                designation.DesiId = (int)Reader["Id"];
                designation.DesiName = Reader["Name"].ToString();

                designations.Add(designation);
            }
            Reader.Close();
            Connection.Close();
            return designations;
        }

    }
}