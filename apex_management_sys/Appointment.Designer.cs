namespace apex_management_sys
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            Main = new Panel();
            Header = new TableLayoutPanel();
            label4 = new Label();
            CancelAppointment = new Button();
            Delete = new Button();
            CancelAddition = new Button();
            BookAppointment = new Button();
            panel4 = new Panel();
            AppointmentsGrid = new DataGridView();
            panel6 = new Panel();
            label6 = new Label();
            groupBox1 = new GroupBox();
            cmbPatient = new ComboBox();
            cmbDoctor = new ComboBox();
            Reason = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            Logo = new PictureBox();
            panel13 = new Panel();
            Sidebar_Border = new Panel();
            MainSection = new TableLayoutPanel();
            NewAppointment = new TableLayoutPanel();
            panel1 = new Panel();
            AllAppointments = new TableLayoutPanel();
            panel2 = new Panel();
            Main.SuspendLayout();
            Header.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AppointmentsGrid).BeginInit();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            SideBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            MainSection.SuspendLayout();
            NewAppointment.SuspendLayout();
            panel1.SuspendLayout();
            AllAppointments.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Main
            // 
            Main.Controls.Add(MainSection);
            Main.Controls.Add(Header);
            Main.Dock = DockStyle.Fill;
            Main.Location = new Point(201, 0);
            Main.Margin = new Padding(3, 4, 3, 4);
            Main.Name = "Main";
            Main.Size = new Size(1478, 947);
            Main.TabIndex = 1;
            // 
            // Header
            // 
            Header.ColumnCount = 2;
            Header.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Header.Controls.Add(label4, 1, 0);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.RowCount = 1;
            Header.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Header.Size = new Size(1478, 112);
            Header.TabIndex = 7;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 0);
            label4.Name = "label4";
            label4.Size = new Size(1452, 112);
            label4.TabIndex = 6;
            label4.Text = "Appointments";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // CancelAppointment
            // 
            CancelAppointment.Dock = DockStyle.Left;
            CancelAppointment.Location = new Point(0, 0);
            CancelAppointment.Margin = new Padding(3, 4, 3, 4);
            CancelAppointment.Name = "CancelAppointment";
            CancelAppointment.Size = new Size(86, 77);
            CancelAppointment.TabIndex = 5;
            CancelAppointment.Text = "Cancel";
            CancelAppointment.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Dock = DockStyle.Right;
            Delete.Location = new Point(578, 0);
            Delete.Margin = new Padding(3, 4, 3, 4);
            Delete.Name = "Delete";
            Delete.Size = new Size(129, 77);
            Delete.TabIndex = 4;
            Delete.Text = "delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // CancelAddition
            // 
            CancelAddition.Dock = DockStyle.Left;
            CancelAddition.Location = new Point(0, 0);
            CancelAddition.Margin = new Padding(3, 4, 3, 4);
            CancelAddition.Name = "CancelAddition";
            CancelAddition.Size = new Size(164, 77);
            CancelAddition.TabIndex = 3;
            CancelAddition.Text = "Cancel";
            CancelAddition.UseVisualStyleBackColor = true;
            // 
            // BookAppointment
            // 
            BookAppointment.Dock = DockStyle.Right;
            BookAppointment.Location = new Point(507, 0);
            BookAppointment.Margin = new Padding(3, 4, 3, 4);
            BookAppointment.Name = "BookAppointment";
            BookAppointment.Size = new Size(200, 77);
            BookAppointment.TabIndex = 2;
            BookAppointment.Text = "Book Appointment";
            BookAppointment.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(AppointmentsGrid);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 4);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(707, 738);
            panel4.TabIndex = 1;
            // 
            // AppointmentsGrid
            // 
            AppointmentsGrid.BackgroundColor = Color.White;
            AppointmentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AppointmentsGrid.Dock = DockStyle.Fill;
            AppointmentsGrid.Location = new Point(0, 34);
            AppointmentsGrid.Name = "AppointmentsGrid";
            AppointmentsGrid.RowHeadersWidth = 51;
            AppointmentsGrid.Size = new Size(707, 704);
            AppointmentsGrid.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(707, 34);
            panel6.TabIndex = 1;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(707, 34);
            label6.TabIndex = 0;
            label6.Text = "All appointments";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPatient);
            groupBox1.Controls.Add(cmbDoctor);
            groupBox1.Controls.Add(Reason);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(707, 738);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Appointment";
            // 
            // cmbPatient
            // 
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(21, 94);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(338, 28);
            cmbPatient.TabIndex = 10;
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(22, 185);
            cmbDoctor.Margin = new Padding(3, 4, 3, 4);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(337, 28);
            cmbDoctor.TabIndex = 9;
            // 
            // Reason
            // 
            Reason.Location = new Point(18, 401);
            Reason.Margin = new Padding(3, 4, 3, 4);
            Reason.Multiline = true;
            Reason.Name = "Reason";
            Reason.Size = new Size(340, 64);
            Reason.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "   dddd, dd MMMM yyyy  HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(21, 292);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(338, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 355);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 4;
            label5.Text = "Reason for visit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 248);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 149);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Doctor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 60);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Patient";
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
            SideBar.Size = new Size(199, 947);
            SideBar.TabIndex = 13;
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
            tableLayoutPanel1.Size = new Size(199, 835);
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
            Logout.Location = new Point(3, 784);
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
            Queue.Location = new Point(3, 440);
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
            Admissions.Location = new Point(3, 380);
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
            Appointments.Location = new Point(3, 317);
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
            Clinical.Location = new Point(3, 265);
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
            Reception.Location = new Point(3, 190);
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
            Doctors.Location = new Point(3, 131);
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
            Patients.Location = new Point(3, 72);
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
            Management.Location = new Point(3, 20);
            Management.Margin = new Padding(3, 20, 3, 20);
            Management.Name = "Management";
            Management.Size = new Size(193, 28);
            Management.TabIndex = 10;
            Management.Text = "Management";
            Management.TextAlign = ContentAlignment.MiddleCenter;
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
            Sidebar_Border.Size = new Size(2, 947);
            Sidebar_Border.TabIndex = 14;
            // 
            // MainSection
            // 
            MainSection.ColumnCount = 4;
            MainSection.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            MainSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainSection.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            MainSection.Controls.Add(NewAppointment, 1, 0);
            MainSection.Controls.Add(AllAppointments, 2, 0);
            MainSection.Dock = DockStyle.Fill;
            MainSection.Location = new Point(0, 112);
            MainSection.Name = "MainSection";
            MainSection.RowCount = 1;
            MainSection.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainSection.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MainSection.Size = new Size(1478, 835);
            MainSection.TabIndex = 8;
            // 
            // NewAppointment
            // 
            NewAppointment.ColumnCount = 1;
            NewAppointment.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            NewAppointment.Controls.Add(groupBox1, 0, 0);
            NewAppointment.Controls.Add(panel1, 0, 1);
            NewAppointment.Dock = DockStyle.Fill;
            NewAppointment.Location = new Point(23, 3);
            NewAppointment.Name = "NewAppointment";
            NewAppointment.RowCount = 2;
            NewAppointment.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            NewAppointment.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            NewAppointment.Size = new Size(713, 829);
            NewAppointment.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(BookAppointment);
            panel1.Controls.Add(CancelAddition);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 749);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 77);
            panel1.TabIndex = 9;
            // 
            // AllAppointments
            // 
            AllAppointments.ColumnCount = 1;
            AllAppointments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AllAppointments.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            AllAppointments.Controls.Add(panel2, 0, 1);
            AllAppointments.Controls.Add(panel4, 0, 0);
            AllAppointments.Dock = DockStyle.Fill;
            AllAppointments.Location = new Point(742, 3);
            AllAppointments.Name = "AllAppointments";
            AllAppointments.RowCount = 2;
            AllAppointments.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            AllAppointments.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            AllAppointments.Size = new Size(713, 829);
            AllAppointments.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(Delete);
            panel2.Controls.Add(CancelAppointment);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 749);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 77);
            panel2.TabIndex = 11;
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1679, 947);
            Controls.Add(Main);
            Controls.Add(Sidebar_Border);
            Controls.Add(SideBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Appointment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Appointment";
            WindowState = FormWindowState.Maximized;
            Load += Appointment_Load;
            Main.ResumeLayout(false);
            Header.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AppointmentsGrid).EndInit();
            panel6.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            SideBar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            MainSection.ResumeLayout(false);
            NewAppointment.ResumeLayout(false);
            panel1.ResumeLayout(false);
            AllAppointments.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel Main;
        private Panel panel4;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label4;
        private Button CancelAppointment;
        private Button Delete;
        private Button CancelAddition;
        private Button BookAppointment;
        private ComboBox cmbDoctor;
        private TextBox Reason;
        private Panel panel6;
        private DataGridView AppointmentsGrid;
        private Label label6;
        private ComboBox cmbPatient;
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
        private PictureBox Logo;
        private Panel panel13;
        private Panel Sidebar_Border;
        private TableLayoutPanel Header;
        private TableLayoutPanel MainSection;
        private TableLayoutPanel NewAppointment;
        private Panel panel1;
        private TableLayoutPanel AllAppointments;
        private Panel panel2;
    }
}