namespace apex_management_sys
{
    partial class RP_SearchPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP_SearchPatient));
            label1 = new Label();
            lbl2IDNo = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label7 = new Label();
            comboBox2 = new ComboBox();
            btnAddPatient = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            SideBar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Logout = new Button();
            Queue = new Button();
            Admissions = new Button();
            Appointments = new Button();
            Clinical = new Label();
            Reception = new Button();
            Doctors = new Button();
            Management = new Label();
            Dashboard = new Button();
            Important = new Label();
            Logo = new PictureBox();
            panel13 = new Panel();
            Sidebar_Border = new Panel();
            Main = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SideBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            Main.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 66);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 46);
            label1.TabIndex = 0;
            label1.Text = "Patients";
            // 
            // lbl2IDNo
            // 
            lbl2IDNo.AutoSize = true;
            lbl2IDNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2IDNo.ForeColor = Color.Blue;
            lbl2IDNo.Location = new Point(66, 126);
            lbl2IDNo.Margin = new Padding(2, 0, 2, 0);
            lbl2IDNo.Name = "lbl2IDNo";
            lbl2IDNo.Size = new Size(212, 28);
            lbl2IDNo.TabIndex = 1;
            lbl2IDNo.Text = "Deshboard / Patients";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 73);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1114, 460);
            dataGridView1.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Image = Properties.Resources.search_interface_symbol;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(894, 37);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(92, 45);
            button2.TabIndex = 16;
            button2.Text = "Filter";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBox2);
            panel1.Location = new Point(107, 281);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 119);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 44);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 0;
            label2.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 48);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 27);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(443, 9);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Completed", "Waiting", "Cancelled" });
            comboBox1.Location = new Point(433, 48);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 28);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(1010, 37);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 45);
            button1.TabIndex = 17;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(689, 9);
            label7.Name = "label7";
            label7.Size = new Size(79, 28);
            label7.TabIndex = 4;
            label7.Text = "Gender";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female" });
            comboBox2.Location = new Point(674, 46);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(162, 28);
            comboBox2.TabIndex = 5;
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = Color.FromArgb(11, 61, 92);
            btnAddPatient.ForeColor = SystemColors.ControlLightLight;
            btnAddPatient.Location = new Point(1002, 162);
            btnAddPatient.Margin = new Padding(3, 4, 3, 4);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(222, 73);
            btnAddPatient.TabIndex = 20;
            btnAddPatient.Text = "Add patient";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(106, 408);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 533);
            panel2.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1117, 75);
            panel4.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(197, 23);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 2;
            label10.Text = "(12 total)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(81, 16);
            label9.Name = "label9";
            label9.Size = new Size(119, 28);
            label9.TabIndex = 1;
            label9.Text = "Patient List";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.Image = Properties.Resources.users_avatar;
            label8.Location = new Point(21, 16);
            label8.Name = "label8";
            label8.Size = new Size(54, 45);
            label8.TabIndex = 0;
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(222, 235, 245);
            SideBar.Controls.Add(tableLayoutPanel1);
            SideBar.Controls.Add(Logo);
            SideBar.Controls.Add(panel13);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.Margin = new Padding(3, 4, 3, 4);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(199, 971);
            SideBar.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Logout, 0, 10);
            tableLayoutPanel1.Controls.Add(Queue, 0, 9);
            tableLayoutPanel1.Controls.Add(Admissions, 0, 8);
            tableLayoutPanel1.Controls.Add(Appointments, 0, 7);
            tableLayoutPanel1.Controls.Add(Clinical, 0, 6);
            tableLayoutPanel1.Controls.Add(Reception, 0, 5);
            tableLayoutPanel1.Controls.Add(Doctors, 0, 4);
            tableLayoutPanel1.Controls.Add(Management, 0, 2);
            tableLayoutPanel1.Controls.Add(Dashboard, 0, 1);
            tableLayoutPanel1.Controls.Add(Important, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 112);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(199, 859);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Logout
            // 
            Logout.BackColor = Color.FromArgb(222, 235, 245);
            Logout.Cursor = Cursors.Hand;
            Logout.Dock = DockStyle.Bottom;
            Logout.FlatAppearance.BorderSize = 0;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.ForeColor = Color.FromArgb(0, 0, 0, 0);
            Logout.Image = (Image)resources.GetObject("Logout.Image");
            Logout.ImageAlign = ContentAlignment.MiddleLeft;
            Logout.Location = new Point(3, 808);
            Logout.Margin = new Padding(3, 4, 0, 0);
            Logout.Name = "Logout";
            Logout.Size = new Size(196, 51);
            Logout.TabIndex = 18;
            Logout.Text = "log out";
            Logout.UseVisualStyleBackColor = false;
            // 
            // Queue
            // 
            Queue.BackColor = Color.FromArgb(222, 235, 245);
            Queue.Cursor = Cursors.Hand;
            Queue.Dock = DockStyle.Top;
            Queue.FlatAppearance.BorderSize = 0;
            Queue.FlatStyle = FlatStyle.Flat;
            Queue.ForeColor = Color.FromArgb(0, 0, 0, 0);
            Queue.Image = (Image)resources.GetObject("Queue.Image");
            Queue.ImageAlign = ContentAlignment.MiddleLeft;
            Queue.Location = new Point(3, 508);
            Queue.Margin = new Padding(3, 4, 0, 4);
            Queue.Name = "Queue";
            Queue.Size = new Size(196, 52);
            Queue.TabIndex = 17;
            Queue.Text = "Queue";
            Queue.UseVisualStyleBackColor = false;
            Queue.Click += Queue_Click;
            // 
            // Admissions
            // 
            Admissions.BackColor = Color.FromArgb(222, 235, 245);
            Admissions.Cursor = Cursors.Hand;
            Admissions.Dock = DockStyle.Top;
            Admissions.FlatAppearance.BorderSize = 0;
            Admissions.FlatStyle = FlatStyle.Flat;
            Admissions.ForeColor = Color.FromArgb(0, 0, 0, 0);
            Admissions.Image = (Image)resources.GetObject("Admissions.Image");
            Admissions.ImageAlign = ContentAlignment.MiddleLeft;
            Admissions.Location = new Point(3, 448);
            Admissions.Margin = new Padding(3, 4, 0, 4);
            Admissions.Name = "Admissions";
            Admissions.Size = new Size(196, 52);
            Admissions.TabIndex = 16;
            Admissions.Text = "Admissions";
            Admissions.UseVisualStyleBackColor = false;
            Admissions.Click += Admissions_Click;
            // 
            // Appointments
            // 
            Appointments.BackColor = Color.FromArgb(222, 235, 245);
            Appointments.Cursor = Cursors.Hand;
            Appointments.Dock = DockStyle.Top;
            Appointments.FlatAppearance.BorderSize = 0;
            Appointments.FlatStyle = FlatStyle.Flat;
            Appointments.ForeColor = Color.FromArgb(0, 0, 0, 0);
            Appointments.Image = (Image)resources.GetObject("Appointments.Image");
            Appointments.ImageAlign = ContentAlignment.MiddleLeft;
            Appointments.Location = new Point(3, 385);
            Appointments.Margin = new Padding(3, 4, 0, 4);
            Appointments.Name = "Appointments";
            Appointments.Size = new Size(196, 55);
            Appointments.TabIndex = 15;
            Appointments.Text = "Appointments";
            Appointments.UseVisualStyleBackColor = false;
            // 
            // Clinical
            // 
            Clinical.AutoSize = true;
            Clinical.Dock = DockStyle.Top;
            Clinical.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clinical.ForeColor = SystemColors.ActiveCaptionText;
            Clinical.Location = new Point(3, 333);
            Clinical.Margin = new Padding(3, 20, 3, 20);
            Clinical.Name = "Clinical";
            Clinical.Size = new Size(193, 28);
            Clinical.TabIndex = 14;
            Clinical.Text = "Clinical";
            Clinical.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Reception
            // 
            Reception.BackColor = Color.FromArgb(222, 235, 245);
            Reception.Cursor = Cursors.Hand;
            Reception.Dock = DockStyle.Top;
            Reception.FlatAppearance.BorderSize = 0;
            Reception.FlatStyle = FlatStyle.Flat;
            Reception.ForeColor = Color.FromArgb(0, 0, 0, 0);
            Reception.Image = (Image)resources.GetObject("Reception.Image");
            Reception.ImageAlign = ContentAlignment.MiddleLeft;
            Reception.Location = new Point(3, 258);
            Reception.Margin = new Padding(3, 4, 0, 4);
            Reception.Name = "Reception";
            Reception.Size = new Size(196, 51);
            Reception.TabIndex = 13;
            Reception.Text = "Reception";
            Reception.UseVisualStyleBackColor = false;
            // 
            // Doctors
            // 
            Doctors.BackColor = Color.FromArgb(222, 235, 245);
            Doctors.Cursor = Cursors.Hand;
            Doctors.Dock = DockStyle.Top;
            Doctors.FlatAppearance.BorderSize = 0;
            Doctors.FlatStyle = FlatStyle.Flat;
            Doctors.ForeColor = Color.FromArgb(0, 0, 0, 0);
            Doctors.Image = (Image)resources.GetObject("Doctors.Image");
            Doctors.ImageAlign = ContentAlignment.MiddleLeft;
            Doctors.Location = new Point(3, 199);
            Doctors.Margin = new Padding(3, 4, 0, 4);
            Doctors.Name = "Doctors";
            Doctors.Size = new Size(196, 51);
            Doctors.TabIndex = 12;
            Doctors.Text = "Doctors";
            Doctors.UseVisualStyleBackColor = false;
            // 
            // Management
            // 
            Management.AutoSize = true;
            Management.Dock = DockStyle.Top;
            Management.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Management.ForeColor = SystemColors.ActiveCaptionText;
            Management.Location = new Point(3, 147);
            Management.Margin = new Padding(3, 20, 3, 20);
            Management.Name = "Management";
            Management.Size = new Size(193, 28);
            Management.TabIndex = 10;
            Management.Text = "Management";
            Management.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            Dashboard.Cursor = Cursors.Hand;
            Dashboard.Dock = DockStyle.Top;
            Dashboard.FlatAppearance.BorderSize = 0;
            Dashboard.FlatStyle = FlatStyle.Flat;
            Dashboard.ForeColor = Color.FromArgb(0, 0, 0, 0);
            Dashboard.Image = (Image)resources.GetObject("Dashboard.Image");
            Dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard.Location = new Point(3, 72);
            Dashboard.Margin = new Padding(3, 4, 0, 4);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(196, 51);
            Dashboard.TabIndex = 9;
            Dashboard.Text = "Dashboard";
            Dashboard.UseVisualStyleBackColor = true;
            Dashboard.Click += Dashboard_Click;
            // 
            // Important
            // 
            Important.AutoSize = true;
            Important.Dock = DockStyle.Top;
            Important.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Important.ForeColor = SystemColors.ActiveCaptionText;
            Important.Location = new Point(3, 20);
            Important.Margin = new Padding(3, 20, 3, 20);
            Important.Name = "Important";
            Important.Size = new Size(193, 28);
            Important.TabIndex = 8;
            Important.Text = "Main";
            Important.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            Logo.Dock = DockStyle.Top;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(0, 0);
            Logo.Margin = new Padding(3, 4, 3, 4);
            Logo.Name = "Logo";
            Logo.Size = new Size(199, 112);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 2;
            Logo.TabStop = false;
            // 
            // panel13
            // 
            panel13.Location = new Point(206, 0);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(834, 79);
            panel13.TabIndex = 1;
            // 
            // Sidebar_Border
            // 
            Sidebar_Border.BackColor = Color.FromArgb(180, 200, 215);
            Sidebar_Border.Dock = DockStyle.Left;
            Sidebar_Border.Location = new Point(199, 0);
            Sidebar_Border.Name = "Sidebar_Border";
            Sidebar_Border.Size = new Size(2, 971);
            Sidebar_Border.TabIndex = 24;
            // 
            // Main
            // 
            Main.BackColor = Color.FromArgb(245, 248, 251);
            Main.Controls.Add(panel1);
            Main.Controls.Add(label1);
            Main.Controls.Add(lbl2IDNo);
            Main.Controls.Add(btnAddPatient);
            Main.Controls.Add(panel2);
            Main.Dock = DockStyle.Fill;
            Main.Location = new Point(201, 0);
            Main.Name = "Main";
            Main.Size = new Size(1300, 971);
            Main.TabIndex = 25;
            // 
            // RP_SearchPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 971);
            Controls.Add(Main);
            Controls.Add(Sidebar_Border);
            Controls.Add(SideBar);
            Margin = new Padding(2, 3, 2, 3);
            Name = "RP_SearchPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Returning Patient";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            SideBar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            Main.ResumeLayout(false);
            Main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lbl2IDNo;
        private DataGridView dataGridView1;
        private Button button2;
        private Panel panel1;
        private ComboBox comboBox2;
        private Label label7;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button btnAddPatient;
        private Panel panel2;
        private Panel panel4;
        private Label label9;
        private Label label8;
        private Label label10;
        private Panel SideBar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Logout;
        private Button Queue;
        private Button Admissions;
        private Button Appointments;
        private Label Clinical;
        private Button Reception;
        private Button Doctors;
        private Label Management;
        private Button Dashboard;
        private Label Important;
        private PictureBox Logo;
        private Panel panel13;
        private Panel Sidebar_Border;
        private Panel Main;
    }
}