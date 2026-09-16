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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label6 = new Label();
            btnExit = new Button();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            showPass = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            btnSignIn = new Button();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            Background = new PictureBox();
            gtxtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Background).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Background);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 654);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(342, 4);
            label6.Name = "label6";
            label6.Size = new Size(226, 30);
            label6.TabIndex = 10;
            label6.Text = "Hospital Management System";
            label6.Click += label6_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Image = Properties.Resources.button;
            btnExit.Location = new Point(897, 0);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(53, 34);
            btnExit.TabIndex = 9;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(gtxtUsername);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(showPass);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnSignIn);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(162, 112);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(656, 558);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.Image = Properties.Resources._lock;
            label4.Location = new Point(579, 300);
            label4.Name = "label4";
            label4.Size = new Size(32, 30);
            label4.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.apex_logo;
            pictureBox3.Location = new Point(399, 4);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Location = new Point(485, 338);
            showPass.Margin = new Padding(3, 4, 3, 4);
            showPass.Name = "showPass";
            showPass.Size = new Size(132, 24);
            showPass.TabIndex = 7;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(433, 104);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 6;
            label3.Text = "Sign in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(319, 270);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Brown;
            btnSignIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.Image = Properties.Resources.refer;
            btnSignIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignIn.Location = new Point(389, 390);
            btnSignIn.Margin = new Padding(3, 4, 3, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.RightToLeft = RightToLeft.No;
            btnSignIn.Size = new Size(138, 46);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "sign in";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(319, 300);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(253, 27);
            txtPassword.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images__1_;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(297, 470);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Background
            // 
            Background.Image = Properties.Resources.Screenshot_2026_09_10_232332;
            Background.Location = new Point(-1, 0);
            Background.Margin = new Padding(3, 4, 3, 4);
            Background.Name = "Background";
            Background.Size = new Size(978, 716);
            Background.SizeMode = PictureBoxSizeMode.StretchImage;
            Background.TabIndex = 0;
            Background.TabStop = false;
            Background.Click += pictureBox1_Click;
            // 
            // gtxtUsername
            // 
            gtxtUsername.Animated = true;
            gtxtUsername.BorderRadius = 5;
            customizableEdges1.BottomLeft = false;
            customizableEdges1.BottomRight = false;
            customizableEdges1.TopLeft = false;
            customizableEdges1.TopRight = false;
            gtxtUsername.CustomizableEdges = customizableEdges1;
            gtxtUsername.DefaultText = "";
            gtxtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gtxtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gtxtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gtxtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gtxtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gtxtUsername.Font = new Font("Segoe UI", 9F);
            gtxtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gtxtUsername.IconRight = Properties.Resources.user__1_;
            gtxtUsername.Location = new Point(319, 208);
            gtxtUsername.Margin = new Padding(3, 4, 3, 4);
            gtxtUsername.Name = "gtxtUsername";
            gtxtUsername.PlaceholderText = "Username";
            gtxtUsername.SelectedText = "";
            gtxtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gtxtUsername.Size = new Size(286, 27);
            gtxtUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            gtxtUsername.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(986, 723);
            ControlBox = false;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Background).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox Background;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button btnSignIn;
        private TextBox txtPassword;
        private Label label3;
        private Label label2;
        private CheckBox showPass;
        private PictureBox pictureBox3;
        private Button btnExit;
        private Label label4;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox gtxtUsername;
    }
}
