namespace apex_management_sys
{
    partial class SearchPatient
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
            lbl2IDNo = new Label();
            txt2IDNo = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnSearchPatient = new Button();
            btnManageQueue = new Button();
            btnRegisterPatient = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Returning Patient";
            // 
            // lbl2IDNo
            // 
            lbl2IDNo.AutoSize = true;
            lbl2IDNo.Location = new Point(268, 171);
            lbl2IDNo.Margin = new Padding(2, 0, 2, 0);
            lbl2IDNo.Name = "lbl2IDNo";
            lbl2IDNo.Size = new Size(82, 20);
            lbl2IDNo.TabIndex = 1;
            lbl2IDNo.Text = "ID Number";
            // 
            // txt2IDNo
            // 
            txt2IDNo.Location = new Point(367, 171);
            txt2IDNo.Margin = new Padding(2);
            txt2IDNo.Name = "txt2IDNo";
            txt2IDNo.Size = new Size(200, 27);
            txt2IDNo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Screenshot_2026_09_10_232332;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1098, 683);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            panel1.Size = new Size(199, 683);
            panel1.TabIndex = 14;
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
            // panel2
            // 
            panel2.Location = new Point(206, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 79);
            panel2.TabIndex = 1;
            // 
            // btnSearchPatient
            // 
            btnSearchPatient.Location = new Point(11, 446);
            btnSearchPatient.Margin = new Padding(2);
            btnSearchPatient.Name = "btnSearchPatient";
            btnSearchPatient.Size = new Size(162, 51);
            btnSearchPatient.TabIndex = 5;
            btnSearchPatient.Text = "Search Patient";
            btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // btnManageQueue
            // 
            btnManageQueue.Location = new Point(9, 391);
            btnManageQueue.Margin = new Padding(2);
            btnManageQueue.Name = "btnManageQueue";
            btnManageQueue.Size = new Size(162, 51);
            btnManageQueue.TabIndex = 4;
            btnManageQueue.Text = "Manage Queue";
            btnManageQueue.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPatient
            // 
            btnRegisterPatient.Location = new Point(9, 336);
            btnRegisterPatient.Margin = new Padding(2);
            btnRegisterPatient.Name = "btnRegisterPatient";
            btnRegisterPatient.Size = new Size(162, 51);
            btnRegisterPatient.TabIndex = 3;
            btnRegisterPatient.Text = "Register Patient";
            btnRegisterPatient.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(268, 239);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(814, 59);
            dataGridView1.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.Image = Properties.Resources.search_interface_symbol;
            button2.Location = new Point(591, 162);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(62, 45);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = false;
            // 
            // SearchPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 683);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(txt2IDNo);
            Controls.Add(lbl2IDNo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "SearchPatient";
            Text = "Returning Patient";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl2IDNo;
        private TextBox txt2IDNo;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button5;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btnSearchPatient;
        private Button btnManageQueue;
        private Button btnRegisterPatient;
        private DataGridView dataGridView1;
        private Button button2;
    }
}