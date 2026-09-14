namespace apex_management_sys
{
    partial class ReceptionDashboard: Form
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
            label2 = new Label();
            btnRegisterPatient = new Button();
            btnManageQueue = new Button();
            btnSearchPatient = new Button();
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
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Background).BeginInit();
            Components.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(706, -1);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 1;
            label2.Text = "Reception Dashboard";
            // 
            // btnRegisterPatient
            // 
            btnRegisterPatient.Location = new Point(9, 336);
            btnRegisterPatient.Margin = new Padding(2, 2, 2, 2);
            btnRegisterPatient.Name = "btnRegisterPatient";
            btnRegisterPatient.Size = new Size(162, 51);
            btnRegisterPatient.TabIndex = 3;
            btnRegisterPatient.Text = "Register Patient";
            btnRegisterPatient.UseVisualStyleBackColor = true;
            // 
            // btnManageQueue
            // 
            btnManageQueue.Location = new Point(9, 391);
            btnManageQueue.Margin = new Padding(2, 2, 2, 2);
            btnManageQueue.Name = "btnManageQueue";
            btnManageQueue.Size = new Size(162, 51);
            btnManageQueue.TabIndex = 4;
            btnManageQueue.Text = "Manage Queue";
            btnManageQueue.UseVisualStyleBackColor = true;
            // 
            // btnSearchPatient
            // 
            btnSearchPatient.Location = new Point(11, 446);
            btnSearchPatient.Margin = new Padding(2, 2, 2, 2);
            btnSearchPatient.Name = "btnSearchPatient";
            btnSearchPatient.Size = new Size(162, 51);
            btnSearchPatient.TabIndex = 5;
            btnSearchPatient.Text = "Search Patient";
            btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(432, 11);
            lblWelcome.Margin = new Padding(2, 0, 2, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(153, 20);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Welcome Receptionst";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 410);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Waiting";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 155);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 11;
            label5.Text = "Served";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { QueueNumber, PatientName, ArrivalTime, Status, Priority });
            dataGridView1.Location = new Point(85, 446);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(814, 59);
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
            Background.Location = new Point(199, 0);
            Background.Name = "Background";
            Background.Size = new Size(1054, 695);
            Background.SizeMode = PictureBoxSizeMode.StretchImage;
            Background.TabIndex = 13;
            Background.TabStop = false;
            // 
            // Components
            // 
            Components.BackColor = SystemColors.Control;
            Components.BackgroundImage = Properties.Resources.Screenshot_2026_09_10_232332;
            Components.BackgroundImageLayout = ImageLayout.Stretch;
            Components.Controls.Add(dataGridView1);
            Components.Controls.Add(dataGridView2);
            Components.Controls.Add(label5);
            Components.Controls.Add(lblWelcome);
            Components.Controls.Add(label3);
            Components.Dock = DockStyle.Fill;
            Components.Location = new Point(199, 0);
            Components.Name = "Components";
            Components.Size = new Size(1054, 695);
            Components.TabIndex = 0;
            Components.Paint += this.Components_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.apex_logo;
            pictureBox2.Location = new Point(9, 11);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 35, 126);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSearchPatient);
            panel1.Controls.Add(btnManageQueue);
            panel1.Controls.Add(btnRegisterPatient);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 695);
            panel1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(16, 292);
            label6.Name = "label6";
            label6.Size = new Size(137, 28);
            label6.TabIndex = 8;
            label6.Text = "Management";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(9, 175);
            label7.Name = "label7";
            label7.Size = new Size(57, 28);
            label7.TabIndex = 7;
            label7.Text = "Main";
            // 
            // button1
            // 
            button1.Location = new Point(9, 608);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 51);
            button1.TabIndex = 6;
            button1.Text = "log out";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(206, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 79);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(9, 207);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(162, 51);
            button5.TabIndex = 3;
            button5.Text = "Deshboard";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(85, 193);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(814, 58);
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
            // ReceptionDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 695);
            Controls.Add(Components);
            Controls.Add(label2);
            Controls.Add(Background);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ReceptionDashboard";
            Text = "Reception Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Background).EndInit();
            Components.ResumeLayout(false);
            Components.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnRegisterPatient;
        private Button btnManageQueue;
        private Button btnSearchPatient;
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
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Button button1;
        private Panel panel2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button button5;
    }
}