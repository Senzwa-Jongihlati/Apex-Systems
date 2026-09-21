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
    public partial class RP_Queue : Form
    {
        public RP_Queue()
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome To The Queue {Session.CurrentReceptionist.GetFullName()}";
        }
        private void LoadWaitingPatients()
        {
            string query = @"
            SELECT
                q.QueueNumber AS 'Queue Number',
                CONCAT(p.FirstName, ' ', p.LastName) AS 'Patient Name',
                TIMESTAMPDIFF(YEAR, p.DateOfBirth, CURDATE()) AS Age,
                q.CheckInTime AS 'Arrival Time',
                pl.LevelName AS Priority,
                q.ReasonForVisit AS 'Reason for Visit'
            FROM Queue q
            INNER JOIN Patient p
                ON q.PatientID = p.PatientID
            INNER JOIN PriorityLevel pl
                ON q.PriorityID = pl.PriorityID
            WHERE DATE(q.CheckInTime) = CURDATE()
              AND q.Status = 'Waiting'
            ORDER BY
                pl.LevelRank ASC,
                q.CheckInTime ASC;";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable table = new DataTable();

                adapter.Fill(table);

                WaitingGrid.DataSource = table;
            }
            WaitingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WaitingGrid.ClearSelection();
            WaitingGrid.CurrentCell = null;
            WaitingGrid.ColumnHeadersDefaultCellStyle.Font = new Font(
                WaitingGrid.Font,
                FontStyle.Bold
             );
            foreach (DataGridViewColumn column in WaitingGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void LoadServedPatients()
        {
            string query = @"
            SELECT
                q.QueueNumber AS 'Queue Number',
                CONCAT(p.FirstName, ' ', p.LastName) AS 'Patient Name',
                TIMESTAMPDIFF(YEAR, p.DateOfBirth, CURDATE()) AS Age,
                q.CheckInTime AS 'Arrival Time',
                pl.LevelName AS Priority,
                q.ReasonForVisit AS 'Reason for Visit'
            FROM Queue q
            INNER JOIN Patient p
                ON q.PatientID = p.PatientID
            INNER JOIN PriorityLevel pl
                ON q.PriorityID = pl.PriorityID
            WHERE DATE(q.CheckInTime) = CURDATE()
                AND q.Status = 'Completed'
            ORDER BY
                pl.LevelRank ASC,
                q.CheckInTime ASC;";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable table = new DataTable();

                adapter.Fill(table);

                ServedGrid.DataSource = table;
            }

            ServedGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ServedGrid.ClearSelection();
            ServedGrid.CurrentCell = null;

            ServedGrid.ColumnHeadersDefaultCellStyle.Font = new Font(
                ServedGrid.Font,
                FontStyle.Bold
            );

            foreach (DataGridViewColumn column in ServedGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration Regst = new Registration();
            Regst.Show();
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

        private void Admissions_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            R.Show();
            this.Close();
        }

        private void Patients_Click(object sender, EventArgs e)
        {
            RP_SearchPatient sp = new RP_SearchPatient();
            sp.Show();
            this.Close();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Close();
        }

        private void RP_Queue_Load(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                LoadWaitingPatients();
                LoadServedPatients();
            }));
        }

        private void MainSection_Click(object sender, EventArgs e)
        {
            WaitingGrid.ClearSelection();
            WaitingGrid.CurrentCell = null;

            ServedGrid.ClearSelection();
            ServedGrid.CurrentCell = null;
        }
    }
}
