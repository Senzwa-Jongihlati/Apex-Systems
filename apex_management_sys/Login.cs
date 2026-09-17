using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace apex_management_sys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = ktxtUsername.Text.Trim();
            string password = ktxtPassword.Text;


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            //open the connection
            MySqlConnection conn = DatabaseHelper.GetConnection();

            //ask the database for this user's stored info
            string query = "SELECT PasswordHash, IsActive FROM Receptionist WHERE Username = @Username";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);

            MySqlDataReader reader = cmd.ExecuteReader();

            //check what came back
            bool loginSuccess = false;

            if (reader.Read())
            {
                string storedHash = reader.GetString("PasswordHash");
                bool isActive = reader.GetBoolean("IsActive");
                // BCrypt.Verify re-hashes the entered password using the salt stored inside storedHash, then compares the result — it never decrypts the stored hash
                if (isActive && BCrypt.Net.BCrypt.Verify(password, storedHash))
                {
                    loginSuccess = true;
                }
            }

            //close the connection now that we're done with it
            reader.Close();
            conn.Close();



            if (loginSuccess)
            {
                home h = new home();
                h.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Incorrect username or password");


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
    }

}
