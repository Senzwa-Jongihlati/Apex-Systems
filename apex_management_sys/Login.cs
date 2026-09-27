using ApexSystems;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace apex_management_sys
{
    public partial class Login : Form
    {
        public static Login Instance { get; private set; }
        public Login()
        {
            InitializeComponent();
            Instance = this;
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

            var user = AuthService.Authenticate(txtUsername.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }
            txtUsername.Clear();
            txtPassword.Clear();
            checkBox1.Checked = false;
            Session.Login(user);

            switch (user.Role)
            {
                case UserRole.Receptionist: new RP_Queue().Show(); break;
                case UserRole.Doctor: new DR_Doctor().Show(); break;
                case UserRole.Admin: new home().Show(); break;
            }

            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

            }
        }
    }

}
