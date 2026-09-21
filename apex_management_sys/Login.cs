using ApexSystems;
using MySql.Data.MySqlClient;

namespace apex_management_sys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterLoginPanel();
            PrepareDatabase();
        }

        private void CenterLoginPanel()
        {
            panel1.Left = (ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (ClientSize.Height - panel1.Height) / 2;
        }

        private void PrepareDatabase()
        {
            try
            {
                DatabaseMigration.EnsureLatestSchema();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "The application could not prepare the login account.\n\n" +
                    ex.Message,
                    "Database Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while preparing the login account.\n\n" +
                    ex.Message,
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to exit Apex?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Receptionist receptionist = null;

            try
            {
                using MySqlConnection conn =
                    DatabaseHelper.GetConnection();

                const string query =
                    @"SELECT *
                      FROM Receptionist
                      WHERE Username = @Username
                      AND IsActive = 1";

                using MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@Username",
                    username);

                using MySqlDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    receptionist = new Receptionist(
                        reader.GetInt32("ReceptionistID"),
                        reader.GetString("FirstName"),
                        reader.GetString("LastName"),
                        reader.GetString("Username"),
                        reader.GetString("UserRole"),
                        reader.GetString("PasswordHash"),

                        reader["ContactNumber"] == DBNull.Value
                            ? null
                            : reader.GetString("ContactNumber"),

                        reader["Email"] == DBNull.Value
                            ? null
                            : reader.GetString("Email"),

                        reader.GetDateTime("DateHired"),
                        reader.GetBoolean("IsActive"),
                        reader.GetDateTime("PasswordChangedAt"));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Could not connect to the database.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred.\n\n" +
                    ex.Message,
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            bool passwordIsCorrect = false;

            if (receptionist != null)
            {
                try
                {
                    passwordIsCorrect =
                        receptionist.VerifyPassword(password);
                }
                catch (Exception)
                {
                    passwordIsCorrect = false;
                }
            }

            if (receptionist != null && passwordIsCorrect)
            {
                if (receptionist.PasswordHasExpired())
                {
                    using CredentialChangeForm changeForm =
                        new CredentialChangeForm(receptionist, true);

                    if (changeForm.ShowDialog(this) != DialogResult.OK)
                    {
                        MessageBox.Show(
                            "You must change the expired password before entering the system.",
                            "Password Change Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }

                Session.Login(receptionist);

                MessageBox.Show(
                    "Login successful. Welcome to Apex.",
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Form nextForm = receptionist.IsAdministrator()
                    ? new home()
                    : new RP_Reception();
                nextForm.Show();

                Hide();
            }
            else
            {
                MessageBox.Show(
                    "Incorrect username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
