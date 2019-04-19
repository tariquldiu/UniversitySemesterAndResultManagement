using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using UnivarsityManagemantSystem.Models;


namespace UnivarsityManagemantSystem.Gateway
{
    public class DepartmentGateway:Gateway
    {
        public int Save(Department department)
        {

            Query = "Insert Into Department_tb(Code,Name) Values(@code,@name)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("code", department.DeptCode);
            Command.Parameters.AddWithValue("name", department.DeptName);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }

        public List<Department> getAllDepartment() 
        {
            Query = "SELECT * FROM Department_tb";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Department> departments = new List<Department>(); 
            while(Reader.Read())
            {
                Department department = new Department();
                department.DeptId = (int)Reader["Id"];
                department.DeptCode = Reader["Code"].ToString();
                department.DeptName = Reader["Name"].ToString();
                departments.Add(department);
            }
            Reader.Close();
            Connection.Close();
            return departments;
        }
        public bool IsExistCode(string departmentCode) 
        {

            Query = "SELECT * FROM Department_tb where Code='" +departmentCode+ "' ";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                Connection.Close();
                return true;

            } 
            else
            {
                Connection.Close();
                return false;
            }
        }
        public bool IsExistName(string departmentName)
        {
            Query = "SELECT * FROM Department_tb where Name='" + departmentName + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            if(Reader.HasRows)
            {
                Connection.Close();
                return true;
            }
            else
            {
                Connection.Close();
                return false;
            }
        }
        

    }
}