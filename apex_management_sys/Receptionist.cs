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
        private string passwordHash;
        private string contactNumber;
        private string email;
        private DateTime dateHired;
        private bool isActive;

        // Use this when adding a NEW receptionist.
        // ReceptionistID stays 0 until the database generates it (AUTO_INCREMENT).
        public Receptionist(string firstName, string lastName, string username,
                            string passwordHash, string contactNumber, string email,
                            DateTime dateHired)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.passwordHash = passwordHash;
            this.contactNumber = contactNumber;
            this.email = email;
            this.dateHired = dateHired;
            this.isActive = true;
        }

        // Use this when loading an EXISTING receptionist from the database.
        public Receptionist(int receptionistID, string firstName, string lastName,
                            string username, string passwordHash, string contactNumber,
                            string email, DateTime dateHired, bool isActive)
            : this(firstName, lastName, username, passwordHash, contactNumber, email, dateHired)
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

        public string PasswordHash
        {
            get { return passwordHash; }
            set { passwordHash = value; }
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