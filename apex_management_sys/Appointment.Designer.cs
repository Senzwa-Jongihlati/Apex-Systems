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
            panel1 = new Panel();
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
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(222, 235, 245);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(Logo);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 726);
            panel1.TabIndex = 0;
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
            tableLayoutPanel1.Location = new Point(0, 84);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(200, 642);
            tableLayoutPanel1.TabIndex = 7;
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
            Logout.Location = new Point(3, 604);
            Logout.Margin = new Padding(3, 3, 0, 0);
            Logout.Name = "Logout";
            Logout.Size = new Size(197, 38);
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
            Queue.Location = new Point(3, 329);
            Queue.Margin = new Padding(3, 3, 0, 3);
            Queue.Name = "Queue";
            Queue.Size = new Size(197, 39);
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
            Admissions.Location = new Point(3, 284);
            Admissions.Margin = new Padding(3, 3, 0, 3);
            Admissions.Name = "Admissions";
            Admissions.Size = new Size(197, 39);
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
            Appointments.Location = new Point(3, 237);
            Appointments.Margin = new Padding(3, 3, 0, 3);
            Appointments.Name = "Appointments";
            Appointments.Size = new Size(197, 41);
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
            Clinical.Location = new Point(3, 198);
            Clinical.Margin = new Padding(3, 15, 3, 15);
            Clinical.Name = "Clinical";
            Clinical.Size = new Size(194, 21);
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
            Reception.Location = new Point(3, 142);
            Reception.Margin = new Padding(3, 3, 0, 3);
            Reception.Name = "Reception";
            Reception.Size = new Size(197, 38);
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
            Doctors.Location = new Point(3, 98);
            Doctors.Margin = new Padding(3, 3, 0, 3);
            Doctors.Name = "Doctors";
            Doctors.Size = new Size(197, 38);
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
            Patients.Location = new Point(3, 54);
            Patients.Margin = new Padding(3, 3, 0, 3);
            Patients.Name = "Patients";
            Patients.Size = new Size(197, 38);
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
            Management.Location = new Point(3, 15);
            Management.Margin = new Padding(3, 15, 3, 15);
            Management.Name = "Management";
            Management.Size = new Size(194, 21);
            Management.TabIndex = 10;
            Management.Text = "Management";
            Management.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            Logo.Dock = DockStyle.Top;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(200, 84);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 6;
            Logo.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(207, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(837, 656);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(25, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 446);
            panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 413);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Appointment";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(groupBox2);
            panel4.Location = new Point(441, 84);
            panel4.Name = "panel4";
            panel4.Size = new Size(385, 446);
            panel4.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(13, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 407);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "All Appointments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 45);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 112);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Doctor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 186);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 266);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 4;
            label5.Text = "Reason for visit:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 63);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 32);
            textBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(18, 219);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 301);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(298, 49);
            textBox3.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(19, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 23);
            comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(236, 536);
            button1.Name = "button1";
            button1.Size = new Size(175, 35);
            button1.TabIndex = 2;
            button1.Text = "Book Appointment";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(155, 536);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(721, 542);
            button3.Name = "button3";
            button3.Size = new Size(113, 35);
            button3.TabIndex = 4;
            button3.Text = "delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(222, 235, 245);
            panel5.Location = new Point(207, 663);
            panel5.Name = "panel5";
            panel5.Size = new Size(834, 64);
            panel5.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(640, 542);
            button4.Name = "button4";
            button4.Size = new Size(75, 35);
            button4.TabIndex = 5;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 22);
            label4.Name = "label4";
            label4.Size = new Size(154, 30);
            label4.TabIndex = 6;
            label4.Text = "Appointments";
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 682);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "Appointment";
            Text = "Appointment";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
        private Panel panel2;
        private Panel panel4;
        private GroupBox groupBox2;
        private Panel panel3;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Panel panel5;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Button button4;
    }
}