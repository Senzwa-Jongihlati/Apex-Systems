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
                        (Username, Password, FirstName, LastName, Phone, Experience, Role, Address, CreatedOn)
                        VALUES (@Username, @Password, @FirstName, @LastName, @Phone, @Experience, @Role, @Address, @CreatedOn)";

                    using (MySqlCommand cmd = new MySqlCommand(insertAccount, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@FirstName", firstname);
                        cmd.Parameters.AddWithValue("@LastName", lastname);
                        cmd.Parameters.AddWithValue("@Phone", phone);
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
                    SELECT DoctorID AS AccountID, Username, FirstName, LastName, Phone, Experience, Role, Address, CreatedOn FROM doctor
                    UNION ALL
                    SELECT ReceptionistID AS AccountID, Username, FirstName, LastName, Phone, Experience, Role, Address, CreatedOn FROM receptionist";

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
                            Phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? "" : reader.GetString("Phone"),
                            Experience = reader.IsDBNull(reader.GetOrdinal("Experience")) ? "" : reader.GetString("Experience"),
                            Role = reader.GetString("Role"),
                            Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? "" : reader.GetString("Address"),
                            CreatedOn = reader.GetDateTime("CreatedOn")
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

        private void button1_Click(object sender, EventArgs e)
        {
            int index = lstAccounts.SelectedIndex;


            // txtViewAccountId.Text = acc.AccountId.ToString();

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
                   Phone = @Phone,
                   Experience = @Experience,
                   Address = @Address
                    WHERE {idColumn} = @AccountId";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", txtViewFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtViewLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Username", txtViewUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtViewPhone.Text.Trim());
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
                    MessageBox.Show("No account was updated.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Account updated successfully!", "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadAccounts();
                currentlyViewedAccount = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating account: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}