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
            panel2 = new Panel();
<<<<<<< HEAD
            gtxtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
=======
            ktxtPassword = new Krypton.Toolkit.KryptonTextBox();
            ktxtUsername = new Krypton.Toolkit.KryptonTextBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            showPass = new CheckBox();
            label3 = new Label();
            btnSignIn = new Button();
>>>>>>> 6d7c56c97fe9f1217a937481d32cc6bf39c5cd70
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
<<<<<<< HEAD
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 61, 92);
            panel2.BackgroundImage = Properties.Resources.Screenshot_2026_09_17_132434;
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1302, 699);
            panel2.TabIndex = 1;
            // 
            // gtxtUsername
            // 
            gtxtUsername.Location = new Point(31, 97);
            gtxtUsername.Name = "gtxtUsername";
            gtxtUsername.Size = new Size(150, 31);
            gtxtUsername.TabIndex = 0;
            gtxtUsername.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(31, 53);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 242);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(31, 305);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(11, 61, 92);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(31, 528);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 308);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
=======
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
            panel2.Controls.Add(ktxtPassword);
            panel2.Controls.Add(ktxtUsername);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(showPass);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnSignIn);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(162, 112);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(656, 558);
            panel2.TabIndex = 1;
            // 
            // ktxtPassword
            // 
            ktxtPassword.CueHint.CueHintText = "Enter Password";
            ktxtPassword.Location = new Point(319, 304);
            ktxtPassword.Name = "ktxtPassword";
            ktxtPassword.PasswordChar = '●';
            ktxtPassword.Size = new Size(253, 27);
            ktxtPassword.TabIndex = 11;
            ktxtPassword.UseSystemPasswordChar = true;
            // 
            // ktxtUsername
            // 
            ktxtUsername.CueHint.CueHintText = "Enter Username";
            ktxtUsername.Location = new Point(319, 217);
            ktxtUsername.Name = "ktxtUsername";
            ktxtUsername.Size = new Size(253, 27);
            ktxtUsername.TabIndex = 10;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images__1_;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(297, 470);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
>>>>>>> 6d7c56c97fe9f1217a937481d32cc6bf39c5cd70
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
<<<<<<< HEAD
            panel1.BackColor = Color.FromArgb(11, 61, 92);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(gtxtUsername);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 696);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(31, 351);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(136, 25);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Show Password";
            linkLabel1.UseMnemonic = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1302, 699);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
=======
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(986, 723);
            ControlBox = false;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
>>>>>>> 6d7c56c97fe9f1217a937481d32cc6bf39c5cd70
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox2;
<<<<<<< HEAD
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox txtPassword;
        private Label label2;
        private Label label1;
        private TextBox gtxtUsername;
        private LinkLabel linkLabel1;
=======
        private Button btnSignIn;
        private Label label3;
        private CheckBox showPass;
        private PictureBox pictureBox3;
        private Button btnExit;
        private Label label4;
        private Label label6;
        private Krypton.Toolkit.KryptonTextBox ktxtUsername;
        private Krypton.Toolkit.KryptonTextBox ktxtPassword;
>>>>>>> 6d7c56c97fe9f1217a937481d32cc6bf39c5cd70
    }
}
