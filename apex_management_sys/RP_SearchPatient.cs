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

        private void button4_Click(object sender, EventArgs e)
        {
            RP_Queue Queue = new RP_Queue();
            Queue.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RP_SearchPatient sp = new RP_SearchPatient();
            sp.Show();
            this.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
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
            Main.Left = (this.ClientSize.Width - Section.Width) / 2;
            Main.Top = (this.ClientSize.Height - Section.Height) / 2;
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

        private void btndPatient_Click(object sender, EventArgs e)
        {
            RP_SearchPatient sp = new RP_SearchPatient();
            sp.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Close();
        }

        private void Queue_Click(object sender, EventArgs e)
        {
            RP_Queue Q = new RP_Queue();
            Q.Show();
            this.Close();
        }

        private void Admissions_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            R.Show();
            this.Close();
        }

        private void RP_SearchPatient_Load(object sender, EventArgs e)
        {

            BeginInvoke(new Action(() =>
            {
                LoadPatients();
                CenterPanel();
            }));
        }

        private void Appointments_Click(object sender, EventArgs e)
        {
            Appointment ap = new Appointment();
            ap.Show();
            this.Close();
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            DR_Doctor drd = new DR_Doctor();
            drd.Show();
            this.Close();
        }
    }
}
