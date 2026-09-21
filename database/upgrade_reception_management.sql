USE ApexSystemsDB;

-- Optional manual upgrade. The application also checks these columns at login.
SET @has_emergency = (
    SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'Patient'
      AND COLUMN_NAME = 'EmergencyContactNumber'
);
SET @sql = IF(@has_emergency = 0,
    'ALTER TABLE Patient ADD COLUMN EmergencyContactNumber VARCHAR(20) NULL AFTER ContactNumber',
    'SELECT 1');
PREPARE statement FROM @sql;
EXECUTE statement;
DEALLOCATE PREPARE statement;

SET @has_password_date = (
    SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'Receptionist'
      AND COLUMN_NAME = 'PasswordChangedAt'
);
SET @sql = IF(@has_password_date = 0,
    'ALTER TABLE Receptionist ADD COLUMN PasswordChangedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP AFTER PasswordHash',
    'SELECT 1');
PREPARE statement FROM @sql;
EXECUTE statement;
DEALLOCATE PREPARE statement;

SET @has_role = (
    SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'Receptionist'
      AND COLUMN_NAME = 'UserRole'
);
SET @sql = IF(@has_role = 0,
    'ALTER TABLE Receptionist ADD COLUMN UserRole VARCHAR(20) NOT NULL DEFAULT ''Receptionist'' AFTER Username',
    'SELECT 1');
PREPARE statement FROM @sql;
EXECUTE statement;
DEALLOCATE PREPARE statement;
