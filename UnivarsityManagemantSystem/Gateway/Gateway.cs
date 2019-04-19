using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace UnivarsityManagemantSystem.Gateway
{
    public class Gateway
    {


        private string connectionString = WebConfigurationManager.ConnectionStrings["UVCon"].ConnectionString;
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public string Query { get; set; }


        public Gateway()
        {
            Connection = new SqlConnection(connectionString);
        }

    }
}