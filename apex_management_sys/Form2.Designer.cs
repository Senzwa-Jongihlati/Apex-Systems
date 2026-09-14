namespace apex_management_sys
{
    partial class Form2
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
            btnSave = new Button();
            btnClear = new Button();
            label2 = new Label();
            txtAddress = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 0;
            label1.Text = "Patient Registration";
            label1.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(91, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name ";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(91, 119);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(82, 25);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname";
            // 
            // lblIDNo
            // 
            lblIDNo.AutoSize = true;
            lblIDNo.Location = new Point(91, 178);
            lblIDNo.Name = "lblIDNo";
            lblIDNo.Size = new Size(105, 25);
            lblIDNo.TabIndex = 3;
            lblIDNo.Text = "ID Number ";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(91, 238);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(132, 25);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone Number";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(91, 289);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 25);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(91, 393);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(112, 25);
            lblDOB.TabIndex = 6;
            lblDOB.Text = "Date of Birth";
            // 
            // txtName
            // 
            txtName.Location = new Point(269, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 7;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(269, 119);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(150, 31);
            txtSurname.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(269, 178);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 9;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(269, 238);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(150, 31);
            txtPhoneNo.TabIndex = 10;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female ", "Male" });
            cbGender.Location = new Point(269, 289);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(182, 33);
            cbGender.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(269, 387);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(252, 469);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(401, 469);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 343);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 16;
            label2.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(269, 343);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 17;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_09_10_232332;
            ClientSize = new Size(800, 534);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbGender);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtID);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(lblDOB);
            Controls.Add(lblGender);
            Controls.Add(lblPhone);
            Controls.Add(lblIDNo);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private Button btnSave;
        private Button btnClear;
        private Label label2;
        private TextBox txtAddress;
    }
}