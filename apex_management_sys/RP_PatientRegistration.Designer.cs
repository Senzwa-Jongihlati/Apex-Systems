namespace apex_management_sys
{
    partial class Registration
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
            lblName = new Label();
            lblSurname = new Label();
            lblIDNo = new Label();
            lblPhone = new Label();
            lblGender = new Label();
            lblDOB = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtID = new TextBox();
            txtPhoneNo = new TextBox();
            cbGender = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            cbIDType = new ComboBox();
            cbPriority = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtReasonForVisit = new TextBox();
            txtEmergancyContact = new TextBox();
            txtAddress = new TextBox();
            button1 = new Button();
            btnRegisterPatient = new Button();
            Main = new Panel();
            Container = new TableLayoutPanel();
            ButtonContainer = new Panel();
            groupBox1.SuspendLayout();
            Main.SuspendLayout();
            Container.SuspendLayout();
            ButtonContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(56, 39);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name ";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(441, 39);
            lblSurname.Margin = new Padding(2, 0, 2, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(67, 20);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname";
            // 
            // lblIDNo
            // 
            lblIDNo.AutoSize = true;
            lblIDNo.Location = new Point(441, 117);
            lblIDNo.Margin = new Padding(2, 0, 2, 0);
            lblIDNo.Name = "lblIDNo";
            lblIDNo.Size = new Size(86, 20);
            lblIDNo.TabIndex = 3;
            lblIDNo.Text = "ID Number ";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(56, 316);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(134, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Cellphone Number";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(53, 209);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(441, 209);
            lblDOB.Margin = new Padding(2, 0, 2, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(94, 20);
            lblDOB.TabIndex = 6;
            lblDOB.Text = "Date of Birth";
            lblDOB.Click += lblDOB_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(56, 68);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(356, 27);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(441, 68);
            txtSurname.Margin = new Padding(2, 3, 2, 3);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(373, 27);
            txtSurname.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(441, 147);
            txtID.Margin = new Padding(2, 4, 2, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(374, 27);
            txtID.TabIndex = 4;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(56, 339);
            txtPhoneNo.Margin = new Padding(2, 3, 2, 3);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(358, 27);
            txtPhoneNo.TabIndex = 7;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female ", "Male" });
            cbGender.Location = new Point(53, 232);
            cbGender.Margin = new Padding(2, 3, 2, 3);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(359, 28);
            cbGender.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(441, 233);
            dateTimePicker1.Margin = new Padding(2, 4, 2, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(373, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 117);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 16;
            label2.Text = "Identification Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1602, 107);
            label1.TabIndex = 23;
            label1.Text = "Register patient";
            label1.Click += label1_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 107);
            label7.Name = "label7";
            label7.Size = new Size(1602, 80);
            label7.TabIndex = 24;
            label7.Text = "Enter the patient's details to create a new record";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbIDType);
            groupBox1.Controls.Add(cbPriority);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtReasonForVisit);
            groupBox1.Controls.Add(txtEmergancyContact);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblSurname);
            groupBox1.Controls.Add(lblIDNo);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(lblGender);
            groupBox1.Controls.Add(lblDOB);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(cbGender);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 192);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(1602, 751);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal information";
            // 
            // cbIDType
            // 
            cbIDType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIDType.FormattingEnabled = true;
            cbIDType.Items.AddRange(new object[] { "SA ID", "Passport" });
            cbIDType.Location = new Point(56, 147);
            cbIDType.Margin = new Padding(2, 4, 2, 4);
            cbIDType.Name = "cbIDType";
            cbIDType.Size = new Size(359, 28);
            cbIDType.TabIndex = 3;
            cbIDType.SelectedIndexChanged += cbIdententificationType_SelectedIndexChanged;
            // 
            // cbPriority
            // 
            cbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPriority.FormattingEnabled = true;
            cbPriority.Items.AddRange(new object[] { "Emergency", "Urgent", "Routine" });
            cbPriority.Location = new Point(441, 597);
            cbPriority.Margin = new Padding(3, 5, 3, 5);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(366, 28);
            cbPriority.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(441, 564);
            label13.Name = "label13";
            label13.Size = new Size(56, 20);
            label13.TabIndex = 27;
            label13.Text = "Priority";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(56, 564);
            label12.Name = "label12";
            label12.Size = new Size(110, 20);
            label12.TabIndex = 26;
            label12.Text = "Reason for visit";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(53, 519);
            label11.Name = "label11";
            label11.Size = new Size(141, 25);
            label11.TabIndex = 25;
            label11.Text = "Medical intake";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(53, 279);
            label10.Name = "label10";
            label10.Size = new Size(143, 25);
            label10.TabIndex = 24;
            label10.Text = "Contact details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 415);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 23;
            label9.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(441, 315);
            label8.Name = "label8";
            label8.Size = new Size(135, 20);
            label8.TabIndex = 22;
            label8.Text = "Emergency contact";
            // 
            // txtReasonForVisit
            // 
            txtReasonForVisit.Location = new Point(53, 597);
            txtReasonForVisit.Margin = new Padding(3, 5, 3, 5);
            txtReasonForVisit.Name = "txtReasonForVisit";
            txtReasonForVisit.Size = new Size(354, 27);
            txtReasonForVisit.TabIndex = 10;
            // 
            // txtEmergancyContact
            // 
            txtEmergancyContact.Location = new Point(441, 339);
            txtEmergancyContact.Margin = new Padding(3, 5, 3, 5);
            txtEmergancyContact.Name = "txtEmergancyContact";
            txtEmergancyContact.Size = new Size(373, 27);
            txtEmergancyContact.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(56, 456);
            txtAddress.Margin = new Padding(3, 5, 3, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(743, 27);
            txtAddress.TabIndex = 9;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(2, 4, 2, 4);
            button1.Name = "button1";
            button1.Size = new Size(198, 99);
            button1.TabIndex = 13;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnRegisterPatient
            // 
            btnRegisterPatient.BackColor = Color.FromArgb(11, 61, 92);
            btnRegisterPatient.Dock = DockStyle.Right;
            btnRegisterPatient.ForeColor = SystemColors.ControlLightLight;
            btnRegisterPatient.Location = new Point(1404, 0);
            btnRegisterPatient.Margin = new Padding(2, 5, 2, 5);
            btnRegisterPatient.Name = "btnRegisterPatient";
            btnRegisterPatient.Size = new Size(198, 99);
            btnRegisterPatient.TabIndex = 12;
            btnRegisterPatient.Text = "Register patient";
            btnRegisterPatient.UseVisualStyleBackColor = false;
            btnRegisterPatient.Click += btnRegisterPatient_Click;
            // 
            // Main
            // 
            Main.Controls.Add(Container);
            Main.Dock = DockStyle.Fill;
            Main.Location = new Point(0, 0);
            Main.Margin = new Padding(3, 4, 3, 4);
            Main.Name = "Main";
            Main.Size = new Size(1608, 1055);
            Main.TabIndex = 26;
            // 
            // Container
            // 
            Container.ColumnCount = 1;
            Container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Container.Controls.Add(ButtonContainer, 0, 3);
            Container.Controls.Add(groupBox1, 0, 2);
            Container.Controls.Add(label7, 0, 1);
            Container.Controls.Add(label1, 0, 0);
            Container.Dock = DockStyle.Fill;
            Container.Location = new Point(0, 0);
            Container.Margin = new Padding(3, 4, 3, 4);
            Container.Name = "Container";
            Container.RowCount = 4;
            Container.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            Container.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            Container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Container.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            Container.Size = new Size(1608, 1055);
            Container.TabIndex = 26;
            // 
            // ButtonContainer
            // 
            ButtonContainer.Controls.Add(button1);
            ButtonContainer.Controls.Add(btnRegisterPatient);
            ButtonContainer.Dock = DockStyle.Fill;
            ButtonContainer.Location = new Point(3, 952);
            ButtonContainer.Margin = new Padding(3, 4, 3, 4);
            ButtonContainer.Name = "ButtonContainer";
            ButtonContainer.Size = new Size(1602, 99);
            ButtonContainer.TabIndex = 27;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(245, 248, 251);
            ClientSize = new Size(1608, 1055);
            ControlBox = false;
            Controls.Add(Main);
            FormScreenCaptureMode = ScreenCaptureMode.HideContent;
            Margin = new Padding(2, 4, 2, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Registration";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            Resize += Registration_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Main.ResumeLayout(false);
            Container.ResumeLayout(false);
            Container.PerformLayout();
            ButtonContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblName;
        private Label lblSurname;
        private Label lblIDNo;
        private Label lblPhone;
        private Label lblGender;
        private Label lblDOB;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtID;
        private TextBox txtPhoneNo;
        private ComboBox cbGender;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private Label label7;
        private GroupBox groupBox1;
        private Button button1;
        private Button btnRegisterPatient;
        private TextBox txtReasonForVisit;
        private TextBox txtEmergancyContact;
        private TextBox txtAddress;
        private Label label8;
        private Label label9;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox cbPriority;
        private ComboBox cbIDType;
        private Panel Main;
        private TableLayoutPanel Container;
        private Panel ButtonContainer;
    }
}