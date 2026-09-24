namespace apex_management_sys
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            Password = new Panel();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            Username = new Panel();
            txtUsername = new Krypton.Toolkit.KryptonTextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            Background = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Background).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(button1);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(71, 77);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 611);
            panel1.TabIndex = 0;
            // 
            // Password
            // 
            Password.Controls.Add(txtPassword);
            Password.Controls.Add(pictureBox2);
            Password.Controls.Add(checkBox1);
            Password.Location = new Point(56, 316);
            Password.Margin = new Padding(4, 4, 4, 4);
            Password.Name = "Password";
            Password.Size = new Size(470, 68);
            Password.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.CueHint.CueHintText = "Enter Password";
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(29, 0);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.MaxLength = 250;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(441, 31);
            txtPassword.TabIndex = 15;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Bottom;
            checkBox1.Location = new Point(0, 39);
            checkBox1.Margin = new Padding(4, 4, 4, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(470, 29);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Username
            // 
            Username.Controls.Add(txtUsername);
            Username.Controls.Add(pictureBox1);
            Username.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(56, 185);
            Username.Margin = new Padding(4, 4, 4, 4);
            Username.Name = "Username";
            Username.Size = new Size(470, 38);
            Username.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.CueHint.CueHintText = "Enter Username";
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Location = new Point(28, 0);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.MaxLength = 250;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(442, 31);
            txtUsername.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(56, 438);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(470, 60);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Background
            // 
            Background.Dock = DockStyle.Fill;
            Background.Image = Properties.Resources.Screenshot_2026_09_17_132434;
            Background.Location = new Point(0, 0);
            Background.Margin = new Padding(4, 4, 4, 4);
            Background.Name = "Background";
            Background.Size = new Size(1283, 699);
            Background.SizeMode = PictureBoxSizeMode.StretchImage;
            Background.TabIndex = 1;
            Background.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(47, 28);
            label1.Name = "label1";
            label1.Size = new Size(327, 60);
            label1.TabIndex = 14;
            label1.Text = "Welcome Back";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(56, 114);
            label2.Name = "label2";
            label2.Size = new Size(243, 30);
            label2.TabIndex = 15;
            label2.Text = "Sign in to Apex Systems";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(207, 537);
            label3.Name = "label3";
            label3.Size = new Size(167, 50);
            label3.TabIndex = 2;
            label3.Text = "2026 Apex Systems\r\nVersion 1.0\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1283, 699);
            Controls.Add(panel1);
            Controls.Add(Background);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Password.ResumeLayout(false);
            Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Username.ResumeLayout(false);
            Username.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Background).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox Background;
        private Panel Username;
        private Label label1;
        private CheckBox checkBox1;
        private Panel Password;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Label label2;
        private Label label3;
    }
}
