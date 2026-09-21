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
            label1 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            cbIDType = new ComboBox();
            cbPriority = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtReasonForVisit = new TextBox();
            txtEmergancyContact = new TextBox();
            txtAddress = new TextBox();
            button1 = new Button();
            btnRegisterPatient = new Button();
            SideBar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Logout = new Button();
            Queue = new Button();
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
            SideBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(82, 56);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name ";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(482, 59);
            lblSurname.Margin = new Padding(2, 0, 2, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(82, 25);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname";
            // 
            // lblIDNo
            // 
            lblIDNo.AutoSize = true;
            lblIDNo.Location = new Point(79, 150);
            lblIDNo.Margin = new Padding(2, 0, 2, 0);
            lblIDNo.Name = "lblIDNo";
            lblIDNo.Size = new Size(105, 25);
            lblIDNo.TabIndex = 3;
            lblIDNo.Text = "ID Number ";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(79, 384);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(161, 25);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Cellphone Number";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(79, 241);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 25);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(495, 237);
            lblDOB.Margin = new Padding(2, 0, 2, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(112, 25);
            lblDOB.TabIndex = 6;
            lblDOB.Text = "Date of Birth";
            lblDOB.Click += lblDOB_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(79, 85);
            txtName.Margin = new Padding(2, 4, 2, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(396, 31);
            txtName.TabIndex = 7;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(482, 85);
            txtSurname.Margin = new Padding(2, 4, 2, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(408, 31);
            txtSurname.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(79, 179);
            txtID.Margin = new Padding(2, 4, 2, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(396, 31);
            txtID.TabIndex = 9;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(79, 414);
            txtPhoneNo.Margin = new Padding(2, 4, 2, 4);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(392, 31);
            txtPhoneNo.TabIndex = 10;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female ", "Male" });
            cbGender.Location = new Point(82, 270);
            cbGender.Margin = new Padding(2, 4, 2, 4);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(393, 33);
            cbGender.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(491, 268);
            dateTimePicker1.Margin = new Padding(2, 4, 2, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(408, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 150);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 16;
            label2.Text = "Identification Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(373, 60);
            label1.TabIndex = 23;
            label1.Text = "Register patient";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(289, 155);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(453, 28);
            label7.TabIndex = 24;
            label7.Text = "Enter the patient's details to create a new record";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbIDType);
            groupBox1.Controls.Add(cbPriority);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtReasonForVisit);
            groupBox1.Controls.Add(txtEmergancyContact);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblSurname);
            groupBox1.Controls.Add(lblIDNo);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(lblGender);
            groupBox1.Controls.Add(lblDOB);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(cbGender);
            groupBox1.Location = new Point(289, 220);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1070, 750);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal information";
            // 
            // cbIDType
            // 
            cbIDType.FormattingEnabled = true;
            cbIDType.Items.AddRange(new object[] { "SA ID", "Passport" });
            cbIDType.Location = new Point(482, 180);
            cbIDType.Margin = new Padding(2, 4, 2, 4);
            cbIDType.Name = "cbIDType";
            cbIDType.Size = new Size(393, 33);
            cbIDType.TabIndex = 29;
            cbIDType.SelectedIndexChanged += cbIdententificationType_SelectedIndexChanged;
            // 
            // cbPriority
            // 
            cbPriority.FormattingEnabled = true;
            cbPriority.Location = new Point(491, 664);
            cbPriority.Margin = new Padding(4, 5, 4, 5);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(400, 33);
            cbPriority.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(491, 636);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(68, 25);
            label13.TabIndex = 27;
            label13.Text = "Priority";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(84, 631);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(133, 25);
            label12.TabIndex = 26;
            label12.Text = "Reason for visit";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(31, 575);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(172, 31);
            label11.TabIndex = 25;
            label11.Text = "Medical intake";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(31, 330);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(174, 31);
            label10.TabIndex = 24;
            label10.Text = "Contact details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 485);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 23;
            label9.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(482, 384);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(162, 25);
            label8.TabIndex = 22;
            label8.Text = "Emergency contact";
            // 
            // txtReasonForVisit
            // 
            txtReasonForVisit.Location = new Point(82, 664);
            txtReasonForVisit.Margin = new Padding(4, 5, 4, 5);
            txtReasonForVisit.Name = "txtReasonForVisit";
            txtReasonForVisit.Size = new Size(386, 31);
            txtReasonForVisit.TabIndex = 20;
            // 
            // txtEmergancyContact
            // 
            txtEmergancyContact.Location = new Point(482, 414);
            txtEmergancyContact.Margin = new Padding(4, 5, 4, 5);
            txtEmergancyContact.Name = "txtEmergancyContact";
            txtEmergancyContact.Size = new Size(408, 31);
            txtEmergancyContact.TabIndex = 19;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(79, 515);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(813, 31);
            txtAddress.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(848, 979);
            button1.Margin = new Padding(2, 4, 2, 4);
            button1.Name = "button1";
            button1.Size = new Size(189, 65);
            button1.TabIndex = 26;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPatient
            // 
            btnRegisterPatient.BackColor = Color.FromArgb(11, 61, 92);
            btnRegisterPatient.ForeColor = SystemColors.ControlLightLight;
            btnRegisterPatient.Location = new Point(1111, 979);
            btnRegisterPatient.Margin = new Padding(2, 4, 2, 4);
            btnRegisterPatient.Name = "btnRegisterPatient";
            btnRegisterPatient.Size = new Size(189, 65);
            btnRegisterPatient.TabIndex = 27;
            btnRegisterPatient.Text = "Register patient";
            btnRegisterPatient.UseVisualStyleBackColor = false;
            btnRegisterPatient.Click += btnRegisterPatient_Click;
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(222, 235, 245);
            SideBar.Controls.Add(tableLayoutPanel1);
            SideBar.Controls.Add(Logo);
            SideBar.Controls.Add(panel13);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.Margin = new Padding(4, 5, 4, 5);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(249, 1050);
            SideBar.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Logout, 0, 10);
            tableLayoutPanel1.Controls.Add(Queue, 0, 9);
            tableLayoutPanel1.Controls.Add(Appointments, 0, 7);
            tableLayoutPanel1.Controls.Add(Clinical, 0, 6);
            tableLayoutPanel1.Controls.Add(Reception, 0, 5);
            tableLayoutPanel1.Controls.Add(Doctors, 0, 4);
            tableLayoutPanel1.Controls.Add(Patients, 0, 3);
            tableLayoutPanel1.Controls.Add(Management, 0, 2);
            tableLayoutPanel1.Controls.Add(Dashboard, 0, 1);
            tableLayoutPanel1.Controls.Add(Main, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 140);
            tableLayoutPanel1.Margin = new Padding(4);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(249, 910);
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
            Logout.Location = new Point(4, 846);
            Logout.Margin = new Padding(4, 5, 0, 0);
            Logout.Name = "Logout";
            Logout.Size = new Size(245, 64);
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
            Queue.Location = new Point(4, 626);
            Queue.Margin = new Padding(4, 5, 0, 5);
            Queue.Name = "Queue";
            Queue.Size = new Size(245, 65);
            Queue.TabIndex = 17;
            Queue.Text = "Queue";
            Queue.UseVisualStyleBackColor = false;
            Queue.Click += Queue_Click;
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
            Appointments.Location = new Point(4, 547);
            Appointments.Margin = new Padding(4, 5, 0, 5);
            Appointments.Name = "Appointments";
            Appointments.Size = new Size(245, 69);
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
            Clinical.Location = new Point(4, 485);
            Clinical.Margin = new Padding(4, 25, 4, 25);
            Clinical.Name = "Clinical";
            Clinical.Size = new Size(241, 32);
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
            Reception.Location = new Point(4, 391);
            Reception.Margin = new Padding(4, 5, 0, 5);
            Reception.Name = "Reception";
            Reception.Size = new Size(245, 64);
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
            Doctors.Location = new Point(4, 317);
            Doctors.Margin = new Padding(4, 5, 0, 5);
            Doctors.Name = "Doctors";
            Doctors.Size = new Size(245, 64);
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
            Patients.Location = new Point(4, 243);
            Patients.Margin = new Padding(4, 5, 0, 5);
            Patients.Name = "Patients";
            Patients.Size = new Size(245, 64);
            Patients.TabIndex = 11;
            Patients.Text = "Patients";
            Patients.UseVisualStyleBackColor = false;
            Patients.Click += Patients_Click;
            // 
            // Management
            // 
            Management.AutoSize = true;
            Management.Dock = DockStyle.Top;
            Management.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Management.ForeColor = SystemColors.ActiveCaptionText;
            Management.Location = new Point(4, 181);
            Management.Margin = new Padding(4, 25, 4, 25);
            Management.Name = "Management";
            Management.Size = new Size(241, 32);
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
            Dashboard.Location = new Point(4, 87);
            Dashboard.Margin = new Padding(4, 5, 0, 5);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(245, 64);
            Dashboard.TabIndex = 9;
            Dashboard.Text = "Dashboard";
            Dashboard.UseVisualStyleBackColor = true;
            Dashboard.Click += Dashboard_Click;
            // 
            // Main
            // 
            Main.AutoSize = true;
            Main.Dock = DockStyle.Top;
            Main.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Main.ForeColor = SystemColors.ActiveCaptionText;
            Main.Location = new Point(4, 25);
            Main.Margin = new Padding(4, 25, 4, 25);
            Main.Name = "Main";
            Main.Size = new Size(241, 32);
            Main.TabIndex = 8;
            Main.Text = "Main";
            Main.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            Logo.Dock = DockStyle.Top;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(0, 0);
            Logo.Margin = new Padding(4, 5, 4, 5);
            Logo.Name = "Logo";
            Logo.Size = new Size(249, 140);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 2;
            Logo.TabStop = false;
            // 
            // panel13
            // 
            panel13.Location = new Point(258, 0);
            panel13.Margin = new Padding(4, 5, 4, 5);
            panel13.Name = "panel13";
            panel13.Size = new Size(1042, 99);
            panel13.TabIndex = 1;
            // 
            // Sidebar_Border
            // 
            Sidebar_Border.BackColor = Color.FromArgb(180, 200, 215);
            Sidebar_Border.Dock = DockStyle.Left;
            Sidebar_Border.Location = new Point(249, 0);
            Sidebar_Border.Margin = new Padding(4);
            Sidebar_Border.Name = "Sidebar_Border";
            Sidebar_Border.Size = new Size(2, 1050);
            Sidebar_Border.TabIndex = 30;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(245, 248, 251);
            ClientSize = new Size(1539, 1050);
            Controls.Add(Sidebar_Border);
            Controls.Add(SideBar);
            Controls.Add(btnRegisterPatient);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Margin = new Padding(2, 4, 2, 4);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Registration";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label label1;
        private Label label7;
        private GroupBox groupBox1;
        private Button button1;
        private Button btnRegisterPatient;
        private TextBox txtReasonForVisit;
        private TextBox txtEmergancyContact;
        private TextBox txtAddress;
        private Label label8;
        private Label label9;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox cbPriority;
        private Panel SideBar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Logout;
        private Button Queue;
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
        private ComboBox cbIDType;
    }
}