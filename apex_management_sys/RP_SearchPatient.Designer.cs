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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            btnAddPatient = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label11 = new Label();
            button9 = new Button();
            txtSearch = new TextBox();
            panel6 = new Panel();
            panel5 = new Panel();
            btnLogOut = new Button();
            label5 = new Label();
            label4 = new Label();
            label18 = new Label();
            panel7 = new Panel();
            btnQueue = new Button();
            button7 = new Button();
            btnAppointment = new Button();
            label12 = new Label();
            btnReception = new Button();
            label13 = new Label();
            label14 = new Label();
            button3 = new Button();
            btnDoctor = new Button();
            btnPatient = new Button();
            homeDeshbord = new Button();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 75);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 37);
            label1.TabIndex = 0;
            label1.Text = "Patients";
            // 
            // lbl2IDNo
            // 
            lbl2IDNo.AutoSize = true;
            lbl2IDNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2IDNo.ForeColor = Color.Blue;
            lbl2IDNo.Location = new Point(217, 120);
            lbl2IDNo.Margin = new Padding(2, 0, 2, 0);
            lbl2IDNo.Name = "lbl2IDNo";
            lbl2IDNo.Size = new Size(170, 21);
            lbl2IDNo.TabIndex = 1;
            lbl2IDNo.Text = "Deshboard / Patients";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 55);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(975, 345);
            dataGridView1.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Image = Properties.Resources.search_interface_symbol;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(713, 38);
            button2.Name = "button2";
            button2.Size = new Size(70, 34);
            button2.TabIndex = 16;
            button2.Text = "Filter";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(271, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 90);
            panel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(817, 38);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 17;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(533, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(142, 23);
            comboBox2.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(546, 17);
            label7.Name = "label7";
            label7.Size = new Size(64, 21);
            label7.TabIndex = 4;
            label7.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 16);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(294, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 23);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 17);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 0;
            label2.Text = "Search";
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = Color.FromArgb(11, 61, 92);
            btnAddPatient.ForeColor = SystemColors.ControlLightLight;
            btnAddPatient.Location = new Point(1029, 105);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(194, 55);
            btnAddPatient.TabIndex = 20;
            btnAddPatient.Text = "Add patient";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(272, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 400);
            panel2.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(977, 56);
            panel4.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(172, 17);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 2;
            label10.Text = "(12 total)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(71, 12);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 1;
            label9.Text = "Patient List";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.Image = Properties.Resources.users_avatar;
            label8.Location = new Point(18, 12);
            label8.Name = "label8";
            label8.Size = new Size(47, 34);
            label8.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(985, 19);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 3;
            label6.Text = "system administrator";
            // 
            // label11
            // 
            label11.Image = Properties.Resources.user__1_;
            label11.Location = new Point(936, 9);
            label11.Name = "label11";
            label11.Size = new Size(43, 44);
            label11.TabIndex = 2;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 224, 192);
            button9.Image = Properties.Resources.search_interface_symbol;
            button9.Location = new Point(326, 12);
            button9.Name = "button9";
            button9.Size = new Size(54, 34);
            button9.TabIndex = 1;
            button9.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(25, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(295, 23);
            txtSearch.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(button9);
            panel6.Controls.Add(txtSearch);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(187, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1126, 56);
            panel6.TabIndex = 23;
            // 
            // panel5
            // 
            panel5.Location = new Point(180, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(730, 59);
            panel5.TabIndex = 1;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(8, 131);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 7;
            label5.Text = "Main";
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
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(11, 61, 92);
            panel7.Controls.Add(btnQueue);
            panel7.Controls.Add(button7);
            panel7.Controls.Add(btnAppointment);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(btnReception);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(button3);
            panel7.Controls.Add(btnDoctor);
            panel7.Controls.Add(btnPatient);
            panel7.Controls.Add(homeDeshbord);
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(174, 728);
            panel7.TabIndex = 11;
            // 
            // btnQueue
            // 
            btnQueue.FlatAppearance.BorderSize = 0;
            btnQueue.FlatStyle = FlatStyle.Flat;
            btnQueue.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnQueue.ForeColor = SystemColors.ButtonHighlight;
            btnQueue.Image = Properties.Resources.queue;
            btnQueue.ImageAlign = ContentAlignment.MiddleLeft;
            btnQueue.Location = new Point(8, 567);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(142, 39);
            btnQueue.TabIndex = 13;
            btnQueue.Text = "Queue";
            btnQueue.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = Properties.Resources.medical_assistance;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(8, 511);
            button7.Name = "button7";
            button7.Size = new Size(142, 39);
            button7.TabIndex = 12;
            button7.Text = "Admissions";
            button7.UseVisualStyleBackColor = true;
            // 
            // btnAppointment
            // 
            btnAppointment.FlatAppearance.BorderSize = 0;
            btnAppointment.FlatStyle = FlatStyle.Flat;
            btnAppointment.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAppointment.ForeColor = SystemColors.ButtonHighlight;
            btnAppointment.Image = (Image)resources.GetObject("btnAppointment.Image");
            btnAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointment.Location = new Point(8, 450);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(142, 41);
            btnAppointment.TabIndex = 11;
            btnAppointment.Text = "Appointments";
            btnAppointment.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(8, 417);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 10;
            label12.Text = "Clinical";
            // 
            // btnReception
            // 
            btnReception.FlatAppearance.BorderSize = 0;
            btnReception.FlatStyle = FlatStyle.Flat;
            btnReception.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReception.ForeColor = SystemColors.ButtonHighlight;
            btnReception.Image = Properties.Resources.receptionist;
            btnReception.ImageAlign = ContentAlignment.MiddleLeft;
            btnReception.Location = new Point(8, 360);
            btnReception.Name = "btnReception";
            btnReception.Size = new Size(142, 38);
            btnReception.TabIndex = 9;
            btnReception.Text = "Reception";
            btnReception.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlLight;
            label13.Location = new Point(8, 220);
            label13.Name = "label13";
            label13.Size = new Size(81, 15);
            label13.TabIndex = 8;
            label13.Text = "Management";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlLight;
            label14.Location = new Point(8, 131);
            label14.Name = "label14";
            label14.Size = new Size(46, 21);
            label14.TabIndex = 7;
            label14.Text = "Main";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Image = Properties.Resources.enter;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(8, 679);
            button3.Name = "button3";
            button3.Size = new Size(142, 38);
            button3.TabIndex = 6;
            button3.Text = "log out";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnDoctor
            // 
            btnDoctor.FlatAppearance.BorderSize = 0;
            btnDoctor.FlatStyle = FlatStyle.Flat;
            btnDoctor.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDoctor.ForeColor = SystemColors.ButtonHighlight;
            btnDoctor.Image = Properties.Resources.doctor__1_;
            btnDoctor.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoctor.Location = new Point(8, 307);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(142, 38);
            btnDoctor.TabIndex = 5;
            btnDoctor.Text = "Doctors";
            btnDoctor.UseVisualStyleBackColor = true;
            // 
            // btnPatient
            // 
            btnPatient.FlatAppearance.BorderSize = 0;
            btnPatient.FlatStyle = FlatStyle.Flat;
            btnPatient.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPatient.ForeColor = SystemColors.ButtonHighlight;
            btnPatient.Image = Properties.Resources.healthcare;
            btnPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatient.Location = new Point(8, 252);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(142, 38);
            btnPatient.TabIndex = 4;
            btnPatient.Text = "Patients";
            btnPatient.UseVisualStyleBackColor = true;
            // 
            // homeDeshbord
            // 
            homeDeshbord.FlatAppearance.BorderSize = 0;
            homeDeshbord.FlatStyle = FlatStyle.Flat;
            homeDeshbord.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeDeshbord.ForeColor = SystemColors.ButtonHighlight;
            homeDeshbord.Image = Properties.Resources.employment;
            homeDeshbord.ImageAlign = ContentAlignment.MiddleLeft;
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
            // panel8
            // 
            panel8.Location = new Point(180, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(730, 59);
            panel8.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(11, 61, 92);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnLogOut);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 728);
            panel3.TabIndex = 22;
            // 
            // RP_SearchPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 728);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnAddPatient);
            Controls.Add(panel1);
            Controls.Add(lbl2IDNo);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "RP_SearchPatient";
            Text = "Returning Patient";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl2IDNo;
        private DataGridView dataGridView1;
        private Button button2;
        private Panel panel1;
        private ComboBox comboBox2;
        private Label label7;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button btnAddPatient;
        private Panel panel2;
        private Panel panel4;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label6;
        private Label label11;
        private Button button9;
        private TextBox txtSearch;
        private Panel panel6;
        private Panel panel5;
        private Button btnLogOut;
        private Label label5;
        private Label label4;
        private Label label18;
        private Panel panel7;
        private Button btnQueue;
        private Button button7;
        private Button btnAppointment;
        private Label label12;
        private Button btnReception;
        private Label label13;
        private Label label14;
        private Button button3;
        private Button btnDoctor;
        private Button btnPatient;
        private Button homeDeshbord;
        private PictureBox pictureBox1;
        private Panel panel8;
        private Panel panel3;
    }
}