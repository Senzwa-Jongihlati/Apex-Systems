using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace apex_management_sys
{
    internal static class DatabaseHelper
    {
        private static readonly string connectionString =
          ConfigurationManager.ConnectionStrings["ApexConnection"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}