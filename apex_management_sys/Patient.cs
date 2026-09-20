using System;
using System.Collections.Generic;
using System.Text;
namespace ApexSystems
{
    public class Patient
    {
        private int patientID;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string gender;
        private string identificationType;
        private string identificationNumber;
        private string contactNumber;
        private string address;
        private DateTime registeredDate;

        // Use this when registering a NEW patient.
        // PatientID stays 0 until the database generates it (AUTO_INCREMENT).
        public Patient(string firstName, string lastName, DateTime dateOfBirth, string gender,
                       string identificationType, string identificationNumber,
                       string contactNumber, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            IdentificationType = identificationType;   // goes through the validation in the property
            this.identificationNumber = identificationNumber;
            this.contactNumber = contactNumber;
            this.address = address;
            this.registeredDate = DateTime.Now;
        }

        // Use this when loading an EXISTING patient from the database.
        public Patient(int patientID, string firstName, string lastName, DateTime dateOfBirth,
                       string gender, string identificationType, string identificationNumber,
                       string contactNumber, string address, DateTime registeredDate)
            : this(firstName, lastName, dateOfBirth, gender, identificationType,
                   identificationNumber, contactNumber, address)
        {
            this.patientID = patientID;
            this.registeredDate = registeredDate;
        }

        public int PatientID
        {
            get { return patientID; }
            set { patientID = value; }   // set once after the INSERT returns the new ID
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

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        // Mirrors the CHECK constraint in the Patient table.
        public string IdentificationType
        {
            get { return identificationType; }
            set
            {
                if (value != "SA ID" && value != "Passport")
                    throw new ArgumentException("Identification type must be 'SA ID' or 'Passport'.");
                identificationType = value;
            }
        }

        public string IdentificationNumber
        {
            get { return identificationNumber; }
            set { identificationNumber = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime RegisteredDate
        {
            get { return registeredDate; }   // read-only: set once at registration
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public int GetAge()
        {
            int age = DateTime.Today.Year - dateOfBirth.Year;

            // Subtract a year if the birthday hasn't happened yet this year.
            if (dateOfBirth.Date > DateTime.Today.AddYears(-age))
                age--;

            return age;
        }
    }
}