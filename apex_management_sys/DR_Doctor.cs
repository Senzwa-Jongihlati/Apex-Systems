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
    public partial class DR_Doctor : Form
    {
        // Tracks which Queue row is currently shown in the "Up next" panel,
        // so Skip / OPEN Record act on the right patient.
        private int? _currentQueueId = null;

        public DR_Doctor()
        {
            InitializeComponent();
        }

        private void DR_Doctor_Load(object sender, EventArgs e)
        {
            btnQueue.Visible = Session.CurrentUser.HasPermission(Permission.ManageQueue);
            btnDoctors.Visible = Session.CurrentUser.HasPermission(Permission.AddConsultationNote);
            btnAppointments.Visible = Session.CurrentUser.HasPermission(Permission.BookAppointment);
            btnPatients.Visible = Session.CurrentUser.HasPermission(Permission.ViewPatientRecords);
            btnEmployees.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
            btnDashboard.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
            Main.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);

            btnDoctors.Enabled = false;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;

            lblWelcome.Text = $"Welcome Dr {Session.CurrentUser.LastName}";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            LoadDashboardCounts();
            LoadUpNextPatient();
            LoadTodaysAppointments();
        }

        private void LoadDashboardCounts()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (var cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM Queue WHERE Status = 'Waiting' AND DATE(CheckInTime) = CURDATE()", conn))
                {
                    label6.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                }

                using (var cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM Queue WHERE DATE(CheckInTime) = CURDATE()", conn))
                {
                    label8.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                }

                using (var cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM Appointment WHERE DATE(AppointmentDateTime) = CURDATE() AND Status <> 'Cancelled'", conn))
                {
                    TodaysApp.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                }
            }
        }

        private void LoadUpNextPatient()
        {
            const string sql = @"
        SELECT q.QueueID, q.QueueNumber, p.FirstName, p.LastName, pl.LevelName
        FROM Queue q
        JOIN Patient p ON p.PatientID = q.PatientID
        JOIN PriorityLevel pl ON pl.PriorityID = q.PriorityID
        WHERE q.Status = 'Waiting' AND DATE(q.CheckInTime) = CURDATE()
        ORDER BY pl.LevelRank, q.CheckInTime
        LIMIT 1";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    _currentQueueId = reader.GetInt32(0);
                    int queueNumber = reader.GetInt32(1);
                    string firstName = reader.GetString(2);
                    string lastName = reader.GetString(3);
                    string priority = reader.GetString(4);

                    label10.Text = $"Up next \u00b7 queue no. {queueNumber:000}";
                    label13.Text = $"{firstName} {lastName}";
                    label14.Text = priority;
                    label14.ForeColor = priority == "Emergency" ? Color.Red
                                       : priority == "Urgent" ? Color.OrangeRed
                                       : Color.Black;

                    button1.Enabled = true;
                    btnSkip.Enabled = true;
                }
                else
                {
                    _currentQueueId = null;
                    label10.Text = "No patients waiting";
                    label13.Text = string.Empty;
                    label14.Text = string.Empty;

                    button1.Enabled = false;
                    btnSkip.Enabled = false;
                }
            }
        }

        private void LoadTodaysAppointments()
        {
            const string sql = @"
        SELECT a.AppointmentID, a.PatientID,
               TIME_FORMAT(a.AppointmentDateTime, '%H:%i') AS Time,
               CONCAT(p.FirstName, ' ', p.LastName) AS PatientName,
               a.ReasonForVisit AS Reason,
               a.Status
        FROM Appointment a
        JOIN Patient p ON p.PatientID = a.PatientID
        WHERE DATE(a.AppointmentDateTime) = CURDATE() AND a.Status <> 'Cancelled'
        ORDER BY a.AppointmentDateTime";

            var table = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            using (var adapter = new MySqlDataAdapter(sql, conn))
            {
                adapter.Fill(table);
            }

            time.DataPropertyName = "Time";
            Patient.DataPropertyName = "PatientName";
            Reason.DataPropertyName = "Reason";
            status.DataPropertyName = "Status";

            dataGridView1.DataSource = table;
        }

        private void btnSkip_Click_1(object sender, EventArgs e)
        {
            if (_currentQueueId == null) return;

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(
                "UPDATE Queue SET Status = 'Cancelled' WHERE QueueID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", _currentQueueId.Value);
                cmd.ExecuteNonQuery();
            }

            RefreshDashboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_currentQueueId == null) return;

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(
                "UPDATE Queue SET Status = 'In Consultation', DoctorID = @doctorId WHERE QueueID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@doctorId", Session.CurrentUser.StaffId);
                cmd.Parameters.AddWithValue("@id", _currentQueueId.Value);
                cmd.ExecuteNonQuery();
            }

            // TODO: needs DR_addRecord_from's real constructor — see note below
            DR_addRecord_from ar = new DR_addRecord_from(_currentQueueId.Value);
            ar.ShowDialog();

            RefreshDashboard();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            int appointmentId = Convert.ToInt32(row["AppointmentID"]);

            int queueId = GetOrCreateQueueEntryForAppointment(appointmentId);

            DR_addRecord_from ar = new DR_addRecord_from(queueId);
            ar.ShowDialog();

            RefreshDashboard();
        }

        private int GetOrCreateQueueEntryForAppointment(int appointmentId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                // Already checked in today? Reuse that Queue row instead of creating a duplicate.
                const string findSql = @"
            SELECT q.QueueID
            FROM Queue q
            JOIN Appointment a ON a.PatientID = q.PatientID
            WHERE a.AppointmentID = @appointmentId
              AND DATE(q.CheckInTime) = CURDATE()
              AND q.Status <> 'Cancelled'
            LIMIT 1";

                using (var findCmd = new MySqlCommand(findSql, conn))
                {
                    findCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    var existing = findCmd.ExecuteScalar();
                    if (existing != null)
                        return Convert.ToInt32(existing);
                }

                // Not checked in yet — pull the appointment's own details.
                int patientId, receptionistId;
                string reason;

                using (var apptCmd = new MySqlCommand(
                    "SELECT PatientID, ReceptionistID, ReasonForVisit FROM Appointment WHERE AppointmentID = @appointmentId", conn))
                {
                    apptCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    using (var reader = apptCmd.ExecuteReader())
                    {
                        reader.Read();
                        patientId = reader.GetInt32(0);
                        receptionistId = reader.GetInt32(1);
                        reason = reader.GetString(2);
                    }
                }

                // Next queue number for today — same rule used at reception check-in.
                int queueNumber;
                using (var numCmd = new MySqlCommand(
                    "SELECT COALESCE(MAX(QueueNumber), 0) + 1 FROM Queue WHERE DATE(CheckInTime) = CURDATE()", conn))
                {
                    queueNumber = Convert.ToInt32(numCmd.ExecuteScalar());
                }

                // Scheduled appointments carry no triage priority, so default to Routine.
                int priorityId;
                using (var prCmd = new MySqlCommand(
                    "SELECT PriorityID FROM PriorityLevel WHERE LevelName = 'Routine'", conn))
                {
                    priorityId = Convert.ToInt32(prCmd.ExecuteScalar());
                }

                const string insertSql = @"
            INSERT INTO Queue (QueueNumber, PatientID, PriorityID, ReceptionistID, ReasonForVisit, Status, DoctorID)
            VALUES (@queueNumber, @patientId, @priorityId, @receptionistId, @reason, 'In Consultation', @doctorId)";

                using (var insertCmd = new MySqlCommand(insertSql, conn))
                {
                    insertCmd.Parameters.AddWithValue("@queueNumber", queueNumber);
                    insertCmd.Parameters.AddWithValue("@patientId", patientId);
                    insertCmd.Parameters.AddWithValue("@priorityId", priorityId);
                    insertCmd.Parameters.AddWithValue("@receptionistId", receptionistId);
                    insertCmd.Parameters.AddWithValue("@reason", reason);
                    insertCmd.Parameters.AddWithValue("@doctorId", Session.CurrentUser.StaffId);
                    insertCmd.ExecuteNonQuery();
                    return (int)insertCmd.LastInsertedId;
                }
            }
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