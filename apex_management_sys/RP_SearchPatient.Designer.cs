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
            PatientGrid = new DataGridView();
            Search = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtSearch = new TextBox();
            label2 = new Label();
            ButtonControls = new Panel();
            btnReset = new Button();
            btnSave = new Button();
            btnAddPatient = new Button();
            Patient = new Panel();
            panel4 = new Panel();
            lblCount = new Label();
            lblPatient = new Label();
            label8 = new Label();
            Sidebar_Border = new Panel();
            MainPanel = new Panel();
            Section = new TableLayoutPanel();
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
            ((System.ComponentModel.ISupportInitialize)PatientGrid).BeginInit();
            Search.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ButtonControls.SuspendLayout();
            Patient.SuspendLayout();
            panel4.SuspendLayout();
            MainPanel.SuspendLayout();
            Section.SuspendLayout();
            SideBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 46);
            label1.TabIndex = 0;
            label1.Text = "Patients";
            // 
            // lbl2IDNo
            // 
            lbl2IDNo.AutoSize = true;
            lbl2IDNo.Dock = DockStyle.Fill;
            lbl2IDNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2IDNo.ForeColor = Color.Blue;
            lbl2IDNo.Location = new Point(2, 50);
            lbl2IDNo.Margin = new Padding(2, 0, 2, 0);
            lbl2IDNo.Name = "lbl2IDNo";
            lbl2IDNo.Size = new Size(1189, 50);
            lbl2IDNo.TabIndex = 1;
            lbl2IDNo.Text = "Deshboard / Patients";
            lbl2IDNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PatientGrid
            // 
            PatientGrid.AllowUserToOrderColumns = true;
            PatientGrid.BackgroundColor = Color.White;
            PatientGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientGrid.Dock = DockStyle.Fill;
            PatientGrid.Location = new Point(0, 75);
            PatientGrid.Margin = new Padding(2, 3, 2, 3);
            PatientGrid.Name = "PatientGrid";
            PatientGrid.RowHeadersWidth = 62;
            PatientGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PatientGrid.Size = new Size(1185, 329);
            PatientGrid.TabIndex = 15;
            // 
            // Search
            // 
            Search.BorderStyle = BorderStyle.FixedSingle;
            Search.Controls.Add(tableLayoutPanel2);
            Search.Dock = DockStyle.Fill;
            Search.Location = new Point(3, 169);
            Search.Margin = new Padding(3, 4, 3, 4);
            Search.Name = "Search";
            Search.Size = new Size(1187, 95);
            Search.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Controls.Add(txtSearch, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(ButtonControls, 3, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1185, 93);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(8, 50);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID or Name";
            txtSearch.Size = new Size(348, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 46);
            label2.TabIndex = 0;
            label2.Text = "Search";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ButtonControls
            // 
            ButtonControls.Controls.Add(btnReset);
            ButtonControls.Controls.Add(btnSave);
            ButtonControls.Dock = DockStyle.Fill;
            ButtonControls.Location = new Point(775, 49);
            ButtonControls.Name = "ButtonControls";
            ButtonControls.Size = new Size(407, 41);
            ButtonControls.TabIndex = 19;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Yellow;
            btnReset.Dock = DockStyle.Left;
            btnReset.Location = new Point(0, 0);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(180, 41);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(45, 140, 120);
            btnSave.Dock = DockStyle.Right;
            btnSave.Location = new Point(227, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 41);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = Color.FromArgb(11, 61, 92);
            btnAddPatient.Dock = DockStyle.Right;
            btnAddPatient.ForeColor = SystemColors.ControlLightLight;
            btnAddPatient.Location = new Point(1014, 104);
            btnAddPatient.Margin = new Padding(3, 4, 3, 4);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(176, 57);
            btnAddPatient.TabIndex = 20;
            btnAddPatient.Text = "Add patient";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // Patient
            // 
            Patient.BorderStyle = BorderStyle.FixedSingle;
            Patient.Controls.Add(PatientGrid);
            Patient.Controls.Add(panel4);
            Patient.Dock = DockStyle.Fill;
            Patient.Location = new Point(3, 272);
            Patient.Margin = new Padding(3, 4, 3, 4);
            Patient.Name = "Patient";
            Patient.Size = new Size(1187, 406);
            Patient.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblCount);
            panel4.Controls.Add(lblPatient);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1185, 75);
            panel4.TabIndex = 0;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(197, 23);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(68, 20);
            lblCount.TabIndex = 2;
            lblCount.Text = "(12 total)";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatient.Location = new Point(81, 16);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(119, 28);
            lblPatient.TabIndex = 1;
            lblPatient.Text = "Patient List";
            lblPatient.Click += label9_Click;
            // 
            // label8
            // 
            label8.Image = Properties.Resources.users_avatar;
            label8.Location = new Point(21, 16);
            label8.Name = "label8";
            label8.Size = new Size(54, 45);
            label8.TabIndex = 0;
            // 
            // Sidebar_Border
            // 
            Sidebar_Border.BackColor = Color.FromArgb(180, 200, 215);
            Sidebar_Border.Dock = DockStyle.Left;
            Sidebar_Border.Location = new Point(199, 0);
            Sidebar_Border.Name = "Sidebar_Border";
            Sidebar_Border.Size = new Size(2, 749);
            Sidebar_Border.TabIndex = 24;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(245, 248, 251);
            MainPanel.Controls.Add(Section);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(201, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1263, 749);
            MainPanel.TabIndex = 25;
            // 
            // Section
            // 
            Section.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Section.BackColor = Color.White;
            Section.ColumnCount = 1;
            Section.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Section.Controls.Add(Patient, 0, 4);
            Section.Controls.Add(Search, 0, 3);
            Section.Controls.Add(btnAddPatient, 0, 2);
            Section.Controls.Add(lbl2IDNo, 0, 1);
            Section.Controls.Add(label1, 0, 0);
            Section.Location = new Point(58, 67);
            Section.Name = "Section";
            Section.RowCount = 5;
            Section.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Section.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Section.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            Section.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Section.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            Section.Size = new Size(1193, 682);
            Section.TabIndex = 22;
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
            SideBar.Size = new Size(199, 749);
            SideBar.TabIndex = 26;
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
            tableLayoutPanel1.Size = new Size(199, 637);
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
            btnLogout.Location = new Point(3, 586);
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
            // RP_SearchPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 749);
            Controls.Add(MainPanel);
            Controls.Add(Sidebar_Border);
            Controls.Add(SideBar);
            Margin = new Padding(2, 3, 2, 3);
            Name = "RP_SearchPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Returning Patient";
            WindowState = FormWindowState.Maximized;
            Load += RP_SearchPatient_Load;
            ((System.ComponentModel.ISupportInitialize)PatientGrid).EndInit();
            Search.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ButtonControls.ResumeLayout(false);
            Patient.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            MainPanel.ResumeLayout(false);
            Section.ResumeLayout(false);
            Section.PerformLayout();
            SideBar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Label label1;
        private Label lbl2IDNo;
        private DataGridView PatientGrid;
        private Panel Search;
        private TextBox txtSearch;
        private Label label2;
        private Button btnReset;
        private Button btnAddPatient;
        private Panel Patient;
        private Panel panel4;
        private Label lblPatient;
        private Label label8;
        private Label lblCount;
        private Panel Sidebar_Border;
        private Panel MainPanel;
        private TableLayoutPanel Section;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnSave;
        private Panel ButtonControls;
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