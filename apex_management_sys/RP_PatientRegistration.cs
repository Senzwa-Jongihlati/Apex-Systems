using ApexSystems;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace apex_management_sys
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

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

        private void button6_Click(object sender, EventArgs e)
        {
            RP_SearchPatient Search = new RP_SearchPatient();
            Search.Show();
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

        private void Patients_Click(object sender, EventArgs e)
        {
            RP_SearchPatient sp = new RP_SearchPatient();
            sp.Show();
            this.Close();
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

        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from the form
                string patientid = txtID.Text;
                string firstName = txtName.Text;
                string lastName = txtSurname.Text;
                DateTime dob = dateTimePicker1.Value;
                string gender = cbGender.Text;
                string contactNumber = txtPhoneNo.Text;
                string address = txtAddress.Text;
                string reasonForVisit = txtReasonForVisit.Text;
                string emergencyContact = txtEmergancyContact.Text;
                //string priority = cbPriority.Text;

                // Connect to database
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"INSERT INTO Patient 
                    (FirstName, LastName, DateOfBirth, Gender, 
                     IdentificationType,IdentificationNumber,ContactNumber, Address,RegisteredDate, 
                     EmergencyContact)
                    VALUES 
                    (@FirstName, @LastName, @DateOfBirth, @Gender,@IdentificationType,@IdentificationNumber,
                     @ContactNumber, @Address, @RegisteredDate,
                     @EmergencyContact)";
                    string query2 = @"INSERT INTO Queue (QueueNumber, PatientID, PriorityID, ReceptionistID, ReasonForVisit)
                    SELECT COALESCE(MAX(QueueNumber), 0) + 1,
                           LAST_INSERT_ID(),
                           (SELECT PriorityID FROM PriorityLevel WHERE LevelName = @Priority),
                           @ReceptionistID,
                           @ReasonForVisit
                    FROM Queue
                    WHERE DATE(CheckInTime) = CURDATE()";

                    using (MySqlTransaction tx = conn.BeginTransaction())
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {

                            cmd.Parameters.AddWithValue("@FirstName", firstName);
                            cmd.Parameters.AddWithValue("@LastName", lastName);
                            cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                            cmd.Parameters.AddWithValue("@Gender", gender);
                            cmd.Parameters.AddWithValue("@IdentificationType", cbIDType.Text); // Assuming txtID contains the identification type
                            cmd.Parameters.AddWithValue("@IdentificationNumber", txtID.Text); // Assuming txtID contains the identification number
                            cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                            cmd.Parameters.AddWithValue("@Address", address);
                            cmd.Parameters.AddWithValue("@RegisteredDate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@EmergencyContact", emergencyContact);

                            cmd.ExecuteNonQuery();
                        }
                        using (MySqlCommand cmd2 = new MySqlCommand(query2, conn))
                        {
                            cmd2.Parameters.AddWithValue("@Priority", cbPriority.Text);
                            cmd2.Parameters.AddWithValue("@ReceptionistID", Session.CurrentReceptionist.ReceptionistID);
                            cmd2.Parameters.AddWithValue("@ReasonForVisit", reasonForVisit.Trim());
                            cmd2.ExecuteNonQuery();
                        }
                        tx.Commit();
                    }
                }

                MessageBox.Show(
                    "Patient registered successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Optional: clear the form
                txtID.Clear();
                txtName.Clear();
                txtSurname.Clear();
                txtPhoneNo.Clear();
                txtAddress.Clear();
                txtReasonForVisit.Clear();
                txtEmergancyContact.Clear();

                cbGender.SelectedIndex = -1;
                cbPriority.SelectedIndex = -1;

                //Refresh Search Patient Form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please check that the Patient ID is a number and all required fields are entered correctly.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    $"Database error: {ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error registering patient: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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