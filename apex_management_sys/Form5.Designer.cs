namespace apex_management_sys
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            btnDasboard = new Button();
            btnRegisterPatient = new Button();
            btnManageQueue = new Button();
            btnSearchPatient = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            lblWelcome = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            QueueNumber = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            ArrivalTime = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, -1);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Apex Systems";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(883, -1);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 1;
            label2.Text = "Reception Dashboard";
            // 
            // btnDasboard
            // 
            btnDasboard.Location = new Point(29, 155);
            btnDasboard.Name = "btnDasboard";
            btnDasboard.Size = new Size(112, 34);
            btnDasboard.TabIndex = 2;
            btnDasboard.Text = "Dashboard";
            btnDasboard.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPatient
            // 
            btnRegisterPatient.Location = new Point(29, 223);
            btnRegisterPatient.Name = "btnRegisterPatient";
            btnRegisterPatient.Size = new Size(150, 34);
            btnRegisterPatient.TabIndex = 3;
            btnRegisterPatient.Text = "Register Patient";
            btnRegisterPatient.UseVisualStyleBackColor = true;
            // 
            // btnManageQueue
            // 
            btnManageQueue.Location = new Point(29, 290);
            btnManageQueue.Name = "btnManageQueue";
            btnManageQueue.Size = new Size(150, 34);
            btnManageQueue.TabIndex = 4;
            btnManageQueue.Text = "Manage Queue";
            btnManageQueue.UseVisualStyleBackColor = true;
            // 
            // btnSearchPatient
            // 
            btnSearchPatient.Location = new Point(29, 360);
            btnSearchPatient.Name = "btnSearchPatient";
            btnSearchPatient.Size = new Size(150, 34);
            btnSearchPatient.TabIndex = 5;
            btnSearchPatient.Text = "Search Patient";
            btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(29, 425);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.apex_logo;
            pictureBox1.Location = new Point(-1, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(480, 75);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(182, 25);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Welcome Receptionst";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 155);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 9;
            label3.Text = "Waiting";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(663, 155);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 10;
            label4.Text = "Priority";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(922, 155);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 11;
            label5.Text = "Served";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { QueueNumber, PatientName, ArrivalTime, Status, Priority });
            dataGridView1.Location = new Point(304, 290);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(768, 169);
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
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_09_10_232332;
            ClientSize = new Size(1084, 595);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblWelcome);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnSearchPatient);
            Controls.Add(btnManageQueue);
            Controls.Add(btnRegisterPatient);
            Controls.Add(btnDasboard);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Reception Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnDasboard;
        private Button btnRegisterPatient;
        private Button btnManageQueue;
        private Button btnSearchPatient;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private Label lblWelcome;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn QueueNumber;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn ArrivalTime;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Priority;
    }
}