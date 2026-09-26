namespace apex_management_sys
{
    partial class RP_Queue: Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP_Queue));
            lblWelcome = new Label();
            label3 = new Label();
            label5 = new Label();
            ServedGrid = new DataGridView();
            Components = new Panel();
            Waiting = new Panel();
            WaitingGrid = new DataGridView();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            Served = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            Sidebar_Border = new Panel();
            MainSection = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)ServedGrid).BeginInit();
            Components.SuspendLayout();
            Waiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WaitingGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Served.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainSection.SuspendLayout();
            SideBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(112, 22);
            lblWelcome.Margin = new Padding(2, 0, 2, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(492, 57);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Welcome To The Queue";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(74, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(1078, 76);
            label3.TabIndex = 9;
            label3.Text = "Waiting";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(64, 0);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(1088, 69);
            label5.TabIndex = 11;
            label5.Text = "Served";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ServedGrid
            // 
            ServedGrid.AllowUserToAddRows = false;
            ServedGrid.AllowUserToDeleteRows = false;
            ServedGrid.BackgroundColor = Color.White;
            ServedGrid.BorderStyle = BorderStyle.None;
            ServedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServedGrid.Dock = DockStyle.Fill;
            ServedGrid.Location = new Point(0, 69);
            ServedGrid.Margin = new Padding(2, 3, 2, 3);
            ServedGrid.Name = "ServedGrid";
            ServedGrid.RowHeadersVisible = false;
            ServedGrid.RowHeadersWidth = 62;
            ServedGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ServedGrid.Size = new Size(1152, 286);
            ServedGrid.TabIndex = 12;
            // 
            // Components
            // 
            Components.BackColor = Color.FromArgb(245, 248, 251);
            Components.BackgroundImageLayout = ImageLayout.Stretch;
            Components.Controls.Add(Waiting);
            Components.Controls.Add(Served);
            Components.Controls.Add(lblWelcome);
            Components.Dock = DockStyle.Fill;
            Components.Location = new Point(0, 0);
            Components.Name = "Components";
            Components.Size = new Size(1276, 1001);
            Components.TabIndex = 0;
            // 
            // Waiting
            // 
            Waiting.Controls.Add(WaitingGrid);
            Waiting.Controls.Add(panel1);
            Waiting.Location = new Point(94, 132);
            Waiting.Name = "Waiting";
            Waiting.Size = new Size(1152, 389);
            Waiting.TabIndex = 15;
            // 
            // WaitingGrid
            // 
            WaitingGrid.AllowUserToAddRows = false;
            WaitingGrid.AllowUserToDeleteRows = false;
            WaitingGrid.BackgroundColor = Color.White;
            WaitingGrid.BorderStyle = BorderStyle.None;
            WaitingGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WaitingGrid.Dock = DockStyle.Fill;
            WaitingGrid.Location = new Point(0, 76);
            WaitingGrid.Margin = new Padding(2, 3, 2, 3);
            WaitingGrid.MultiSelect = false;
            WaitingGrid.Name = "WaitingGrid";
            WaitingGrid.ReadOnly = true;
            WaitingGrid.RowHeadersVisible = false;
            WaitingGrid.RowHeadersWidth = 62;
            WaitingGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WaitingGrid.Size = new Size(1152, 313);
            WaitingGrid.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 76);
            panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Served
            // 
            Served.Controls.Add(ServedGrid);
            Served.Controls.Add(panel2);
            Served.Location = new Point(94, 580);
            Served.Name = "Served";
            Served.Size = new Size(1152, 355);
            Served.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1152, 69);
            panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Sidebar_Border
            // 
            Sidebar_Border.BackColor = Color.FromArgb(180, 200, 215);
            Sidebar_Border.Dock = DockStyle.Left;
            Sidebar_Border.Location = new Point(199, 0);
            Sidebar_Border.Name = "Sidebar_Border";
            Sidebar_Border.Size = new Size(2, 1001);
            Sidebar_Border.TabIndex = 17;
            // 
            // MainSection
            // 
            MainSection.Controls.Add(Components);
            MainSection.Dock = DockStyle.Fill;
            MainSection.Location = new Point(201, 0);
            MainSection.Name = "MainSection";
            MainSection.Size = new Size(1276, 1001);
            MainSection.TabIndex = 18;
            MainSection.Click += MainSection_Click;
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
            SideBar.Size = new Size(199, 1001);
            SideBar.TabIndex = 19;
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
            tableLayoutPanel1.Size = new Size(199, 889);
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
            btnLogout.Location = new Point(3, 838);
            btnLogout.Margin = new Padding(3, 4, 0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(196, 51);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "log out";
            btnLogout.UseVisualStyleBackColor = false;
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
            // RP_Queue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 1001);
            Controls.Add(MainSection);
            Controls.Add(Sidebar_Border);
            Controls.Add(SideBar);
            Margin = new Padding(2, 3, 2, 3);
            Name = "RP_Queue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Queue";
            WindowState = FormWindowState.Maximized;
            Load += RP_Queue_Load;
            ((System.ComponentModel.ISupportInitialize)ServedGrid).EndInit();
            Components.ResumeLayout(false);
            Components.PerformLayout();
            Waiting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WaitingGrid).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Served.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainSection.ResumeLayout(false);
            SideBar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);

            btnDashboard.Click += btnDashboard_Click;
            btnPatients.Click += btnPatients_Click;
            btnDoctors.Click += btnDoctors_Click;
            btnEmployees.Click += btnEmployees_Click;
            btnAppointments.Click += btnAppointments_Click;
            btnQueue.Click += btnQueue_Click;
            btnLogout.Click += btnLogout_Click;
        }

        #endregion
        private Label lblWelcome;
        private Label label3;
        private Label label5;
        private DataGridView ServedGrid;
        private Panel Components;
        private DataGridView WaitingGrid;
        private Panel Sidebar_Border;
        private Panel MainSection;
        private Panel Served;
        private Panel Waiting;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
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