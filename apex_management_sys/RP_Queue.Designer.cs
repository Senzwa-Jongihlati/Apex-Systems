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
            lblWelcome = new Label();
            label3 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            QueueNumber = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            ArrivalTime = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Background = new PictureBox();
            Components = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            button5 = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            btnAppointment = new Button();
            Appointment = new Button();
            label18 = new Label();
            btnReception = new Button();
            label4 = new Label();
            label1 = new Label();
            btnLogOut = new Button();
            btnDoctor = new Button();
            btndPatient = new Button();
            homeDeshbord = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            btnQueue = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Background).BeginInit();
            Components.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(378, 8);
            lblWelcome.Margin = new Padding(2, 0, 2, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(122, 15);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Welcome Receptionst";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 290);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 9;
            label3.Text = "Waiting";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 107);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Served";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { QueueNumber, PatientName, ArrivalTime, Status, Priority });
            dataGridView1.Location = new Point(272, 320);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(712, 44);
            dataGridView1.TabIndex = 12;
            // 
            // QueueNumber
            // 
            QueueNumber.HeaderText = "Queue Number";
            QueueNumber.MinimumWidth = 8;
            QueueNumber.Name = "QueueNumber";
            QueueNumber.Width = 150;
            // 
            // PatientName
            // 
            PatientName.HeaderText = "Patient Name";
            PatientName.MinimumWidth = 8;
            PatientName.Name = "PatientName";
            PatientName.Width = 150;
            // 
            // ArrivalTime
            // 
            ArrivalTime.HeaderText = "Arrival Time";
            ArrivalTime.MinimumWidth = 8;
            ArrivalTime.Name = "ArrivalTime";
            ArrivalTime.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // Priority
            // 
            Priority.HeaderText = "Priority";
            Priority.MinimumWidth = 8;
            Priority.Name = "Priority";
            Priority.Width = 150;
            // 
            // Background
            // 
            Background.Dock = DockStyle.Fill;
            Background.Image = Properties.Resources.Screenshot_2026_09_10_232332;
            Background.Location = new Point(0, 0);
            Background.Margin = new Padding(3, 2, 3, 2);
            Background.Name = "Background";
            Background.Size = new Size(1040, 749);
            Background.SizeMode = PictureBoxSizeMode.StretchImage;
            Background.TabIndex = 13;
            Background.TabStop = false;
            // 
            // Components
            // 
            Components.BackColor = SystemColors.Control;
            Components.BackgroundImage = Properties.Resources.Screenshot_2026_09_10_232332;
            Components.BackgroundImageLayout = ImageLayout.Stretch;
            Components.Controls.Add(panel3);
            Components.Controls.Add(panel1);
            Components.Controls.Add(dataGridView1);
            Components.Controls.Add(dataGridView2);
            Components.Controls.Add(label5);
            Components.Controls.Add(lblWelcome);
            Components.Controls.Add(label3);
            Components.Dock = DockStyle.Fill;
            Components.Location = new Point(0, 0);
            Components.Margin = new Padding(3, 2, 3, 2);
            Components.Name = "Components";
            Components.Size = new Size(1040, 749);
            Components.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(txtSearch);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(174, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(866, 76);
            panel3.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(859, 27);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 3;
            label6.Text = "system administrator";
            // 
            // label7
            // 
            label7.Image = Properties.Resources.user__1_;
            label7.Location = new Point(810, 9);
            label7.Name = "label7";
            label7.Size = new Size(43, 54);
            label7.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 224, 192);
            button5.Image = Properties.Resources.search_interface_symbol;
            button5.Location = new Point(326, 12);
            button5.Name = "button5";
            button5.Size = new Size(54, 34);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(25, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(295, 23);
            txtSearch.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 35, 126);
            panel1.Controls.Add(btnQueue);
            panel1.Controls.Add(btnAppointment);
            panel1.Controls.Add(Appointment);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(btnReception);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnDoctor);
            panel1.Controls.Add(btndPatient);
            panel1.Controls.Add(homeDeshbord);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 749);
            panel1.TabIndex = 14;
            // 
            // btnAppointment
            // 
            btnAppointment.Location = new Point(8, 511);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(142, 39);
            btnAppointment.TabIndex = 12;
            btnAppointment.Text = "Admissions";
            btnAppointment.UseVisualStyleBackColor = true;
            // 
            // Appointment
            // 
            Appointment.Location = new Point(8, 450);
            Appointment.Name = "Appointment";
            Appointment.Size = new Size(142, 41);
            Appointment.TabIndex = 11;
            Appointment.Text = "Appointments";
            Appointment.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(14, 420);
            label18.Name = "label18";
            label18.Size = new Size(46, 15);
            label18.TabIndex = 10;
            label18.Text = "Clinical";
            // 
            // btnReception
            // 
            btnReception.Location = new Point(8, 360);
            btnReception.Name = "btnReception";
            btnReception.Size = new Size(142, 38);
            btnReception.TabIndex = 9;
            btnReception.Text = "Reception";
            btnReception.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(14, 219);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 8;
            label4.Text = "Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(8, 131);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 7;
            label1.Text = "Main";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(8, 679);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(142, 38);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "log out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnDoctor
            // 
            btnDoctor.Location = new Point(8, 307);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(142, 38);
            btnDoctor.TabIndex = 5;
            btnDoctor.Text = "Doctors";
            btnDoctor.UseVisualStyleBackColor = true;
            // 
            // btndPatient
            // 
            btndPatient.Location = new Point(8, 252);
            btndPatient.Name = "btndPatient";
            btndPatient.Size = new Size(142, 38);
            btndPatient.TabIndex = 4;
            btndPatient.Text = "Patients";
            btndPatient.UseVisualStyleBackColor = true;
            // 
            // homeDeshbord
            // 
            homeDeshbord.ForeColor = SystemColors.ActiveCaptionText;
            homeDeshbord.Location = new Point(8, 155);
            homeDeshbord.Name = "homeDeshbord";
            homeDeshbord.Size = new Size(142, 38);
            homeDeshbord.TabIndex = 3;
            homeDeshbord.Text = "Deshboard";
            homeDeshbord.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.apex_logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(180, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 59);
            panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(272, 154);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(712, 44);
            dataGridView2.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Queue Number";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Patient Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Arrival Time";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Status";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Priority";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // btnQueue
            // 
            btnQueue.Location = new Point(8, 566);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(142, 39);
            btnQueue.TabIndex = 14;
            btnQueue.Text = "Queue";
            btnQueue.UseVisualStyleBackColor = true;
            // 
            // RP_Queue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 749);
            Controls.Add(Components);
            Controls.Add(Background);
            Margin = new Padding(2);
            Name = "RP_Queue";
            Text = "Reception Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Background).EndInit();
            Components.ResumeLayout(false);
            Components.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblWelcome;
        private Label label3;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn QueueNumber;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn ArrivalTime;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Priority;
        private PictureBox Background;
        private Panel Components;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Panel panel1;
        private Button btnAppointment;
        private Button Appointment;
        private Label label18;
        private Button btnReception;
        private Label label4;
        private Label label1;
        private Button btnLogOut;
        private Button btnDoctor;
        private Button btndPatient;
        private Button homeDeshbord;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private Button button5;
        private TextBox txtSearch;
        private Button btnQueue;
    }
}