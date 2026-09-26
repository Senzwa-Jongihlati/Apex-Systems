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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }
        private void LoadAllAppointments()
        {
            string query = @"
        SELECT 
            a.AppointmentID AS 'ID',
            CONCAT(p.FirstName, ' ', p.LastName) AS 'Patient',
            CONCAT(d.FirstName, ' ', d.LastName) AS 'Doctor',
            a.AppointmentDateTime AS 'Date & Time',
            a.ReasonForVisit AS 'Reason for Visit',
            a.Status
        FROM Appointment a
        INNER JOIN Patient p ON a.PatientID = p.PatientID
        INNER JOIN Doctor d ON a.DoctorID = d.DoctorID
        WHERE Status <> 'Cancelled' AND Status <>'Completed'
        ORDER BY a.AppointmentDateTime ASC";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    AppointmentsGrid.DataSource = table;

                }
            }

            AppointmentsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AppointmentsGrid.ColumnHeadersDefaultCellStyle.Font = new Font(AppointmentsGrid.Font, FontStyle.Bold);

            foreach (DataGridViewColumn column in AppointmentsGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            AppointmentsGrid.ClearSelection();
            AppointmentsGrid.CurrentCell = null;
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                LoadAllAppointments();
                LoadDoctors();
                btnQueue.Visible = Session.CurrentUser.HasPermission(Permission.ManageQueue);
                btnDoctors.Visible = Session.CurrentUser.HasPermission(Permission.AddConsultationNote);
                btnAppointments.Visible = Session.CurrentUser.HasPermission(Permission.BookAppointment);
                btnPatients.Visible = Session.CurrentUser.HasPermission(Permission.ViewPatientRecords);
                btnEmployees.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
                btnDashboard.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
                Main.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);

                btnAppointments.Enabled = false;

            }));
        }
        private void AppointmentsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;
            string columnName = AppointmentsGrid.Columns[e.ColumnIndex].Name;

            // Double-click Reason for Visit
            if (columnName == "Reason for Visit")
            {
                string reason = AppointmentsGrid.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex]
                    .Value?.ToString();

                MessageBox.Show(
                    reason,
                    "Reason for Visit",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (AppointmentsGrid.Columns[e.ColumnIndex].Name != "Status")
                return;

            // Allow editing temporarily
            AppointmentsGrid.ReadOnly = false;

            Rectangle cellRectangle = AppointmentsGrid.GetCellDisplayRectangle(
                e.ColumnIndex,
                e.RowIndex,
                true);

            ComboBox statusComboBox = new ComboBox();

            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            statusComboBox.Items.Add("Scheduled");
            statusComboBox.Items.Add("Completed");
            statusComboBox.Items.Add("Cancelled");

            // Put ComboBox directly over the Status cell
            statusComboBox.Location = cellRectangle.Location;
            statusComboBox.Size = cellRectangle.Size;

            // Show the current Status
            statusComboBox.SelectedItem =
                AppointmentsGrid.Rows[e.RowIndex]
                .Cells[e.ColumnIndex]
                .Value?.ToString();

            AppointmentsGrid.Controls.Add(statusComboBox);

            statusComboBox.BringToFront();
            statusComboBox.Focus();
            statusComboBox.DroppedDown = true;

            // When the user chooses a new Status
            statusComboBox.SelectedIndexChanged += (s, args) =>
            {
                AppointmentsGrid.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex]
                    .Value = statusComboBox.SelectedItem?.ToString();

                // Remove the ComboBox
                AppointmentsGrid.Controls.Remove(statusComboBox);
                statusComboBox.Dispose();

                // Make the entire grid read-only again
                AppointmentsGrid.ReadOnly = true;

                // Remove the cell selection
                AppointmentsGrid.ClearSelection();
                AppointmentsGrid.CurrentCell = null;
            };
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                foreach (DataGridViewRow row in AppointmentsGrid.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    int appointmentID = Convert.ToInt32(row.Cells["ID"].Value);
                    string status = row.Cells["Status"].Value?.ToString();

                    string query = @"
                UPDATE Appointment
                SET Status = @Status
                WHERE AppointmentID = @AppointmentID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@AppointmentID", appointmentID);

                        command.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show(
                "Appointment changes saved successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadAllAppointments();
        }

        private void BookAppointment_Click(object sender, EventArgs e)
        {
            string identificationNumber = txtPatient.Text.Trim();

            if (string.IsNullOrWhiteSpace(identificationNumber))
            {
                MessageBox.Show(
                    "Please enter the patient's ID or passport number.",
                    "Patient Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            int doctorID = Convert.ToInt32(cmbDoctor.SelectedValue);

            DateTime appointmentDateTime = dateTimePicker1.Value;

            string reason = txtReason.Text.Trim();

            if (string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show(
                    "Please enter a reason for the visit.",
                    "Reason Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {

                // Find the patient's database ID using their ID/passport number
                string patientQuery = @"
                SELECT PatientID
                FROM Patient
                WHERE IdentificationNumber = @IdentificationNumber";

                int patientID;

                using (MySqlCommand patientCommand = new MySqlCommand(patientQuery, connection))
                {
                    patientCommand.Parameters.AddWithValue(
                        "@IdentificationNumber",
                        identificationNumber);

                    object result = patientCommand.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show(
                            "No patient was found with that ID or passport number.",
                            "Patient Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    patientID = Convert.ToInt32(result);
                }

                // Book the appointment
                string appointmentQuery = @"
                INSERT INTO Appointment
                (
                    PatientID,
                    DoctorID,
                    ReceptionistID,
                    AppointmentDateTime,
                    ReasonForVisit,
                    Status
                )
                VALUES
                (
                    @PatientID,
                    @DoctorID,
                    @ReceptionistID,
                    @AppointmentDateTime,
                    @ReasonForVisit,
                    'Scheduled'
                )";

                using (MySqlCommand appointmentCommand =
                       new MySqlCommand(appointmentQuery, connection))
                {
                    appointmentCommand.Parameters.AddWithValue("@PatientID", patientID);
                    appointmentCommand.Parameters.AddWithValue("@DoctorID", doctorID);
                    appointmentCommand.Parameters.AddWithValue("@ReceptionistID", Session.CurrentUser.StaffId);
                    appointmentCommand.Parameters.AddWithValue("@AppointmentDateTime", appointmentDateTime);
                    appointmentCommand.Parameters.AddWithValue("@ReasonForVisit", reason);

                    appointmentCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Appointment booked successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadAllAppointments();

            txtPatient.Clear();
            cmbDoctor.SelectedIndex = -1;
            txtReason.Clear();
        }
        private void LoadDoctors()
        {
            string query = @"
            SELECT 
                DoctorID,
                CONCAT(FirstName, ' ', LastName) AS DoctorName
            FROM Doctor
            ORDER BY FirstName, LastName ASC";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbDoctor.DataSource = table;
                cmbDoctor.DisplayMember = "DoctorName";
                cmbDoctor.ValueMember = "DoctorID";
            }
            cmbDoctor.SelectedIndex = -1;
        }

        private void CancelAddition_Click(object sender, EventArgs e)
        {
            txtPatient.Clear();
            cmbDoctor.SelectedIndex = -1;
            txtReason.Clear();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Close();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            RP_SearchPatient r = new RP_SearchPatient();
            r.Show();
            this.Close();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            DR_Doctor d = new DR_Doctor();
            d.Show();
            this.Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            newAccount na = new newAccount();
            na.Show();
            this.Close();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Appointment a = new Appointment();
            a.Show();
            this.Close();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            RP_Queue q = new RP_Queue();
            q.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            Login.Instance.Show();
            this.Close();
        }
    }
}
