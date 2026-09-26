using System;
using System.Collections.Generic;
using System.Text;

namespace apex_management_sys
{ 
    public abstract class User
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateHired { get; set; }
        public bool IsActive { get; set; }
        public string Experience { get; set; }
        public string Address { get; set; }
        public abstract UserRole Role { get; }

        public string FullName => $"{FirstName} {LastName}";

        private static readonly Dictionary<UserRole, HashSet<Permission>> RolePermissions = new()
        {
            [UserRole.Receptionist] = new HashSet<Permission> { Permission.ManageQueue, Permission.BookAppointment, Permission.ViewPatientRecords },
            [UserRole.Doctor] = new HashSet<Permission> { Permission.ViewPatientRecords, Permission.AddConsultationNote, Permission.ViewPatientHistory },
            [UserRole.Admin] = new HashSet<Permission> { Permission.ManageStaff, Permission.ViewReports, Permission.ManageQueue, Permission.ViewPatientRecords }
        };
        public bool VerifyPassword(string password)
        {
            // Deactivated staff can't log in, even with the right password.
            if (!IsActive)
                return false;

            return BCrypt.Net.BCrypt.Verify(password, PasswordHash);
        }
        public bool HasPermission(Permission permission) => RolePermissions[Role].Contains(permission);
    }
}
