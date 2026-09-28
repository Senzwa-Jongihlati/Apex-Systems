using ApexSystems;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace apex_management_sys
{
    public partial class Registration : Form
    {
        private bool isQueueMode = false;
        private int existingPatientId = 0;
        public Registration(DataRowView existingPatient)
        {
            InitializeComponent();
            isQueueMode = true;
            existingPatientId = Convert.ToInt32(existingPatient["ID"]);

            txtName.Text = existingPatient["First Name"].ToString();
            txtSurname.Text = existingPatient["Last Name"].ToString();
            cbIDType.Text = existingPatient["ID Type"].ToString();
            txtID.Text = existingPatient["ID / Passport"].ToString();
            txtPhoneNo.Text = existingPatient["Contact"].ToString();
            txtEmergancyContact.Text = existingPatient["Emergency"].ToString();

            LoadRemainingFieldsFromDb(existingPatientId); // DOB/Gender/Address aren't in the SearchPatient grid

            foreach (Control c in new Control[] {txtName, txtSurname, cbIDType, txtID,cbGender, dateTimePicker1, txtPhoneNo, txtEmergancyContact, txtAddress})
                c.Enabled = false;

            btnRegisterPatient.Text = "Add to Queue";
        }
        public Registration()
        {
            InitializeComponent();

        }

        // ---------- Validation helpers ----------

        private bool Fail(Control field, string message, string title = "Invalid Input")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            field.Focus();
            return false;
        }

        private static bool IsValidName(string s) =>
            Regex.IsMatch(s, @"^\p{L}[\p{L} '\-]{1,49}$");

        private static bool IsValidPhone(string s) =>
            Regex.IsMatch(s, @"^0\d{9}$");   // SA format: 10 digits starting with 0

        private bool ValidatePatientDetails()
        {
            string firstName = txtName.Text.Trim();
            string lastName = txtSurname.Text.Trim();
            string idNumber = txtID.Text.Trim();
            string phone = txtPhoneNo.Text.Trim();
            string emergency = txtEmergancyContact.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName))
                return Fail(txtName, "First name is required.", "Missing Info");
            if (!IsValidName(firstName))
                return Fail(txtName, "First name can only contain letters, spaces, hyphens and apostrophes (2-50 characters).");

            if (string.IsNullOrWhiteSpace(lastName))
                return Fail(txtSurname, "Surname is required.", "Missing Info");
            if (!IsValidName(lastName))
                return Fail(txtSurname, "Surname can only contain letters, spaces, hyphens and apostrophes (2-50 characters).");

            if (cbIDType.SelectedIndex == -1)
                return Fail(cbIDType, "Please select an identification type.", "Missing Info");

            if (string.IsNullOrEmpty(idNumber))
                return Fail(txtID, "Identification number is required.", "Missing Info");

            bool isPassport = cbIDType.Text.IndexOf("passport", StringComparison.OrdinalIgnoreCase) >= 0;
            if (isPassport)
            {
                if (!Regex.IsMatch(idNumber, @"^[A-Za-z0-9]{6,15}$"))
                    return Fail(txtID, "Passport number must be 6-15 letters/numbers with no spaces.");
            }
            else if (!Regex.IsMatch(idNumber, @"^\d{13}$"))
            {
                return Fail(txtID, "ID number must be exactly 13 digits.");
            }

            if (cbGender.SelectedIndex == -1)
                return Fail(cbGender, "Please select a gender.", "Missing Info");

            DateTime dob = dateTimePicker1.Value.Date;
            if (dob > DateTime.Today)
                return Fail(dateTimePicker1, "Date of birth cannot be in the future.");
            if (dob < DateTime.Today.AddYears(-120))
                return Fail(dateTimePicker1, "Please check the date of birth.");
            if (dob == DateTime.Today &&
                MessageBox.Show("The date of birth is set to today. Is this correct?", "Confirm Date of Birth",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                dateTimePicker1.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(phone))
                return Fail(txtPhoneNo, "Phone number is required.", "Missing Info");
            if (!IsValidPhone(phone))
                return Fail(txtPhoneNo, "Phone number must be 10 digits and start with 0 (e.g. 0821234567).");

            if (string.IsNullOrEmpty(emergency))
                return Fail(txtEmergancyContact, "Emergency contact is required.", "Missing Info");
            if (!IsValidPhone(emergency))
                return Fail(txtEmergancyContact, "Emergency contact must be 10 digits and start with 0.");

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
                return Fail(txtAddress, "Address is required.", "Missing Info");

            return true;
        }

        private bool ValidateVisitDetails()
        {
            if (cbPriority.SelectedIndex == -1)
                return Fail(cbPriority, "Please select a priority level.", "Missing Info");

            if (string.IsNullOrWhiteSpace(txtReasonForVisit.Text))
                return Fail(txtReasonForVisit, "Please enter the reason for the visit.", "Missing Info");

            return true;
        }

        private bool PatientIdExists(string idNumber)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(
                "SELECT COUNT(*) FROM Patient WHERE IdentificationNumber = @IdNumber", conn))
            {
                cmd.Parameters.AddWithValue("@IdNumber", idNumber);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }
        public void CenterPanel()
        {
            Main.Left = (this.ClientSize.Width - Main.Width) / 2;
            Main.Top = (this.ClientSize.Height - Main.Height) / 2;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            RP_Queue Queue = new RP_Queue();
            Queue.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Background_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private void Queue_Click(object sender, EventArgs e)
        {
            RP_Queue Q = new RP_Queue();
            Q.Show();
            this.Close();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Close();
        }
        private void LoadRemainingFieldsFromDb(int patientId)
        {
            string query = "SELECT DateOfBirth, Gender, Address FROM Patient WHERE PatientID = @PatientID";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dateTimePicker1.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                        cbGender.Text = reader["Gender"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                    }
                }
            }
        }

        private bool PatientHasActiveQueueEntry(int patientId)
        {
            string query = "SELECT COUNT(*) FROM Queue WHERE PatientID = @PatientID AND Status = 'Waiting'";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void AddExistingPatientToQueue()
        {
            try
            {
                if (PatientHasActiveQueueEntry(existingPatientId))
                {
                    MessageBox.Show("This patient already has an active queue entry.", "Already in Queue",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query2 = @"INSERT INTO Queue (QueueNumber, PatientID, PriorityID, ReceptionistID, ReasonForVisit)
            SELECT COALESCE(MAX(QueueNumber), 0) + 1,
                   @PatientID,
                   (SELECT PriorityID FROM PriorityLevel WHERE LevelName = @Priority),
                   @ReceptionistID,
                   @ReasonForVisit
            FROM Queue
            WHERE DATE(CheckInTime) = CURDATE()";

                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                using (MySqlCommand cmd2 = new MySqlCommand(query2, conn))
                {
                    cmd2.Parameters.AddWithValue("@PatientID", existingPatientId);
                    cmd2.Parameters.AddWithValue("@Priority", cbPriority.Text);
                    cmd2.Parameters.AddWithValue("@ReceptionistID", Session.CurrentUser.StaffId);
                    cmd2.Parameters.AddWithValue("@ReasonForVisit", txtReasonForVisit.Text.Trim());
                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Patient added to queue.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding patient to queue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            if (isQueueMode)
            {
                if (!ValidateVisitDetails()) return;
                AddExistingPatientToQueue();
                return;
            }

            if (!ValidatePatientDetails() || !ValidateVisitDetails()) return;

            string idNumber = txtID.Text.Trim();

            try
            {
                if (PatientIdExists(idNumber))
                {
                    MessageBox.Show(
                        "A patient with this identification number is already registered.\nUse Search Patient to add them to the queue.",
                        "Duplicate Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                    return;
                }

                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                using (MySqlTransaction tx = conn.BeginTransaction())
                {
                    const string insertPatient = @"INSERT INTO Patient
                (FirstName, LastName, DateOfBirth, Gender, IdentificationType, IdentificationNumber,
                 ContactNumber, Address, RegisteredDate, EmergencyContact)
                VALUES
                (@FirstName, @LastName, @DateOfBirth, @Gender, @IdentificationType, @IdentificationNumber,
                 @ContactNumber, @Address, @RegisteredDate, @EmergencyContact)";

                    const string insertQueue = @"INSERT INTO Queue (QueueNumber, PatientID, PriorityID, ReceptionistID, ReasonForVisit)
                SELECT COALESCE(MAX(QueueNumber), 0) + 1,
                       LAST_INSERT_ID(),
                       (SELECT PriorityID FROM PriorityLevel WHERE LevelName = @Priority),
                       @ReceptionistID,
                       @ReasonForVisit
                FROM Queue
                WHERE DATE(CheckInTime) = CURDATE()";

                    using (MySqlCommand cmd = new MySqlCommand(insertPatient, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtSurname.Text.Trim());
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@Gender", cbGender.Text);
                        cmd.Parameters.AddWithValue("@IdentificationType", cbIDType.Text);
                        cmd.Parameters.AddWithValue("@IdentificationNumber", idNumber);
                        cmd.Parameters.AddWithValue("@ContactNumber", txtPhoneNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@RegisteredDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@EmergencyContact", txtEmergancyContact.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd2 = new MySqlCommand(insertQueue, conn, tx))
                    {
                        cmd2.Parameters.AddWithValue("@Priority", cbPriority.Text);
                        cmd2.Parameters.AddWithValue("@ReceptionistID", Session.CurrentUser.StaffId);
                        cmd2.Parameters.AddWithValue("@ReasonForVisit", txtReasonForVisit.Text.Trim());
                        cmd2.ExecuteNonQuery();
                    }

                    tx.Commit();   // if anything above throws, disposing tx rolls both inserts back
                }

                MessageBox.Show("Patient registered successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;   // refreshes Search Patient
                this.Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("This patient is already registered (duplicate identification number).",
                    "Duplicate Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering patient: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbIdententificationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Registration_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}