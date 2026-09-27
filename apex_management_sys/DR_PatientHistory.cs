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
    public partial class DR_PatientHistory : Form
    {
        private int _patientId;

        // Opened mid-consultation (from DR_addRecord_from) — has an active queue entry.
        public DR_PatientHistory(int queueId)
        {
            InitializeComponent();
            ConfigureGrid();
            LoadPatientHeaderFromQueue(queueId);
            LoadPatientHistory();
        }

        // Opened from a general patient search — no active queue entry.
        public DR_PatientHistory(int patientId, bool isPatientId)
        {
            InitializeComponent();
            ConfigureGrid();
            _patientId = patientId;
            LoadPatientHeaderFromPatient(patientId);
            LoadPatientHistory();
        }

        private void ConfigureGrid()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnClose.Click += btnClose_Click;
        }

        private void LoadPatientHeaderFromQueue(int queueId)
        {
            const string sql = @"
                SELECT q.QueueNumber, p.PatientID, p.FirstName, p.LastName, pl.LevelName
                FROM Queue q
                JOIN Patient p ON p.PatientID = q.PatientID
                JOIN PriorityLevel pl ON pl.PriorityID = q.PriorityID
                WHERE q.QueueID = @queueId";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@queueId", queueId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return;

                    int queueNumber = reader.GetInt32(0);
                    _patientId = reader.GetInt32(1);
                    string firstName = reader.GetString(2);
                    string lastName = reader.GetString(3);
                    string priority = reader.GetString(4);

                    label2.Text = $"{firstName} {lastName}";
                    label1.Text = $"Patient no. {_patientId} \u00b7 queue no. {queueNumber:000}";
                    label3.Text = priority;
                    label3.Visible = true;
                    label3.ForeColor = priority == "Emergency" ? Color.Red
                                      : priority == "Urgent" ? Color.OrangeRed
                                      : Color.Black;
                }
            }
        }

        private void LoadPatientHeaderFromPatient(int patientId)
        {
            const string sql = "SELECT FirstName, LastName FROM Patient WHERE PatientID = @patientId";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@patientId", patientId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return;

                    string firstName = reader.GetString(0);
                    string lastName = reader.GetString(1);

                    label2.Text = $"{firstName} {lastName}";
                    label1.Text = $"Patient no. {patientId}";
                    label3.Visible = false; // no active queue/priority to show here
                }
            }
        }

        private void LoadPatientHistory()
        {
            const string sql = @"
                SELECT cn.CreatedTime AS VisitDate, cn.Diagnosis, cn.Prescription, cn.Notes,
                       CONCAT(d.FirstName, ' ', d.LastName) AS Doctor
                FROM ConsultationNote cn
                JOIN Queue q ON q.QueueID = cn.QueueID
                JOIN Doctor d ON d.DoctorID = cn.DoctorID
                WHERE q.PatientID = @patientId
                ORDER BY cn.CreatedTime DESC";

            var table = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            using (var adapter = new MySqlDataAdapter(sql, conn))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@patientId", _patientId);
                adapter.Fill(table);
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = table;

            if (dataGridView1.Columns["VisitDate"] != null)
            {
                dataGridView1.Columns["VisitDate"].HeaderText = "Date";
                dataGridView1.Columns["VisitDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            }
            if (dataGridView1.Columns["Prescription"] != null) dataGridView1.Columns["Prescription"].Visible = false;
            if (dataGridView1.Columns["Notes"] != null) dataGridView1.Columns["Notes"].Visible = false;

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows[0].Selected = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 ||
                !(dataGridView1.SelectedRows[0].DataBoundItem is DataRowView row))
            {
                txtPrescriptions.Text = string.Empty;
                txtNotes.Text = string.Empty;
                return;
            }

            txtPrescriptions.Text = row["Prescription"]?.ToString() ?? string.Empty;
            txtNotes.Text = row["Notes"]?.ToString() ?? string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}