using System;
using System.Collections.Generic;
using System.Text;
namespace ApexSystems
{
    public class Receptionist
    {
        private int receptionistID;
        private string firstName;
        private string lastName;
        private string username;
        private string userRole;
        private string passwordHash;
        private DateTime passwordChangedAt;
        private string contactNumber;
        private string email;
        private DateTime dateHired;
        private bool isActive;

        // Use this when adding a NEW receptionist.
        // ReceptionistID stays 0 until the database generates it (AUTO_INCREMENT).
        public Receptionist(string firstName, string lastName, string username,
                            string userRole, string passwordHash, string contactNumber, string email,
                            DateTime dateHired, DateTime passwordChangedAt)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.userRole = userRole;
            this.passwordHash = passwordHash;
            this.passwordChangedAt = passwordChangedAt;
            this.contactNumber = contactNumber;
            this.email = email;
            this.dateHired = dateHired;
            this.isActive = true;
        }

        // Use this when loading an EXISTING receptionist from the database.
        public Receptionist(int receptionistID, string firstName, string lastName,
                            string username, string userRole, string passwordHash, string contactNumber,
                            string email, DateTime dateHired, bool isActive,
                            DateTime passwordChangedAt)
            : this(firstName, lastName, username, userRole, passwordHash, contactNumber, email,
                   dateHired, passwordChangedAt)
        {
            this.receptionistID = receptionistID;
            this.isActive = isActive;
        }

        public int ReceptionistID
        {
            get { return receptionistID; }
            set { receptionistID = value; }   // set once after the INSERT returns the new ID
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }

        public bool IsAdministrator()
        {
            return string.Equals(userRole, "Admin", StringComparison.OrdinalIgnoreCase);
        }

        public bool IsReceptionist()
        {
            return string.Equals(userRole, "Receptionist", StringComparison.OrdinalIgnoreCase);
        }

        public string PasswordHash
        {
            get { return passwordHash; }
            set { passwordHash = value; }
        }

        public DateTime PasswordChangedAt
        {
            get { return passwordChangedAt; }
            set { passwordChangedAt = value; }
        }

        public bool PasswordHasExpired()
        {
            return DateTime.Now >= passwordChangedAt.AddMonths(3);
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DateHired
        {
            get { return dateHired; }
            set { dateHired = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        // Requires the BCrypt.Net-Next NuGet package.
        public bool VerifyPassword(string password)
        {
            // Deactivated staff can't log in, even with the right password.
            if (!isActive)
                return false;

            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
