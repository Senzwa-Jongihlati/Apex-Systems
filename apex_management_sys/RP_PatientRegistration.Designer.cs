namespace apex_management_sys
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            lblName = new Label();
            lblSurname = new Label();
            lblIDNo = new Label();
            lblPhone = new Label();
            lblGender = new Label();
            lblDOB = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtID = new TextBox();
            txtPhoneNo = new TextBox();
            cbGender = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            txtAddress = new TextBox();
            label1 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            TopBar = new Panel();
            Name_Logo_Group = new TableLayoutPanel();
            User_Name = new Label();
            NameLogo = new Label();
            Bottom_Border = new Panel();
            SideBar = new Panel();
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
            Logo = new PictureBox();
            panel13 = new Panel();
            Sidebar_Border = new Panel();
            groupBox1.SuspendLayout();
            TopBar.SuspendLayout();
            Name_Logo_Group.SuspendLayout();
            SideBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(66, 45);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name ";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(386, 47);
            lblSurname.Margin = new Padding(2, 0, 2, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(67, 20);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname";
            // 
            // lblIDNo
            // 
            lblIDNo.AutoSize = true;
            lblIDNo.Location = new Point(63, 120);
            lblIDNo.Margin = new Padding(2, 0, 2, 0);
            lblIDNo.Name = "lblIDNo";
            lblIDNo.Size = new Size(86, 20);
            lblIDNo.TabIndex = 3;
            lblIDNo.Text = "ID Number ";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(63, 307);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(134, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Cellphone Number";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(63, 193);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(386, 120);
            lblDOB.Margin = new Padding(2, 0, 2, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(94, 20);
            lblDOB.TabIndex = 6;
            lblDOB.Text = "Date of Birth";
            lblDOB.Click += lblDOB_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(63, 68);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(318, 27);
            txtName.TabIndex = 7;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(386, 68);
            txtSurname.Margin = new Padding(2, 3, 2, 3);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(327, 27);
            txtSurname.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(63, 143);
            txtID.Margin = new Padding(2, 3, 2, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(318, 27);
            txtID.TabIndex = 9;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(63, 331);
            txtPhoneNo.Margin = new Padding(2, 3, 2, 3);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(314, 27);
            txtPhoneNo.TabIndex = 10;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female ", "Male" });
            cbGender.Location = new Point(66, 216);
            cbGender.Margin = new Padding(2, 3, 2, 3);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(315, 28);
            cbGender.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(386, 143);
            dateTimePicker1.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(327, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 193);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 16;
            label2.Text = "Home language";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(386, 216);
            txtAddress.Margin = new Padding(2, 3, 2, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(327, 27);
            txtAddress.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 59);
            label1.Name = "label1";
            label1.Size = new Size(313, 50);
            label1.TabIndex = 23;
            label1.Text = "Register patient";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(231, 124);
            label7.Name = "label7";
            label7.Size = new Size(381, 23);
            label7.TabIndex = 24;
            label7.Text = "Enter the patient's details to create a new record";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblSurname);
            groupBox1.Controls.Add(lblIDNo);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(lblGender);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(lblDOB);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(cbGender);
            groupBox1.Location = new Point(231, 176);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(856, 600);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal information";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(393, 531);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(321, 28);
            comboBox1.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(393, 509);
            label13.Name = "label13";
            label13.Size = new Size(56, 20);
            label13.TabIndex = 27;
            label13.Text = "Priority";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(67, 505);
            label12.Name = "label12";
            label12.Size = new Size(110, 20);
            label12.TabIndex = 26;
            label12.Text = "Reason for visit";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(25, 460);
            label11.Name = "label11";
            label11.Size = new Size(141, 25);
            label11.TabIndex = 25;
            label11.Text = "Medical intake";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 264);
            label10.Name = "label10";
            label10.Size = new Size(143, 25);
            label10.TabIndex = 24;
            label10.Text = "Contact details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 388);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 23;
            label9.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(386, 307);
            label8.Name = "label8";
            label8.Size = new Size(135, 20);
            label8.TabIndex = 22;
            label8.Text = "Emergency contact";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(66, 531);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(310, 27);
            textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(386, 331);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 27);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 412);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(651, 27);
            textBox1.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(678, 783);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(151, 52);
            button1.TabIndex = 26;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(11, 61, 92);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(889, 783);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(151, 52);
            button2.TabIndex = 27;
            button2.Text = "Register patient";
            button2.UseVisualStyleBackColor = false;
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
            TopBar.Size = new Size(1032, 112);
            TopBar.TabIndex = 28;
            // 
            // Name_Logo_Group
            // 
            Name_Logo_Group.ColumnCount = 2;
            Name_Logo_Group.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Name_Logo_Group.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Name_Logo_Group.Controls.Add(User_Name, 1, 0);
            Name_Logo_Group.Controls.Add(NameLogo, 0, 0);
            Name_Logo_Group.Dock = DockStyle.Right;
            Name_Logo_Group.Location = new Point(782, 0);
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
            // 
            // Bottom_Border
            // 
            Bottom_Border.BackColor = Color.FromArgb(180, 200, 215);
            Bottom_Border.Dock = DockStyle.Bottom;
            Bottom_Border.Location = new Point(0, 110);
            Bottom_Border.Name = "Bottom_Border";
            Bottom_Border.Size = new Size(1032, 2);
            Bottom_Border.TabIndex = 20;
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
            SideBar.TabIndex = 29;
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
            Sidebar_Border.Location = new Point(199, 112);
            Sidebar_Border.Name = "Sidebar_Border";
            Sidebar_Border.Size = new Size(2, 887);
            Sidebar_Border.TabIndex = 30;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1231, 999);
            Controls.Add(Sidebar_Border);
            Controls.Add(TopBar);
            Controls.Add(SideBar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Registration";
            Text = "Patient Registration";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TopBar.ResumeLayout(false);
            Name_Logo_Group.ResumeLayout(false);
            Name_Logo_Group.PerformLayout();
            SideBar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblSurname;
        private Label lblIDNo;
        private Label lblPhone;
        private Label lblGender;
        private Label lblDOB;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtID;
        private TextBox txtPhoneNo;
        private ComboBox cbGender;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox txtAddress;
        private Label label1;
        private Label label7;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label9;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox comboBox1;
        private Panel TopBar;
        private TableLayoutPanel Name_Logo_Group;
        private Label User_Name;
        private Label NameLogo;
        private Panel Bottom_Border;
        private Panel SideBar;
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
        private PictureBox Logo;
        private Panel panel13;
        private Panel Sidebar_Border;
    }
}