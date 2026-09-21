using ApexSystems;
using MySql.Data.MySqlClient;

namespace apex_management_sys
{
    internal sealed class CredentialChangeForm : Form
    {
        private readonly Receptionist receptionist;
        private readonly bool passwordExpired;
        private readonly TextBox txtCurrentPassword = new();
        private readonly TextBox txtUsername = new();
        private readonly TextBox txtNewPassword = new();
        private readonly TextBox txtConfirmPassword = new();

        public CredentialChangeForm(Receptionist receptionist, bool passwordExpired)
        {
            this.receptionist = receptionist;
            this.passwordExpired = passwordExpired;

            Text = "Change Receptionist Login";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(470, 455);
            BackColor = Color.White;
            Font = new Font("Segoe UI", 10F);

            BuildInterface();
        }

        private void BuildInterface()
        {
            Label title = new()
            {
                Text = passwordExpired ? "Password change required" : "Change login details",
                AutoSize = true,
                Font = new Font("Segoe UI", 19F, FontStyle.Bold),
                ForeColor = Color.FromArgb(8, 63, 85),
                Location = new Point(30, 24)
            };

            Label message = new()
            {
                Text = passwordExpired
                    ? "Your password is three months old. Create a new password to continue."
                    : "Update the receptionist username and password.",
                AutoSize = false,
                Size = new Size(405, 45),
                ForeColor = Color.DimGray,
                Location = new Point(33, 68)
            };

            Controls.Add(title);
            Controls.Add(message);

            int y = 125;
            AddField("Current password", txtCurrentPassword, ref y, true);
            AddField("Username", txtUsername, ref y, false);
            AddField("New password", txtNewPassword, ref y, true);
            AddField("Confirm new password", txtConfirmPassword, ref y, true);
            txtUsername.Text = receptionist.Username;

            Button save = new()
            {
                Text = "Save login details",
                Location = new Point(33, 385),
                Size = new Size(180, 42),
                BackColor = Color.FromArgb(8, 63, 85),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            save.FlatAppearance.BorderSize = 0;
            save.Click += Save_Click;

            Button cancel = new()
            {
                Text = passwordExpired ? "Exit" : "Cancel",
                Location = new Point(225, 385),
                Size = new Size(110, 42),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                DialogResult = DialogResult.Cancel
            };
            cancel.FlatAppearance.BorderSize = 0;

            Controls.Add(save);
            Controls.Add(cancel);
            AcceptButton = save;
            CancelButton = cancel;
        }

        private void AddField(string labelText, TextBox textBox, ref int y, bool password)
        {
            Label label = new()
            {
                Text = labelText,
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Location = new Point(33, y)
            };
            textBox.Location = new Point(33, y + 24);
            textBox.Size = new Size(395, 30);
            textBox.UseSystemPasswordChar = password;
            Controls.Add(label);
            Controls.Add(textBox);
            y += 64;
        }

        private void Save_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;

            if (!receptionist.VerifyPassword(currentPassword))
            {
                MessageBox.Show("The current password is incorrect.", "Password Not Changed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Length < 4)
            {
                MessageBox.Show("The username must contain at least 4 characters.",
                    "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 8 ||
                !newPassword.Any(char.IsUpper) ||
                !newPassword.Any(char.IsLower) ||
                !newPassword.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "The new password must have at least 8 characters, including uppercase, lowercase and a number.",
                    "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != txtConfirmPassword.Text)
            {
                MessageBox.Show("The new passwords do not match.", "Password Not Changed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BCrypt.Net.BCrypt.Verify(newPassword, receptionist.PasswordHash))
            {
                MessageBox.Show("Choose a password different from the current password.",
                    "Password Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            try
            {
                using MySqlConnection conn = DatabaseHelper.GetConnection();
                const string sql = @"
                    UPDATE Receptionist
                    SET Username = @Username,
                        PasswordHash = @PasswordHash,
                        PasswordChangedAt = CURRENT_TIMESTAMP
                    WHERE ReceptionistID = @ReceptionistID";

                using MySqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", newHash);
                cmd.Parameters.AddWithValue("@ReceptionistID", receptionist.ReceptionistID);
                cmd.ExecuteNonQuery();

                receptionist.Username = username;
                receptionist.PasswordHash = newHash;
                receptionist.PasswordChangedAt = DateTime.Now;

                MessageBox.Show("Your login details were changed successfully.",
                    "Login Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("That username is already being used.", "Username Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("The login details could not be changed.\n\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
