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
            panel1 = new Panel();
            label6 = new Label();
            btnExit = new Button();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            showPass = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSignIn = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            Background = new PictureBox();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 490);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(299, 3);
            label6.Name = "label6";
            label6.Size = new Size(198, 37);
            label6.TabIndex = 10;
            label6.Text = "Hospital Management System";
            label6.Click += label6_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Image = Properties.Resources.button;
            btnExit.Location = new Point(785, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(46, 26);
            btnExit.TabIndex = 9;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(showPass);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnSignIn);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(142, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 352);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.Image = Properties.Resources.user;
            label5.Location = new Point(507, 156);
            label5.Name = "label5";
            label5.Size = new Size(28, 22);
            label5.TabIndex = 10;
            // 
            // label4
            // 
            label4.Image = Properties.Resources._lock;
            label4.Location = new Point(507, 225);
            label4.Name = "label4";
            label4.Size = new Size(28, 22);
            label4.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.apex_logo;
            pictureBox3.Location = new Point(349, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(136, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Location = new Point(424, 254);
            showPass.Name = "showPass";
            showPass.Size = new Size(108, 19);
            showPass.TabIndex = 7;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(379, 78);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 6;
            label3.Text = "Sign in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(279, 202);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 122);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Brown;
            btnSignIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.Image = Properties.Resources.refer;
            btnSignIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignIn.Location = new Point(340, 292);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.RightToLeft = RightToLeft.No;
            btnSignIn.Size = new Size(121, 34);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "sign in";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(279, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(222, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(279, 156);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(222, 23);
            txtUsername.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images__1_;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(260, 352);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Background
            // 
            Background.Image = Properties.Resources.Screenshot_2026_09_10_232332;
            Background.Location = new Point(-1, 0);
            Background.Name = "Background";
            Background.Size = new Size(856, 537);
            Background.SizeMode = PictureBoxSizeMode.StretchImage;
            Background.TabIndex = 0;
            Background.TabStop = false;
            Background.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(846, 491);
            ControlBox = false;
            Controls.Add(panel1);
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
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox showPass;
        private PictureBox pictureBox3;
        private Button btnExit;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
