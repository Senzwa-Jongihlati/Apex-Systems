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
            }));
        }
    }
}
