using ApexSystems;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace apex_management_sys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterLoginPanel();
        }
        private void CenterLoginPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
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

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            Receptionist receptionist = null;

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM Receptionist WHERE Username = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            receptionist = new Receptionist(
                                reader.GetInt32("ReceptionistID"),
                                reader.GetString("FirstName"),
                                reader.GetString("LastName"),
                                reader.GetString("Username"),
                                reader.GetString("PasswordHash"),
                                reader["ContactNumber"] as string,   // null if the column is NULL
                                reader["Email"] as string,
                                reader.GetDateTime("DateHired"),
                                reader.GetBoolean("IsActive"));
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Could not reach the database. Please try again.");
                return;
            }

            if (receptionist != null && receptionist.VerifyPassword(password))
            {
                Session.Login(receptionist);
                RP_Queue Q = new RP_Queue();// pass the logged-in receptionist along
                Q.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Incorrect username or password");
        }
    }

}
