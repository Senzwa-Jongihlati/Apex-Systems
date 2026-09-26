using ApexSystems;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace apex_management_sys
{
    public static class AuthService
    {
        public static User Authenticate(string username, string password)
        {
            User user = LoadFromTable("doctor", "DoctorID", username)
                     ?? LoadFromTable("receptionist", "ReceptionistID", username);

            if (user == null || !user.VerifyPassword(password))
                return null;

            return user;
        }

        private static User LoadFromTable(string tableName, string idColumn, string username)
        {
            using var conn = DatabaseHelper.GetConnection();
            string query = $"SELECT * FROM {tableName} WHERE Username = @username";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            User user = reader.GetString("Role") switch
            {
                "Doctor" => new Doctor(),
                "Admin" => new Administrator(),
                _ => new Receptionist()
            };

            user.StaffId = reader.GetInt32(idColumn);
            user.FirstName = reader.GetString("FirstName");
            user.LastName = reader.GetString("LastName");
            user.Username = reader.GetString("Username");
            user.PasswordHash = reader.GetString("PasswordHash");
            user.ContactNumber = reader["ContactNumber"] as string;
            user.Email = reader["Email"] as string;
            user.DateHired = reader.GetDateTime("DateHired");
            user.IsActive = reader.GetBoolean("IsActive");
            user.Experience = reader["Experience"] as string;
            user.Address = reader["Address"] as string;

            return user;
        }
    }
}
