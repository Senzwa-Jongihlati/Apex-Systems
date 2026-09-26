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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            MainPanel = new Panel();
            MainSection = new TableLayoutPanel();
            NewAppointment = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            txtPatient = new TextBox();
            cmbDoctor = new ComboBox();
            txtReason = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            BookAppointment = new Button();
            CancelAddition = new Button();
            AllAppointments = new TableLayoutPanel();
            panel2 = new Panel();
            Save = new Button();
            panel4 = new Panel();
            AppointmentsGrid = new DataGridView();
            panel6 = new Panel();
            label6 = new Label();
            Header = new TableLayoutPanel();
            label4 = new Label();
            Sidebar_Border = new Panel();
            SideBar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDashboard = new Button();
            Main = new Label();
            btnLogout = new Button();
            btnQueue = new Button();
            btnAppointments = new Button();
            Clinical = new Label();
            btnEmployees = new Button();
            btnDoctors = new Button();
            btnPatients = new Button();
            Management = new Label();
            Logo = new PictureBox();
            panel13 = new Panel();
            MainPanel.SuspendLayout();
            MainSection.SuspendLayout();
            NewAppointment.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            AllAppointments.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AppointmentsGrid).BeginInit();
            panel6.SuspendLayout();
            Header.SuspendLayout();
            SideBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(245, 248, 251);
            MainPanel.Controls.Add(MainSection);
            MainPanel.Controls.Add(Header);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(201, 0);
            MainPanel.Margin = new Padding(3, 4, 3, 4);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1478, 947);
            MainPanel.TabIndex = 1;
            // 
            // MainSection
            // 
            MainSection.ColumnCount = 5;
            MainSection.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            MainSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainSection.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            MainSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainSection.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            MainSection.Controls.Add(NewAppointment, 3, 0);
            MainSection.Controls.Add(AllAppointments, 1, 0);
            MainSection.Dock = DockStyle.Fill;
            MainSection.Location = new Point(0, 112);
            MainSection.Name = "MainSection";
            MainSection.RowCount = 1;
            MainSection.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainSection.Size = new Size(1478, 835);
            MainSection.TabIndex = 8;
            // 
            // NewAppointment
            // 
            NewAppointment.ColumnCount = 1;
            NewAppointment.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            NewAppointment.Controls.Add(groupBox1, 0, 0);
            NewAppointment.Controls.Add(panel1, 0, 2);
            NewAppointment.Dock = DockStyle.Fill;
            NewAppointment.Location = new Point(747, 3);
            NewAppointment.Name = "NewAppointment";
            NewAppointment.RowCount = 3;
            NewAppointment.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            NewAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            NewAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            NewAppointment.Size = new Size(708, 829);
            NewAppointment.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtPatient);
            groupBox1.Controls.Add(cmbDoctor);
            groupBox1.Controls.Add(txtReason);
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
            groupBox1.Size = new Size(702, 746);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Appointment";
            // 
            // txtPatient
            // 
            txtPatient.Location = new Point(18, 89);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(377, 27);
            txtPatient.TabIndex = 10;
            // 
            // cmbDoctor
            // 
            cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(22, 185);
            cmbDoctor.Margin = new Padding(3, 4, 3, 4);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(373, 28);
            cmbDoctor.TabIndex = 9;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(18, 401);
            txtReason.Margin = new Padding(3, 4, 3, 4);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(669, 160);
            txtReason.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "   dddd, dd MMMM yyyy  HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(21, 292);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(382, 27);
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
            // panel1
            // 
            panel1.Controls.Add(BookAppointment);
            panel1.Controls.Add(CancelAddition);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 762);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 64);
            panel1.TabIndex = 9;
            // 
            // BookAppointment
            // 
            BookAppointment.BackColor = Color.FromArgb(52, 120, 180);
            BookAppointment.Dock = DockStyle.Right;
            BookAppointment.Location = new Point(502, 0);
            BookAppointment.Margin = new Padding(3, 4, 3, 4);
            BookAppointment.Name = "BookAppointment";
            BookAppointment.Size = new Size(200, 64);
            BookAppointment.TabIndex = 2;
            BookAppointment.Text = "Book Appointment";
            BookAppointment.UseVisualStyleBackColor = false;
            BookAppointment.Click += BookAppointment_Click;
            // 
            // CancelAddition
            // 
            CancelAddition.BackColor = Color.FromArgb(120, 130, 140);
            CancelAddition.Dock = DockStyle.Left;
            CancelAddition.Location = new Point(0, 0);
            CancelAddition.Margin = new Padding(3, 4, 3, 4);
            CancelAddition.Name = "CancelAddition";
            CancelAddition.Size = new Size(164, 64);
            CancelAddition.TabIndex = 3;
            CancelAddition.Text = "Cancel";
            CancelAddition.UseVisualStyleBackColor = false;
            CancelAddition.Click += CancelAddition_Click;
            // 
            // AllAppointments
            // 
            AllAppointments.ColumnCount = 1;
            AllAppointments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AllAppointments.Controls.Add(panel2, 0, 2);
            AllAppointments.Controls.Add(panel4, 0, 0);
            AllAppointments.Dock = DockStyle.Fill;
            AllAppointments.Location = new Point(23, 3);
            AllAppointments.Name = "AllAppointments";
            AllAppointments.RowCount = 3;
            AllAppointments.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            AllAppointments.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            AllAppointments.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            AllAppointments.Size = new Size(708, 829);
            AllAppointments.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(Save);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 762);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 64);
            panel2.TabIndex = 11;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(45, 140, 120);
            Save.Dock = DockStyle.Right;
            Save.Location = new Point(570, 0);
            Save.Margin = new Padding(3, 4, 3, 4);
            Save.Name = "Save";
            Save.Size = new Size(132, 64);
            Save.TabIndex = 5;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
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
            panel4.Size = new Size(702, 746);
            panel4.TabIndex = 1;
            // 
            // AppointmentsGrid
            // 
            AppointmentsGrid.AllowUserToAddRows = false;
            AppointmentsGrid.AllowUserToDeleteRows = false;
            AppointmentsGrid.AllowUserToResizeColumns = false;
            AppointmentsGrid.AllowUserToResizeRows = false;
            AppointmentsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AppointmentsGrid.BackgroundColor = Color.White;
            AppointmentsGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 235, 245);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(180, 205, 225);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AppointmentsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AppointmentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AppointmentsGrid.Dock = DockStyle.Fill;
            AppointmentsGrid.EnableHeadersVisualStyles = false;
            AppointmentsGrid.Location = new Point(0, 34);
            AppointmentsGrid.MultiSelect = false;
            AppointmentsGrid.Name = "AppointmentsGrid";
            AppointmentsGrid.ReadOnly = true;
            AppointmentsGrid.RowHeadersVisible = false;
            AppointmentsGrid.RowHeadersWidth = 51;
            AppointmentsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentsGrid.Size = new Size(702, 712);
            AppointmentsGrid.TabIndex = 0;
            AppointmentsGrid.CellDoubleClick += AppointmentsGrid_CellDoubleClick;
            // 
            // panel6
            // 
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(702, 34);
            panel6.TabIndex = 1;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(702, 34);
            label6.TabIndex = 0;
            label6.Text = "All appointments";
            label6.TextAlign = ContentAlignment.MiddleLeft;
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
            // Sidebar_Border
            // 
            Sidebar_Border.BackColor = Color.FromArgb(180, 200, 215);
            Sidebar_Border.Dock = DockStyle.Left;
            Sidebar_Border.Location = new Point(199, 0);
            Sidebar_Border.Name = "Sidebar_Border";
            Sidebar_Border.Size = new Size(2, 947);
            Sidebar_Border.TabIndex = 16;
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
            tableLayoutPanel1.Controls.Add(btnDashboard, 0, 0);
            tableLayoutPanel1.Controls.Add(Main, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLogout, 0, 10);
            tableLayoutPanel1.Controls.Add(btnQueue, 0, 9);
            tableLayoutPanel1.Controls.Add(btnAppointments, 0, 7);
            tableLayoutPanel1.Controls.Add(Clinical, 0, 6);
            tableLayoutPanel1.Controls.Add(btnEmployees, 0, 5);
            tableLayoutPanel1.Controls.Add(btnDoctors, 0, 4);
            tableLayoutPanel1.Controls.Add(btnPatients, 0, 3);
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
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 72);
            btnDashboard.Margin = new Padding(3, 4, 0, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(196, 51);
            btnDashboard.TabIndex = 20;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
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
            Main.TabIndex = 19;
            Main.Text = "Main";
            Main.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(222, 235, 245);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, 784);
            btnLogout.Margin = new Padding(3, 4, 0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(196, 51);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnQueue
            // 
            btnQueue.BackColor = Color.FromArgb(222, 235, 245);
            btnQueue.Cursor = Cursors.Hand;
            btnQueue.Dock = DockStyle.Top;
            btnQueue.FlatAppearance.BorderSize = 0;
            btnQueue.FlatStyle = FlatStyle.Flat;
            btnQueue.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnQueue.Image = (Image)resources.GetObject("btnQueue.Image");
            btnQueue.ImageAlign = ContentAlignment.MiddleLeft;
            btnQueue.Location = new Point(3, 507);
            btnQueue.Margin = new Padding(3, 4, 0, 4);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(196, 52);
            btnQueue.TabIndex = 17;
            btnQueue.Text = "Queue";
            btnQueue.UseVisualStyleBackColor = false;
            btnQueue.Click += btnQueue_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = Color.FromArgb(222, 235, 245);
            btnAppointments.Cursor = Cursors.Hand;
            btnAppointments.Dock = DockStyle.Top;
            btnAppointments.FlatAppearance.BorderSize = 0;
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnAppointments.Image = (Image)resources.GetObject("btnAppointments.Image");
            btnAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointments.Location = new Point(3, 444);
            btnAppointments.Margin = new Padding(3, 4, 0, 4);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(196, 55);
            btnAppointments.TabIndex = 15;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btnAppointments_Click;
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
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(222, 235, 245);
            btnEmployees.Cursor = Cursors.Hand;
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnEmployees.Image = (Image)resources.GetObject("btnEmployees.Image");
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(3, 317);
            btnEmployees.Margin = new Padding(3, 4, 0, 4);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(196, 51);
            btnEmployees.TabIndex = 13;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.FromArgb(222, 235, 245);
            btnDoctors.Cursor = Cursors.Hand;
            btnDoctors.Dock = DockStyle.Top;
            btnDoctors.FlatAppearance.BorderSize = 0;
            btnDoctors.FlatStyle = FlatStyle.Flat;
            btnDoctors.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnDoctors.Image = (Image)resources.GetObject("btnDoctors.Image");
            btnDoctors.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoctors.Location = new Point(3, 258);
            btnDoctors.Margin = new Padding(3, 4, 0, 4);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(196, 51);
            btnDoctors.TabIndex = 12;
            btnDoctors.Text = "Doctors";
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnPatients
            // 
            btnPatients.BackColor = Color.FromArgb(222, 235, 245);
            btnPatients.Cursor = Cursors.Hand;
            btnPatients.Dock = DockStyle.Top;
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnPatients.Image = (Image)resources.GetObject("btnPatients.Image");
            btnPatients.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatients.Location = new Point(3, 199);
            btnPatients.Margin = new Padding(3, 4, 0, 4);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(196, 51);
            btnPatients.TabIndex = 11;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Click += btnPatients_Click;
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
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1679, 947);
            Controls.Add(MainPanel);
            Controls.Add(Sidebar_Border);
            Controls.Add(SideBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Appointment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Appointment";
            WindowState = FormWindowState.Maximized;
            Load += Appointment_Load;
            MainPanel.ResumeLayout(false);
            MainSection.ResumeLayout(false);
            NewAppointment.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            AllAppointments.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AppointmentsGrid).EndInit();
            panel6.ResumeLayout(false);
            Header.ResumeLayout(false);
            SideBar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel MainPanel;
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
        private Button Save;
        private Button CancelAddition;
        private Button BookAppointment;
        private ComboBox cmbDoctor;
        private TextBox txtReason;
        private Panel panel6;
        private DataGridView AppointmentsGrid;
        private Label label6;
        private TableLayoutPanel Header;
        private TableLayoutPanel MainSection;
        private TableLayoutPanel NewAppointment;
        private Panel panel1;
        private TableLayoutPanel AllAppointments;
        private Panel panel2;
        private TextBox txtPatient;
        private Panel Sidebar_Border;
        private Panel SideBar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDashboard;
        private Label Main;
        private Button btnLogout;
        private Button btnQueue;
        private Button btnAppointments;
        private Label Clinical;
        private Button btnEmployees;
        private Button btnDoctors;
        private Button btnPatients;
        private Label Management;
        private PictureBox Logo;
        private Panel panel13;
    }
}