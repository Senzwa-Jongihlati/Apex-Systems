namespace apex_management_sys
{
    partial class ReceptionistDashboard
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
            btnDash = new Button();
            btnRegister = new Button();
            btnManageQ = new Button();
            btnSearchP2 = new Button();
            btnLogout = new Button();
            label3 = new Label();
            lblServedCount = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            QueueNumber = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            ArrivalTime = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
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
            label2.Location = new Point(589, -1);
            label2.Name = "label2";
            label2.Size = new Size(209, 25);
            label2.TabIndex = 1;
            label2.Text = "Receptionists Dashboard";
            // 
            // btnDash
            // 
            btnDash.Location = new Point(29, 171);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(112, 34);
            btnDash.TabIndex = 2;
            btnDash.Text = "Dashboard";
            btnDash.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(29, 231);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(159, 34);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register Patient";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnManageQ
            // 
            btnManageQ.Location = new Point(29, 300);
            btnManageQ.Name = "btnManageQ";
            btnManageQ.Size = new Size(112, 34);
            btnManageQ.TabIndex = 4;
            btnManageQ.Text = "Manage Queue";
            btnManageQ.UseVisualStyleBackColor = true;
            // 
            // btnSearchP2
            // 
            btnSearchP2.Location = new Point(29, 367);
            btnSearchP2.Name = "btnSearchP2";
            btnSearchP2.Size = new Size(112, 34);
            btnSearchP2.TabIndex = 5;
            btnSearchP2.Text = "Search Patient";
            btnSearchP2.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(29, 429);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 33);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 170);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 7;
            label3.Text = "Waiting ";
            // 
            // label4
            // 
            lblServedCount.AutoSize = true;
            lblServedCount.Location = new Point(418, 170);
            lblServedCount.Name = "label4";
            lblServedCount.Size = new Size(68, 25);
            lblServedCount.TabIndex = 8;
            lblServedCount.Text = "Priority";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(534, 170);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 9;
            label5.Text = "Served";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { QueueNumber, PatientName, ArrivalTime, Status, Priority });
            dataGridView1.Location = new Point(207, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(764, 132);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_09_10_232332;
            ClientSize = new Size(992, 516);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(lblServedCount);
            Controls.Add(label3);
            Controls.Add(btnLogout);
            Controls.Add(btnSearchP2);
            Controls.Add(btnManageQ);
            Controls.Add(btnRegister);
            Controls.Add(btnDash);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnDash;
        private Button btnRegister;
        private Button btnManageQ;
        private Button btnSearchP2;
        private Button btnLogout;
        private Label label3;
        private Label lblServedCount;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn QueueNumber;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn ArrivalTime;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Priority;
    }
}