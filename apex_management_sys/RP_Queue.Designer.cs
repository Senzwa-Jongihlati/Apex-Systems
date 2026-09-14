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
            label2 = new Label();
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
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            button7 = new Button();
            button6 = new Button();
            button3 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Background).BeginInit();
            Components.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label3.Location = new Point(311, 387);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Waiting";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 143);
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
            dataGridView1.Location = new Point(311, 426);
            dataGridView1.Margin = new Padding(2);
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
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Size = new Size(1188, 658);
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
            Components.Controls.Add(tableLayoutPanel1);
            Components.Dock = DockStyle.Fill;
            Components.Location = new Point(0, 0);
            Components.Name = "Components";
            Components.Size = new Size(1188, 658);
            Components.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(311, 206);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(25, 35, 126);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button7, 0, 7);
            tableLayoutPanel1.Controls.Add(button6, 0, 6);
            tableLayoutPanel1.Controls.Add(button3, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(218, 658);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Bottom;
            button7.Location = new Point(3, 603);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(212, 51);
            button7.TabIndex = 14;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(2, 203);
            button6.Margin = new Padding(2, 2, 2, 0);
            button6.Name = "button6";
            button6.Size = new Size(214, 51);
            button6.TabIndex = 13;
            button6.Text = "Search Patient";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(2, 150);
            button3.Margin = new Padding(2, 2, 2, 0);
            button3.Name = "button3";
            button3.Size = new Size(214, 51);
            button3.TabIndex = 11;
            button3.Text = "Register Patient";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(3, 120);
            label4.Name = "label4";
            label4.Size = new Size(212, 28);
            label4.TabIndex = 10;
            label4.Text = "Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.apex_logo;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // RP_Queue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 658);
            Controls.Add(label2);
            Controls.Add(Components);
            Controls.Add(Background);
            Margin = new Padding(2);
            Name = "RP_Queue";
            Text = "Reception Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Background).EndInit();
            Components.ResumeLayout(false);
            Components.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
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
        private TableLayoutPanel tableLayoutPanel1;
        private Button button7;
        private Button button6;
        private Button button3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}