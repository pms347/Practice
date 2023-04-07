using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Practice
{
    class DBConnection
    {
        public DBConnection()
        {
            string conStr = @"Data Source=DHHCLPF0Y9ZV0\SQLSERVER08;Initial Catalog=Practice;User Id=sa;Password=abc$$$123";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"Data Source=DHHCLPF0Y9ZV0\SQLSERVER08;Initial Catalog=Practice;User Id=sa;Password=abc$$$123";
                conn.Open();
                // using the code here...  
            }
        }
    }
}
