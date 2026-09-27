namespace apex_management_sys
{
    partial class DR_Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DR_Doctor));
            MainPanel = new Panel();
            ContainerMain = new TableLayoutPanel();
            TodaysAppointments = new Panel();
            dataGridView1 = new DataGridView();
            time = new DataGridViewTextBoxColumn();
            Patient = new DataGridViewTextBoxColumn();
            Reason = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            panel10 = new Panel();
            label15 = new Label();
            pictureBox4 = new PictureBox();
            groupBox2 = new GroupBox();
            PatientQueue = new TableLayoutPanel();
            panel8 = new Panel();
            button1 = new Button();
            label14 = new Label();
            label13 = new Label();
            label10 = new Label();
            btnSkip = new Button();
            LivePanels = new TableLayoutPanel();
            panel7 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            TodaysApp = new Label();
            label12 = new Label();
            label11 = new Label();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            lblWelcome = new Label();
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
            ContainerMain.SuspendLayout();
            TodaysAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            PatientQueue.SuspendLayout();
            panel8.SuspendLayout();
            LivePanels.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            SideBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(ContainerMain);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainPanel.Location = new Point(201, 0);
            MainPanel.Margin = new Padding(3, 4, 3, 4);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1133, 783);
            MainPanel.TabIndex = 1;
            // 
            // ContainerMain
            // 
            ContainerMain.ColumnCount = 3;
            ContainerMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            ContainerMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ContainerMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            ContainerMain.Controls.Add(TodaysAppointments, 1, 3);
            ContainerMain.Controls.Add(groupBox2, 1, 2);
            ContainerMain.Controls.Add(LivePanels, 1, 1);
            ContainerMain.Controls.Add(panel4, 1, 0);
            ContainerMain.Dock = DockStyle.Fill;
            ContainerMain.Location = new Point(0, 0);
            ContainerMain.Name = "ContainerMain";
            ContainerMain.RowCount = 5;
            ContainerMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            ContainerMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            ContainerMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            ContainerMain.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            ContainerMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ContainerMain.Size = new Size(1133, 783);
            ContainerMain.TabIndex = 10;
            // 
            // TodaysAppointments
            // 
            TodaysAppointments.BackColor = Color.White;
            TodaysAppointments.Controls.Add(dataGridView1);
            TodaysAppointments.Controls.Add(panel10);
            TodaysAppointments.Dock = DockStyle.Fill;
            TodaysAppointments.Location = new Point(83, 466);
            TodaysAppointments.Margin = new Padding(3, 4, 3, 4);
            TodaysAppointments.Name = "TodaysAppointments";
            TodaysAppointments.Size = new Size(967, 292);
            TodaysAppointments.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { time, Patient, Reason, status });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(967, 228);
            dataGridView1.TabIndex = 1;
            // 
            // time
            // 
            time.HeaderText = "Time";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.Width = 125;
            // 
            // Patient
            // 
            Patient.HeaderText = "Patient";
            Patient.MinimumWidth = 6;
            Patient.Name = "Patient";
            Patient.Width = 125;
            // 
            // Reason
            // 
            Reason.HeaderText = "Reason";
            Reason.MinimumWidth = 6;
            Reason.Name = "Reason";
            Reason.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 125;
            // 
            // panel10
            // 
            panel10.Controls.Add(label15);
            panel10.Controls.Add(pictureBox4);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(967, 64);
            panel10.TabIndex = 0;
            // 
            // label15
            // 
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(66, 0);
            label15.Name = "label15";
            label15.Size = new Size(901, 64);
            label15.TabIndex = 1;
            label15.Text = "Today's appointments";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(PatientQueue);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(83, 304);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(967, 154);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "patient queue";
            // 
            // PatientQueue
            // 
            PatientQueue.ColumnCount = 1;
            PatientQueue.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PatientQueue.Controls.Add(panel8, 0, 0);
            PatientQueue.Controls.Add(btnSkip, 0, 1);
            PatientQueue.Dock = DockStyle.Fill;
            PatientQueue.Location = new Point(3, 24);
            PatientQueue.Name = "PatientQueue";
            PatientQueue.RowCount = 2;
            PatientQueue.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            PatientQueue.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            PatientQueue.Size = new Size(961, 126);
            PatientQueue.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ButtonHighlight;
            panel8.Controls.Add(button1);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label10);
            panel8.Dock = DockStyle.Fill;
            panel8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel8.Location = new Point(3, 4);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(955, 80);
            panel8.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(11, 61, 92);
            button1.Dock = DockStyle.Right;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(785, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(170, 80);
            button1.TabIndex = 3;
            button1.Text = "OPEN Record";
            button1.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(110, 63);
            label14.Name = "label14";
            label14.Size = new Size(95, 23);
            label14.TabIndex = 2;
            label14.Text = "Emergency";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 63);
            label13.Name = "label13";
            label13.Size = new Size(82, 23);
            label13.TabIndex = 1;
            label13.Text = "T. Mkhize";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 15);
            label10.Name = "label10";
            label10.Size = new Size(193, 23);
            label10.TabIndex = 0;
            label10.Text = "Up next · queue no. 014";
            // 
            // btnSkip
            // 
            btnSkip.Dock = DockStyle.Left;
            btnSkip.Location = new Point(3, 91);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(177, 32);
            btnSkip.TabIndex = 7;
            btnSkip.Text = "Skip Patient";
            btnSkip.UseVisualStyleBackColor = true;
            // 
            // LivePanels
            // 
            LivePanels.ColumnCount = 3;
            LivePanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LivePanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LivePanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LivePanels.Controls.Add(panel7, 1, 0);
            LivePanels.Controls.Add(panel5, 2, 0);
            LivePanels.Controls.Add(panel6, 0, 0);
            LivePanels.Dock = DockStyle.Fill;
            LivePanels.Location = new Point(83, 103);
            LivePanels.Name = "LivePanels";
            LivePanels.RowCount = 1;
            LivePanels.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LivePanels.Size = new Size(967, 194);
            LivePanels.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(pictureBox2);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(325, 4);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(316, 186);
            panel7.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(119, 83);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 2;
            label9.Text = "Admissions";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(119, 35);
            label8.Name = "label8";
            label8.Size = new Size(28, 32);
            label8.TabIndex = 1;
            label8.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 39);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(TodaysApp);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(647, 4);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(317, 186);
            panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // TodaysApp
            // 
            TodaysApp.AutoSize = true;
            TodaysApp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TodaysApp.Location = new Point(123, 24);
            TodaysApp.Name = "TodaysApp";
            TodaysApp.Size = new Size(33, 37);
            TodaysApp.TabIndex = 6;
            TodaysApp.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(107, 85);
            label12.Name = "label12";
            label12.Size = new Size(110, 20);
            label12.TabIndex = 5;
            label12.Text = "Appointments";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(107, 65);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 4;
            label11.Text = "Today's ";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 4);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(316, 186);
            panel6.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(27, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(103, 27);
            label6.Name = "label6";
            label6.Size = new Size(33, 37);
            label6.TabIndex = 7;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(103, 81);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 6;
            label7.Text = "Waiting in queue";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(lblWelcome);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(83, 4);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(967, 92);
            panel4.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.White;
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(967, 92);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome back Doctor";
            lblWelcome.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Sidebar_Border
            // 
            Sidebar_Border.BackColor = Color.FromArgb(180, 200, 215);
            Sidebar_Border.Dock = DockStyle.Left;
            Sidebar_Border.Location = new Point(199, 0);
            Sidebar_Border.Name = "Sidebar_Border";
            Sidebar_Border.Size = new Size(2, 783);
            Sidebar_Border.TabIndex = 14;
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
            SideBar.Size = new Size(199, 783);
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
            tableLayoutPanel1.Size = new Size(199, 671);
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
            btnLogout.Location = new Point(3, 620);
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
            // DR_Doctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 251);
            ClientSize = new Size(1334, 783);
            Controls.Add(MainPanel);
            Controls.Add(Sidebar_Border);
            Controls.Add(SideBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DR_Doctor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Doctor";
            WindowState = FormWindowState.Maximized;
            Load += DR_Doctor_Load;
            MainPanel.ResumeLayout(false);
            ContainerMain.ResumeLayout(false);
            TodaysAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            PatientQueue.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            LivePanels.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            SideBar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel MainPanel;
        private Label lblWelcome;
        private Panel panel4;
        private Panel TodaysAppointments;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Label TodaysApp;
        private Label label12;
        private Label label11;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label9;
        private Label label8;
        private GroupBox groupBox2;
        private Panel panel10;
        private PictureBox pictureBox4;
        private Label label15;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn Patient;
        private DataGridViewTextBoxColumn Reason;
        private DataGridViewTextBoxColumn status;
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
        private TableLayoutPanel ContainerMain;
        private TableLayoutPanel LivePanels;
        private TableLayoutPanel PatientQueue;
        private Panel panel8;
        private Button button1;
        private Label label14;
        private Label label13;
        private Label label10;
        private Button btnSkip;
    }
}