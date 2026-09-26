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
    public partial class RP_SearchPatient : Form
    {
        public RP_SearchPatient()
        {
            InitializeComponent();
        }
        public RP_SearchPatient(Boolean T)
        {
            InitializeComponent();
            if (T)
                LoadPatients();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void LoadPatients(string searchTerm = "")
        {
            string query = @"
        SELECT 
            PatientID AS 'ID',
            CONCAT(FirstName, ' ', LastName) AS 'Name',
            IdentificationType AS 'ID Type',
            IdentificationNumber AS 'ID / Passport',
            ContactNumber AS 'Contact',
            EmergencyContact AS 'Emergency',
            RegisteredDate AS 'Date Added'
        FROM Patient
        WHERE (@Search = '' 
               OR IdentificationNumber LIKE CONCAT('%', @Search, '%')
               OR CONCAT(FirstName, ' ', LastName) LIKE CONCAT('%', @Search, '%'))
        ORDER BY RegisteredDate DESC";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Search", searchTerm.Trim());

                DataTable table = new DataTable();
                adapter.Fill(table);

                PatientGrid.DataSource = table;

                lblCount.Text = $"({table.Rows.Count} total)";
            }

            StyleGrid(PatientGrid);
        }
        public void CenterPanel()
        {
            MainPanel.Left = (this.ClientSize.Width - Section.Width) / 2;
            MainPanel.Top = (this.ClientSize.Height - Section.Height) / 2;
        }
        private void Patients_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPatients(txtSearch.Text);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadPatients();
        }
        private void StyleGrid(DataGridView grid)
        {
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.ReadOnly = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(222, 235, 245);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(180, 205, 225);
            grid.ColumnHeadersHeight = 32;

            foreach (DataGridViewColumn column in grid.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            grid.ClearSelection();
            grid.CurrentCell = null;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            //Registration Regst = new Registration();
            //Regst.Show();
            using (Registration reg = new Registration())
            {
                if (reg.ShowDialog(this) == DialogResult.OK)
                {
                    LoadPatients(); // refresh the grid immediately, same form, no navigation
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RP_SearchPatient_Load(object sender, EventArgs e)
        {
            btnQueue.Visible = Session.CurrentUser.HasPermission(Permission.ManageQueue);
            btnDoctors.Visible = Session.CurrentUser.HasPermission(Permission.AddConsultationNote);
            btnAppointments.Visible = Session.CurrentUser.HasPermission(Permission.BookAppointment);
            btnPatients.Visible = Session.CurrentUser.HasPermission(Permission.ViewPatientRecords);
            btnEmployees.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
            btnDashboard.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
            Main.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);

            btnPatients.Enabled = false;
            BeginInvoke(new Action(() =>
            {
                LoadPatients();
                CenterPanel();
            }));
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
