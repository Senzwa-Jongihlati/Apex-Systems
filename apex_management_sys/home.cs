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
    public partial class home : Form
    {
        private Login login;

        private System.Windows.Forms.Timer dashboardRefreshTimer;

        public home()
        {
            InitializeComponent();
            SetupDashboard();
        }

        public home(Login loginform)
        {
            InitializeComponent();
            login = loginform;
            SetupDashboard();
        }

        private void SetupDashboard()
        {
            this.Load += Home_Load;
            this.FormClosing += Home_FormClosing;

            dashboardRefreshTimer = new System.Windows.Forms.Timer();
            dashboardRefreshTimer.Interval = 15000; // 15 seconds
            dashboardRefreshTimer.Tick += (s, e) => LoadDashboardData();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Header.Text = "Welcome Back";

            RecentAppointmentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            QueueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RecentPatientGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadDashboardData();
            dashboardRefreshTimer.Start();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            dashboardRefreshTimer.Stop();
            dashboardRefreshTimer.Dispose();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    LoadStatCounters(conn);
                    LoadRecentAppointments(conn);
                    LoadRecentPatients(conn);
                    LoadCurrentQueue(conn);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Dashboard refresh failed: " + ex.Message);
            }
        }

        private void LoadStatCounters(MySqlConnection conn)
        {
            // Today's Appointments
            using (MySqlCommand cmd = new MySqlCommand(
                "SELECT COUNT(*) FROM appointment WHERE DATE(AppointmentDateTime) = CURDATE()", conn))
            {
                TodaysApp.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
            }

            // Total Number of Doctors
            using (MySqlCommand cmd = new MySqlCommand(
                "SELECT COUNT(*) FROM doctor", conn))
            {
                DoctorsToday.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
            }

            // Patients in Queue (waiting today, not yet completed)
            using (MySqlCommand cmd = new MySqlCommand(
                @"SELECT COUNT(*) FROM queue 
                  WHERE Status = 'Waiting' AND DATE(CheckInTime) = CURDATE()", conn))
            {
                PatientsInQueue.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
            }

            // Total Patients
            using (MySqlCommand cmd = new MySqlCommand(
                "SELECT COUNT(*) FROM patient", conn))
            {
                TotalP.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
            }
        }

        private void LoadRecentAppointments(MySqlConnection conn)
        {
            string query = @"
                SELECT 
                    CONCAT(p.FirstName, ' ', p.LastName) AS Patient,
                    CONCAT(d.FirstName, ' ', d.LastName) AS Doctor,
                    a.AppointmentDateTime AS 'Date/Time',
                    a.Status
                FROM appointment a
                INNER JOIN patient p ON a.PatientID = p.PatientID
                INNER JOIN doctor d ON a.DoctorID = d.DoctorID
                ORDER BY a.AppointmentDateTime DESC
                LIMIT 5";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                RecentAppointmentGrid.Columns.Clear();
                RecentAppointmentGrid.AutoGenerateColumns = true;
                RecentAppointmentGrid.DataSource = table;
            }
        }

        private void LoadRecentPatients(MySqlConnection conn)
        {
            string query = @"
                SELECT 
                    CONCAT(FirstName, ' ', LastName) AS Name,
                    RegisteredDate AS 'Date Registered'
                FROM patient
                ORDER BY RegisteredDate DESC
                LIMIT 5";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                RecentPatientGrid.Columns.Clear();
                RecentPatientGrid.AutoGenerateColumns = true;
                RecentPatientGrid.DataSource = table;
            }
        }

        private void LoadCurrentQueue(MySqlConnection conn)
        {

            string query = @"
                SELECT 
                    q.QueueNumber AS '#',
                    CONCAT(p.FirstName, ' ', p.LastName) AS Patient,
                    COALESCE(CONCAT(d.FirstName, ' ', d.LastName), 'Not yet assigned') AS Doctor,
                    TIMEDIFF(NOW(), q.CheckInTime) AS 'Waiting Time'
                FROM queue q
                INNER JOIN patient p ON q.PatientID = p.PatientID
                LEFT JOIN consultationnote cn ON cn.QueueID = q.QueueID
                LEFT JOIN doctor d ON d.DoctorID = cn.DoctorID
                WHERE q.Status = 'Waiting' AND DATE(q.CheckInTime) = CURDATE()
                ORDER BY q.QueueNumber ASC";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                QueueGrid.Columns.Clear();
                QueueGrid.AutoGenerateColumns = true;
                QueueGrid.DataSource = table;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Queue_Click(object sender, EventArgs e)
        {
            RP_Queue Q = new RP_Queue();
            Q.Show();
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            Login.Instance.Show();
            this.Close();
        }

        private void Appointments_Click(object sender, EventArgs e)
        {
            Appointment ap = new Appointment();
            ap.Show();
            this.Close();
        }

        private void home_Load(object sender, EventArgs e)
        {
            btnQueue.Visible = Session.CurrentUser.HasPermission(Permission.ManageQueue);
            btnDoctors.Visible = Session.CurrentUser.HasPermission(Permission.AddConsultationNote);
            btnAppointments.Visible = Session.CurrentUser.HasPermission(Permission.BookAppointment);
            btnPatients.Visible = Session.CurrentUser.HasPermission(Permission.ViewPatientRecords);
            btnEmployees.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
            btnDashboard.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
            Main.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);

            btnDashboard.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}