namespace apex_management_sys
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            TopBar = new Panel();
            Name_Logo_Group = new TableLayoutPanel();
            User_Name = new Label();
            NameLogo = new Label();
            Bottom_Border = new Panel();
            Header = new Label();
            p1 = new Label();
            TotalPatients = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            TodaysAppointments = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            TotalDoctors = new Panel();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            panel7 = new Panel();
            panel9 = new Panel();
            label17 = new Label();
            label16 = new Label();
            panel8 = new Panel();
            label15 = new Label();
            label14 = new Label();
            panel10 = new Panel();
            panel11 = new Panel();
            dataGridView1 = new DataGridView();
            panel12 = new Panel();
            panel13 = new Panel();
            Logo = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Logout = new Button();
            Queue = new Button();
            Admissions = new Button();
            Appointments = new Button();
            Clinical = new Label();
            Reception = new Button();
            Doctors = new Button();
            Patients = new Button();
            Management = new Label();
            Dashboard = new Button();
            Main = new Label();
            SideBar = new Panel();
            Sidebar_Border = new Panel();
            Main_Content = new Panel();
            SummariesPanel = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            HeaderPanel = new TableLayoutPanel();
            TopBar.SuspendLayout();
            Name_Logo_Group.SuspendLayout();
            TotalPatients.SuspendLayout();
            TodaysAppointments.SuspendLayout();
            TotalDoctors.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SideBar.SuspendLayout();
            Main_Content.SuspendLayout();
            SummariesPanel.SuspendLayout();
            HeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.FromArgb(222, 235, 245);
            TopBar.Controls.Add(Name_Logo_Group);
            TopBar.Controls.Add(Bottom_Border);
            TopBar.Dock = DockStyle.Top;
            TopBar.Location = new Point(199, 0);
            TopBar.Margin = new Padding(3, 4, 3, 4);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(1493, 112);
            TopBar.TabIndex = 1;
            TopBar.Paint += panel3_Paint;
            // 
            // Name_Logo_Group
            // 
            Name_Logo_Group.ColumnCount = 2;
            Name_Logo_Group.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Name_Logo_Group.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Name_Logo_Group.Controls.Add(User_Name, 1, 0);
            Name_Logo_Group.Controls.Add(NameLogo, 0, 0);
            Name_Logo_Group.Dock = DockStyle.Right;
            Name_Logo_Group.Location = new Point(1243, 0);
            Name_Logo_Group.Name = "Name_Logo_Group";
            Name_Logo_Group.RowCount = 1;
            Name_Logo_Group.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Name_Logo_Group.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Name_Logo_Group.Size = new Size(250, 110);
            Name_Logo_Group.TabIndex = 19;
            // 
            // User_Name
            // 
            User_Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            User_Name.AutoSize = true;
            User_Name.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User_Name.Location = new Point(128, 35);
            User_Name.Name = "User_Name";
            User_Name.Size = new Size(119, 40);
            User_Name.TabIndex = 3;
            User_Name.Text = "system administrator";
            // 
            // NameLogo
            // 
            NameLogo.Dock = DockStyle.Left;
            NameLogo.Image = (Image)resources.GetObject("NameLogo.Image");
            NameLogo.Location = new Point(3, 0);
            NameLogo.Name = "NameLogo";
            NameLogo.Size = new Size(119, 110);
            NameLogo.TabIndex = 2;
            NameLogo.Click += label5_Click;
            // 
            // Bottom_Border
            // 
            Bottom_Border.BackColor = Color.FromArgb(180, 200, 215);
            Bottom_Border.Dock = DockStyle.Bottom;
            Bottom_Border.Location = new Point(0, 110);
            Bottom_Border.Name = "Bottom_Border";
            Bottom_Border.Size = new Size(1493, 2);
            Bottom_Border.TabIndex = 20;
            // 
            // Header
            // 
            Header.Dock = DockStyle.Fill;
            Header.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Header.Location = new Point(3, 18);
            Header.Name = "Header";
            Header.Size = new Size(1485, 53);
            Header.TabIndex = 2;
            Header.Text = "Welcome back";
            Header.TextAlign = ContentAlignment.TopCenter;
            // 
            // p1
            // 
            p1.AutoSize = true;
            p1.Dock = DockStyle.Fill;
            p1.Location = new Point(3, 71);
            p1.Name = "p1";
            p1.Size = new Size(1485, 54);
            p1.TabIndex = 3;
            p1.Text = "Here's what heppening in the hospital today";
            // 
            // TotalPatients
            // 
            TotalPatients.BackColor = Color.White;
            TotalPatients.Controls.Add(label9);
            TotalPatients.Controls.Add(label8);
            TotalPatients.Controls.Add(label7);
            TotalPatients.Dock = DockStyle.Left;
            TotalPatients.Location = new Point(1172, 66);
            TotalPatients.Margin = new Padding(3, 4, 3, 4);
            TotalPatients.Name = "TotalPatients";
            TotalPatients.Size = new Size(229, 139);
            TotalPatients.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(73, 72);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 2;
            label9.Text = "Total Patients";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(69, 19);
            label8.Name = "label8";
            label8.Size = new Size(49, 37);
            label8.TabIndex = 1;
            label8.Text = "16";
            // 
            // label7
            // 
            label7.Image = Properties.Resources.users_avatar;
            label7.Location = new Point(3, 33);
            label7.Name = "label7";
            label7.Size = new Size(55, 53);
            label7.TabIndex = 0;
            // 
            // TodaysAppointments
            // 
            TodaysAppointments.BackColor = Color.FromArgb(192, 255, 192);
            TodaysAppointments.Controls.Add(label13);
            TodaysAppointments.Controls.Add(label12);
            TodaysAppointments.Controls.Add(label11);
            TodaysAppointments.Controls.Add(label10);
            TodaysAppointments.Dock = DockStyle.Left;
            TodaysAppointments.Location = new Point(209, 66);
            TodaysAppointments.Margin = new Padding(3, 4, 3, 4);
            TodaysAppointments.Name = "TodaysAppointments";
            TodaysAppointments.Size = new Size(229, 139);
            TodaysAppointments.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(79, 19);
            label13.Name = "label13";
            label13.Size = new Size(33, 37);
            label13.TabIndex = 3;
            label13.Text = "4";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(63, 81);
            label12.Name = "label12";
            label12.Size = new Size(110, 20);
            label12.TabIndex = 2;
            label12.Text = "Appointments";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(63, 61);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 1;
            label11.Text = "Today's ";
            // 
            // label10
            // 
            label10.Image = Properties.Resources.calendar;
            label10.Location = new Point(3, 28);
            label10.Name = "label10";
            label10.Size = new Size(53, 59);
            label10.TabIndex = 0;
            // 
            // TotalDoctors
            // 
            TotalDoctors.BackColor = Color.FromArgb(255, 255, 192);
            TotalDoctors.Controls.Add(label22);
            TotalDoctors.Controls.Add(label21);
            TotalDoctors.Controls.Add(label20);
            TotalDoctors.Controls.Add(label19);
            TotalDoctors.Dock = DockStyle.Left;
            TotalDoctors.Location = new Point(530, 66);
            TotalDoctors.Margin = new Padding(3, 4, 3, 4);
            TotalDoctors.Name = "TotalDoctors";
            TotalDoctors.Size = new Size(229, 139);
            TotalDoctors.TabIndex = 6;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(88, 93);
            label22.Name = "label22";
            label22.Size = new Size(64, 20);
            label22.TabIndex = 3;
            label22.Text = "Doctors";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(86, 63);
            label21.Name = "label21";
            label21.Size = new Size(120, 20);
            label21.TabIndex = 2;
            label21.Text = "total number of";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(88, 23);
            label20.Name = "label20";
            label20.Size = new Size(28, 32);
            label20.TabIndex = 1;
            label20.Text = "8";
            // 
            // label19
            // 
            label19.BackColor = Color.FromArgb(192, 255, 192);
            label19.Image = Properties.Resources.doctor;
            label19.Location = new Point(16, 36);
            label19.Name = "label19";
            label19.Size = new Size(47, 56);
            label19.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.Controls.Add(panel9);
            panel7.Location = new Point(905, 375);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(432, 359);
            panel7.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(label17);
            panel9.Controls.Add(label16);
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(432, 52);
            panel9.TabIndex = 0;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(83, 15);
            label17.Name = "label17";
            label17.Size = new Size(140, 25);
            label17.TabIndex = 1;
            label17.Text = "Recent Patient";
            // 
            // label16
            // 
            label16.Image = Properties.Resources.notification;
            label16.ImageAlign = ContentAlignment.MiddleLeft;
            label16.Location = new Point(32, 13);
            label16.Name = "label16";
            label16.Size = new Size(40, 31);
            label16.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label15);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(216, 375);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(632, 57);
            panel8.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(69, 17);
            label15.Name = "label15";
            label15.Size = new Size(204, 25);
            label15.TabIndex = 1;
            label15.Text = "Recent Appointments";
            // 
            // label14
            // 
            label14.Image = Properties.Resources.notification;
            label14.Location = new Point(3, 4);
            label14.Name = "label14";
            label14.Size = new Size(63, 47);
            label14.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Violet;
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(851, 66);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(229, 139);
            panel10.TabIndex = 11;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Snow;
            panel11.Controls.Add(dataGridView1);
            panel11.Location = new Point(216, 751);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(1063, 232);
            panel11.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1063, 232);
            dataGridView1.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Location = new Point(216, 751);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(1063, 57);
            panel12.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Location = new Point(206, 0);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(834, 79);
            panel13.TabIndex = 1;
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
            tableLayoutPanel1.Controls.Add(Patients, 0, 3);
            tableLayoutPanel1.Controls.Add(Management, 0, 2);
            tableLayoutPanel1.Controls.Add(Dashboard, 0, 1);
            tableLayoutPanel1.Controls.Add(Main, 0, 0);
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
            tableLayoutPanel1.Size = new Size(199, 887);
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
            Logout.Location = new Point(3, 836);
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
            Queue.Location = new Point(3, 567);
            Queue.Margin = new Padding(3, 4, 0, 4);
            Queue.Name = "Queue";
            Queue.Size = new Size(196, 52);
            Queue.TabIndex = 17;
            Queue.Text = "Queue";
            Queue.UseVisualStyleBackColor = false;
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
            Admissions.Location = new Point(3, 507);
            Admissions.Margin = new Padding(3, 4, 0, 4);
            Admissions.Name = "Admissions";
            Admissions.Size = new Size(196, 52);
            Admissions.TabIndex = 16;
            Admissions.Text = "Admissions";
            Admissions.UseVisualStyleBackColor = false;
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
            Appointments.Location = new Point(3, 444);
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
            Clinical.Location = new Point(3, 392);
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
            Reception.Location = new Point(3, 317);
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
            Doctors.Location = new Point(3, 258);
            Doctors.Margin = new Padding(3, 4, 0, 4);
            Doctors.Name = "Doctors";
            Doctors.Size = new Size(196, 51);
            Doctors.TabIndex = 12;
            Doctors.Text = "Doctors";
            Doctors.UseVisualStyleBackColor = false;
            // 
            // Patients
            // 
            Patients.BackColor = Color.FromArgb(222, 235, 245);
            Patients.Cursor = Cursors.Hand;
            Patients.Dock = DockStyle.Top;
            Patients.FlatAppearance.BorderSize = 0;
            Patients.FlatStyle = FlatStyle.Flat;
            Patients.ForeColor = Color.FromArgb(0, 0, 0, 0);
            Patients.Image = (Image)resources.GetObject("Patients.Image");
            Patients.ImageAlign = ContentAlignment.MiddleLeft;
            Patients.Location = new Point(3, 199);
            Patients.Margin = new Padding(3, 4, 0, 4);
            Patients.Name = "Patients";
            Patients.Size = new Size(196, 51);
            Patients.TabIndex = 11;
            Patients.Text = "Patients";
            Patients.UseVisualStyleBackColor = false;
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
            // 
            // Main
            // 
            Main.AutoSize = true;
            Main.Dock = DockStyle.Top;
            Main.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Main.ForeColor = SystemColors.ActiveCaptionText;
            Main.Location = new Point(3, 20);
            Main.Margin = new Padding(3, 20, 3, 20);
            Main.Name = "Main";
            Main.Size = new Size(193, 28);
            Main.TabIndex = 8;
            Main.Text = "Main";
            Main.TextAlign = ContentAlignment.MiddleCenter;
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
            SideBar.Size = new Size(199, 999);
            SideBar.TabIndex = 12;
            // 
            // Sidebar_Border
            // 
            Sidebar_Border.BackColor = Color.FromArgb(180, 200, 215);
            Sidebar_Border.Dock = DockStyle.Left;
            Sidebar_Border.Location = new Point(199, 112);
            Sidebar_Border.Name = "Sidebar_Border";
            Sidebar_Border.Size = new Size(2, 887);
            Sidebar_Border.TabIndex = 13;
            // 
            // Main_Content
            // 
            Main_Content.AutoScroll = true;
            Main_Content.Controls.Add(SummariesPanel);
            Main_Content.Controls.Add(flowLayoutPanel1);
            Main_Content.Controls.Add(panel7);
            Main_Content.Controls.Add(panel8);
            Main_Content.Controls.Add(panel11);
            Main_Content.Controls.Add(panel12);
            Main_Content.Controls.Add(HeaderPanel);
            Main_Content.Dock = DockStyle.Top;
            Main_Content.Location = new Point(201, 112);
            Main_Content.Name = "Main_Content";
            Main_Content.Size = new Size(1491, 999);
            Main_Content.TabIndex = 14;
            // 
            // SummariesPanel
            // 
            SummariesPanel.ColumnCount = 5;
            SummariesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.81688F));
            SummariesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.54578F));
            SummariesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.54578F));
            SummariesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.54578F));
            SummariesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.54578F));
            SummariesPanel.Controls.Add(panel10, 3, 1);
            SummariesPanel.Controls.Add(TotalDoctors, 2, 1);
            SummariesPanel.Controls.Add(TodaysAppointments, 1, 1);
            SummariesPanel.Controls.Add(TotalPatients, 4, 1);
            SummariesPanel.Dock = DockStyle.Top;
            SummariesPanel.Location = new Point(0, 125);
            SummariesPanel.Name = "SummariesPanel";
            SummariesPanel.RowCount = 2;
            SummariesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            SummariesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            SummariesPanel.Size = new Size(1491, 209);
            SummariesPanel.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Location = new Point(216, 430);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(632, 301);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // HeaderPanel
            // 
            HeaderPanel.ColumnCount = 1;
            HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            HeaderPanel.Controls.Add(Header, 0, 1);
            HeaderPanel.Controls.Add(p1, 0, 2);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.RowCount = 2;
            HeaderPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            HeaderPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 42.5F));
            HeaderPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 42.5F));
            HeaderPanel.Size = new Size(1491, 125);
            HeaderPanel.TabIndex = 14;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 251);
            ClientSize = new Size(1692, 999);
            Controls.Add(Main_Content);
            Controls.Add(Sidebar_Border);
            Controls.Add(TopBar);
            Controls.Add(SideBar);
            ForeColor = Color.FromArgb(33, 37, 41);
            Margin = new Padding(3, 4, 3, 4);
            Name = "home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "home";
            WindowState = FormWindowState.Maximized;
            TopBar.ResumeLayout(false);
            Name_Logo_Group.ResumeLayout(false);
            Name_Logo_Group.PerformLayout();
            TotalPatients.ResumeLayout(false);
            TotalPatients.PerformLayout();
            TodaysAppointments.ResumeLayout(false);
            TodaysAppointments.PerformLayout();
            TotalDoctors.ResumeLayout(false);
            TotalDoctors.PerformLayout();
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            SideBar.ResumeLayout(false);
            Main_Content.ResumeLayout(false);
            SummariesPanel.ResumeLayout(false);
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel TopBar;
        private Label Header;
        private Label p1;
        private Label NameLogo;
        private Panel TotalPatients;
        private Panel TodaysAppointments;
        private Panel TotalDoctors;
        private Label User_Name;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label13;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label16;
        private Panel panel10;
        private Panel panel11;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label22;
        private DataGridView dataGridView1;
        private Panel panel12;
        private Panel panel13;
        private PictureBox Logo;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Logout;
        private Button Queue;
        private Button Admissions;
        private Button Appointments;
        private Label Clinical;
        private Button Reception;
        private Button Doctors;
        private Button Patients;
        private Label Management;
        private Button Dashboard;
        private Label Main;
        private Panel SideBar;
        private TableLayoutPanel Name_Logo_Group;
        private Panel Bottom_Border;
        private Panel Sidebar_Border;
        private Panel Main_Content;
        private TableLayoutPanel SummariesPanel;
        private TableLayoutPanel HeaderPanel;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}