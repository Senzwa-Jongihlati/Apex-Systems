using apex_management_sys.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace apex_management_sys
{
    public partial class newAccount : Form
    {
        private List<AccountRecord> accounts = new List<AccountRecord>();
        private List<AccountRecord> displayedAccounts = new List<AccountRecord>();
        private AccountRecord currentlyViewedAccount = null;

        public newAccount()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void newAccount_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            btnQueue.Visible = Session.CurrentUser.HasPermission(Permission.ManageQueue);
            btnDoctors.Visible = Session.CurrentUser.HasPermission(Permission.AddConsultationNote);
            btnAppointments.Visible = Session.CurrentUser.HasPermission(Permission.BookAppointment);
            btnPatients.Visible = Session.CurrentUser.HasPermission(Permission.ViewPatientRecords);
            btnEmployees.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
            btnDashboard.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
            Main.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);

            btnEmployees.Enabled = false;


        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string experience = txtExperience.Text.Trim();
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastname.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string role = cbRole.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password are required.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an account Type.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isDoctor = role.Equals("Doctor", StringComparison.OrdinalIgnoreCase);
            string table = isDoctor ? "doctor" : "receptionist";
            string storedRole = isDoctor ? "Doctor" : "Receptionist";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                using (MySqlTransaction tx = conn.BeginTransaction())
                {
                    string insertAccount = $@"INSERT INTO {table} 
                        (Username, Password, FirstName, LastName, ContactNumber, Experience, Role, Address, CreatedOn)
                        VALUES (@Username, @Password, @FirstName, @LastName, @ContactNumber, @Experience, @Role, @Address, @CreatedOn)";

                    using (MySqlCommand cmd = new MySqlCommand(insertAccount, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@FirstName", firstname);
                        cmd.Parameters.AddWithValue("@LastName", lastname);
                        cmd.Parameters.AddWithValue("@ContactNumber", phone);
                        cmd.Parameters.AddWithValue("@Experience", string.IsNullOrEmpty(experience) ? (object)DBNull.Value : experience);
                        cmd.Parameters.AddWithValue("@Role", storedRole);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                }

                MessageBox.Show("Account created successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccounts();
                ClearCreateAccountForm();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating account: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAccounts()
        {
            accounts.Clear();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"
                    SELECT DoctorID AS AccountID, Username, FirstName, LastName, ContactNumber, Experience, Role, Address, DateHired FROM doctor
                    UNION ALL
                    SELECT ReceptionistID AS AccountID, Username, FirstName, LastName, ContactNumber, Experience, Role, Address, DateHired FROM receptionist";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accounts.Add(new AccountRecord
                        {
                            AccountId = reader.GetInt32("AccountID"),
                            Username = reader.GetString("Username"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                            Phone = reader.IsDBNull(reader.GetOrdinal("ContactNumber")) ? "" : reader.GetString("ContactNumber"),
                            Experience = reader.IsDBNull(reader.GetOrdinal("Experience")) ? "" : reader.GetString("Experience"),
                            Role = reader.GetString("Role"),
                            Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? "" : reader.GetString("Address"),
                            CreatedOn = reader.GetDateTime("DateHired")
                        });
                    }
                }
            }

            txtSearchAccount.Clear();
            RefreshAccountList(accounts);
        }

        private void RefreshAccountList(List<AccountRecord> source)
        {
            displayedAccounts = source;
            lstAccounts.Items.Clear();
            foreach (var acc in displayedAccounts)
            {
                lstAccounts.Items.Add($"{acc.FirstName} {acc.LastName} - {acc.Role}");
            }
        }

        private void txtSearchAccount_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearchAccount.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filter))
            {
                RefreshAccountList(accounts);
                return;
            }

            var filtered = accounts.Where(a =>
                (a.FirstName + " " + a.LastName).ToLower().Contains(filter) ||
                (a.Phone ?? "").ToLower().Contains(filter)
            ).ToList();

            RefreshAccountList(filtered);
        }

        private void btnSearchAcc_Click(object sender, EventArgs e)
        {
            string filter = txtSearchAccount.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filter))
            {
                RefreshAccountList(accounts);
                return;
            }

            var filtered = accounts.Where(a =>
                (a.FirstName + " " + a.LastName).ToLower().Contains(filter) ||
                (a.Phone ?? "").ToLower().Contains(filter)
            ).ToList();

            RefreshAccountList(filtered);

            if (filtered.Count == 0)
            {
                MessageBox.Show("No matching accounts found.", "Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearCreateAccountForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtExperience.Clear();
            txtFirstName.Clear();
            txtLastname.Clear();
            txtPhone.Clear();
            cbRole.SelectedIndex = -1;
            txtAddress.Clear();
        }

        // View button — loads the selected list item into the View Account panel
        private void button1_Click(object sender, EventArgs e)
        {
            int index = lstAccounts.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Please select an account from the list first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (index >= displayedAccounts.Count)
            {
                MessageBox.Show("Selected account could not be found — try refreshing the list.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var acc = displayedAccounts[index];
            currentlyViewedAccount = acc;

            txtViewAccountId.Text = acc.AccountId.ToString();
            txtViewUsername.Text = acc.Username;
            txtViewLastName.Text = acc.LastName;
            txtViewFirstName.Text = acc.FirstName;
            txtViewExperience.Text = acc.Experience;
            txtViewPhone.Text = acc.Phone;
            txtViewType.Text = acc.Role;
            txtViewAddress.Text = acc.Address;
            txtViewCreatedOn.Text = acc.CreatedOn.ToString("yyyy-MM-dd");
        }

        // ----- Save -----

        private bool ValidateViewForm()
        {
            if (string.IsNullOrWhiteSpace(txtViewFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtViewLastName.Text) ||
                string.IsNullOrWhiteSpace(txtViewUsername.Text))
            {
                MessageBox.Show("First Name, Last Name, and Username are required.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private int SaveViewedAccountChanges()
        {
            // Role is NOT editable here — moving someone between Doctor/Receptionist
            // means moving their row to a different table, which this doesn't handle.
            bool isDoctor = currentlyViewedAccount.Role.Equals("Doctor", StringComparison.OrdinalIgnoreCase);
            string table = isDoctor ? "doctor" : "receptionist";
            string idColumn = isDoctor ? "DoctorID" : "ReceptionistID";

            string experience = txtViewExperience.Text.Trim();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string updateQuery = $@"UPDATE {table} SET
                    FirstName = @FirstName,
                    LastName = @LastName,
                    Username = @Username,
                    ContactNumber = @ContactNumber,
                    Experience = @Experience,
                    Address = @Address
                    WHERE {idColumn} = @AccountId";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", txtViewFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtViewLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Username", txtViewUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNumber", txtViewPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Experience", string.IsNullOrEmpty(experience) ? (object)DBNull.Value : experience);
                    cmd.Parameters.AddWithValue("@Address", txtViewAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@AccountId", currentlyViewedAccount.AccountId);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentlyViewedAccount == null)
            {
                MessageBox.Show("View an account first before saving changes.", "No Account Loaded",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateViewForm())
                return;

            try
            {
                int rowsAffected = SaveViewedAccountChanges();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("No account was updated — it may have been deleted by someone else.",
                        "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Account updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAccounts();
                currentlyViewedAccount = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating account: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----- Delete -----

        private int DeleteViewedAccount()
        {
            bool isDoctor = currentlyViewedAccount.Role.Equals("Doctor", StringComparison.OrdinalIgnoreCase);
            string table = isDoctor ? "doctor" : "receptionist";
            string idColumn = isDoctor ? "DoctorID" : "ReceptionistID";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string deleteQuery = $"DELETE FROM {table} WHERE {idColumn} = @AccountId";

                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", currentlyViewedAccount.AccountId);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        private void ClearViewPanel()
        {
            txtViewAccountId.Clear();
            txtViewUsername.Clear();
            txtViewLastName.Clear();
            txtViewFirstName.Clear();
            txtViewExperience.Clear();
            txtViewPhone.Clear();
            txtViewType.Clear();
            txtViewAddress.Clear();
            txtViewCreatedOn.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentlyViewedAccount == null)
            {
                MessageBox.Show("View an account first before deleting it.", "No Account Loaded",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete {currentlyViewedAccount.FirstName} {currentlyViewedAccount.LastName}'s account?\n\nThis cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                int rowsAffected = DeleteViewedAccount();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("No account was deleted — it may have already been removed.",
                        "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Account deleted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearViewPanel();
                currentlyViewedAccount = null;
                LoadAccounts();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting account: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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