using MySql.Data.MySqlClient;

namespace apex_management_sys
{
    internal static class DatabaseMigration
    {
        public const string DefaultUsername = "receptionist";
        public const string DefaultPassword = "Reception@2026";
        public const string AdminUsername = "admin";
        public const string AdminPassword = "Admin@2026";

        public static void EnsureLatestSchema()
        {
            using MySqlConnection conn = DatabaseHelper.GetConnection();

            AddColumnIfMissing(
                conn,
                "Patient",
                "EmergencyContactNumber",
                "ALTER TABLE Patient ADD COLUMN EmergencyContactNumber VARCHAR(20) NULL AFTER ContactNumber");

            AddColumnIfMissing(
                conn,
                "Receptionist",
                "PasswordChangedAt",
                "ALTER TABLE Receptionist ADD COLUMN PasswordChangedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP AFTER PasswordHash");

            AddColumnIfMissing(
                conn,
                "Receptionist",
                "UserRole",
                "ALTER TABLE Receptionist ADD COLUMN UserRole VARCHAR(20) NOT NULL DEFAULT 'Receptionist' AFTER Username");

            const string updateExamples = @"
                UPDATE Receptionist
                SET PasswordHash = @PasswordHash,
                    PasswordChangedAt = CURRENT_TIMESTAMP
                WHERE PasswordHash LIKE '%examplehash%'";

            using (MySqlCommand update = new(updateExamples, conn))
            {
                update.Parameters.AddWithValue(
                    "@PasswordHash",
                    BCrypt.Net.BCrypt.HashPassword("Admin123"));
                update.ExecuteNonQuery();
            }

            const string createReceptionist = @"
                INSERT INTO Receptionist
                    (FirstName, LastName, Username, UserRole, PasswordHash, PasswordChangedAt,
                     ContactNumber, Email, DateHired, IsActive)
                SELECT 'Apex', 'Receptionist', @Username, 'Receptionist', @PasswordHash, CURRENT_TIMESTAMP,
                       NULL, 'receptionist@apexsystems.co.za', CURRENT_DATE, 1
                WHERE NOT EXISTS
                    (SELECT 1 FROM Receptionist WHERE Email = 'receptionist@apexsystems.co.za')";

            using (MySqlCommand insert = new(createReceptionist, conn))
            {
                insert.Parameters.AddWithValue("@Username", DefaultUsername);
                insert.Parameters.AddWithValue(
                    "@PasswordHash",
                    BCrypt.Net.BCrypt.HashPassword(DefaultPassword));
                insert.ExecuteNonQuery();
            }

            const string createAdmin = @"
                INSERT INTO Receptionist
                    (FirstName, LastName, Username, UserRole, PasswordHash, PasswordChangedAt,
                     ContactNumber, Email, DateHired, IsActive)
                SELECT 'System', 'Administrator', @Username, 'Admin', @PasswordHash, CURRENT_TIMESTAMP,
                       NULL, 'admin@apexsystems.co.za', CURRENT_DATE, 1
                WHERE NOT EXISTS
                    (SELECT 1 FROM Receptionist WHERE Email = 'admin@apexsystems.co.za')";

            using MySqlCommand adminInsert = new(createAdmin, conn);
            adminInsert.Parameters.AddWithValue("@Username", AdminUsername);
            adminInsert.Parameters.AddWithValue(
                "@PasswordHash",
                BCrypt.Net.BCrypt.HashPassword(AdminPassword));
            adminInsert.ExecuteNonQuery();
        }

        private static void AddColumnIfMissing(
            MySqlConnection conn,
            string tableName,
            string columnName,
            string alterSql)
        {
            const string existsSql = @"
                SELECT COUNT(*)
                FROM INFORMATION_SCHEMA.COLUMNS
                WHERE TABLE_SCHEMA = DATABASE()
                  AND TABLE_NAME = @TableName
                  AND COLUMN_NAME = @ColumnName";

            using MySqlCommand exists = new(existsSql, conn);
            exists.Parameters.AddWithValue("@TableName", tableName);
            exists.Parameters.AddWithValue("@ColumnName", columnName);

            if (Convert.ToInt32(exists.ExecuteScalar()) > 0)
                return;

            using MySqlCommand alter = new(alterSql, conn);
            alter.ExecuteNonQuery();
        }
    }
}
