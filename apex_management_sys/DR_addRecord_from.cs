using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace apex_management_sys
{
    public partial class DR_addRecord_from : Form
    {
        private readonly int _queueId;

        public DR_addRecord_from()
        {
            InitializeComponent();
        }

        public DR_addRecord_from(int queueId)
        {
            InitializeComponent();
            _queueId = queueId;

            button1.Click += button1_Click_1;
            button2.Click += button2_Click;

            LoadPatientRecord();
        }

        private void LoadPatientRecord()
        {
            const string sql = @"
                SELECT q.QueueNumber, q.ReasonForVisit,
                       p.PatientID, p.FirstName, p.LastName, p.DateOfBirth, p.Gender, p.ContactNumber,
                       pl.LevelName
                FROM Queue q
                JOIN Patient p ON p.PatientID = q.PatientID
                JOIN PriorityLevel pl ON pl.PriorityID = q.PriorityID
                WHERE q.QueueID = @queueId";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@queueId", _queueId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return;

                    int queueNumber = reader.GetInt32(0);
                    string reason = reader.GetString(1);
                    int patientId = reader.GetInt32(2);
                    string firstName = reader.GetString(3);
                    string lastName = reader.GetString(4);
                    DateTime dob = reader.GetDateTime(5);
                    string gender = reader.GetString(6);
                    string contact = reader.GetString(7);
                    string priority = reader.GetString(8);

                    label2.Text = $"{firstName} {lastName}";
                    label1.Text = $"Patient no. {patientId} \u00b7 queue no. {queueNumber:000}";
                    label3.Text = priority;
                    label3.ForeColor = priority == "Emergency" ? Color.Red
                                      : priority == "Urgent" ? Color.OrangeRed
                                      : Color.Black;

                    textBox3.Text = contact;
                    textBox2.Text = gender;
                    textBox1.Text = dob.ToString("yyyy-MM-dd");
                    txtVisitReason.Text = reason;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiagnosis.Text))
            {
                MessageBox.Show("Please enter a diagnosis before saving.", "Missing diagnosis",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNotes.Text))
            {
                MessageBox.Show("Please enter your notes", "Missing Notes",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Save this consultation note and mark the patient as completed?\nThis cannot be undone.",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            using (var conn = DatabaseHelper.GetConnection())
            {
                using (var cmd = new MySqlCommand(
                    @"INSERT INTO ConsultationNote (QueueID, DoctorID, Diagnosis, Prescription, Notes, CreatedTime)
              VALUES (@queueId, @doctorId, @diagnosis, @prescription, @notes, NOW())", conn))
                {
                    cmd.Parameters.AddWithValue("@queueId", _queueId);
                    cmd.Parameters.AddWithValue("@doctorId", Session.CurrentUser.StaffId);
                    cmd.Parameters.AddWithValue("@diagnosis", txtDiagnosis.Text.Trim());
                    cmd.Parameters.AddWithValue("@prescription", txtPrescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@notes", txtNotes.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new MySqlCommand(
                    "UPDATE Queue SET Status = 'Completed', CompletedTime = NOW() WHERE QueueID = @queueId", conn))
                {
                    cmd.Parameters.AddWithValue("@queueId", _queueId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Consultation note saved successfully.", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DR_PatientHistory history = new DR_PatientHistory(_queueId);
            history.ShowDialog();
        }

    }
}