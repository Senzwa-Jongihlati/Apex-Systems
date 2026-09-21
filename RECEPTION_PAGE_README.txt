APEX ROLE LOGIN AND RECEPTION MANAGEMENT
========================================

OPEN THE PROJECT
----------------
1. Open apex_management_sys/apex_management_sys.csproj in Visual Studio 2022.
2. Make sure MySQL Server is running and ApexSystemsDB already exists.
3. Build the project and run it.
4. At the first login, the program upgrades the existing database automatically.

ADMIN LOGIN
-----------
Username: admin
Password: Admin@2026

The administrator opens the main dashboard and can view the wider system.
The administrator cannot use Reception Management because that page is reserved
for the receptionist role.

RECEPTIONIST LOGIN
------------------
Username: receptionist
Password: Reception@2026

The receptionist opens Reception Management directly and cannot open the admin
dashboard. The receptionist menu only contains Reception, New patient, Change
login, and Logout.

RECEPTION MANAGEMENT FEATURES
------------------------------
- Register a patient using name, surname, SA ID or passport, contact number,
  emergency contact number, date of birth, gender, and address.
- Generate the patient number automatically, for example PATIENT001.
- Search using patient ID, first name, surname, full name, SA ID, or passport.
- Select a patient from the table and update their details.
- Record and display the date and time a patient was registered automatically.
- Keep the search area in a separate row so it never covers patient records.
- Use the full APEX logo and bottom-left account/logout navigation.
- Change the receptionist username and password securely.
- Require a password change after three months.
- Store passwords as BCrypt hashes instead of plain text.

DATABASE UPDATE
---------------
The application adds EmergencyContactNumber, UserRole, and PasswordChangedAt
to an existing database automatically. A manual backup script is also included:

database/upgrade_reception_management.sql

SECURITY NOTE
-------------
Change both default passwords after the first successful login.
