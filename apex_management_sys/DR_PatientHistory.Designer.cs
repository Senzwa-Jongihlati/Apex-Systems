namespace apex_management_sys
{
    partial class DR_PatientHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DR_PatientHistory));
            TopBar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ContainerMain = new TableLayoutPanel();
            Main = new Panel();
            dataGridView1 = new DataGridView();
            MainHeader = new Panel();
            lblHeader = new Label();
            Feedback = new Panel();
            Notes = new Panel();
            txtNotes = new TextBox();
            lblNotes = new Label();
            Prescriptions = new Panel();
            txtPrescriptions = new TextBox();
            lblPrescriptions = new Label();
            btnClose = new Button();
            TopBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ContainerMain.SuspendLayout();
            Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            MainHeader.SuspendLayout();
            Feedback.SuspendLayout();
            Notes.SuspendLayout();
            Prescriptions.SuspendLayout();
            SuspendLayout();
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.FromArgb(222, 235, 245);
            TopBar.Controls.Add(tableLayoutPanel1);
            TopBar.Controls.Add(label3);
            TopBar.Controls.Add(pictureBox1);
            TopBar.Dock = DockStyle.Top;
            TopBar.Location = new Point(0, 0);
            TopBar.Margin = new Padding(3, 4, 3, 4);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(1348, 100);
            TopBar.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(84, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1124, 100);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(1118, 50);
            label2.TabIndex = 2;
            label2.Text = "T. Mkhize";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 50);
            label1.Name = "label1";
            label1.Size = new Size(1118, 50);
            label1.TabIndex = 1;
            label1.Text = "Patient no. 20481 · queue no. 014";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(1208, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 100);
            label3.TabIndex = 3;
            label3.Text = "Emergency";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 248, 251);
            panel1.Controls.Add(ContainerMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 666);
            panel1.TabIndex = 2;
            // 
            // ContainerMain
            // 
            ContainerMain.BackColor = Color.White;
            ContainerMain.ColumnCount = 3;
            ContainerMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            ContainerMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ContainerMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            ContainerMain.Controls.Add(Main, 1, 1);
            ContainerMain.Controls.Add(Feedback, 1, 3);
            ContainerMain.Controls.Add(btnClose, 1, 4);
            ContainerMain.Dock = DockStyle.Fill;
            ContainerMain.Location = new Point(0, 0);
            ContainerMain.Name = "ContainerMain";
            ContainerMain.RowCount = 5;
            ContainerMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            ContainerMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            ContainerMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ContainerMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            ContainerMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            ContainerMain.Size = new Size(1348, 666);
            ContainerMain.TabIndex = 1;
            // 
            // Main
            // 
            Main.BackColor = Color.White;
            Main.Controls.Add(dataGridView1);
            Main.Controls.Add(MainHeader);
            Main.Dock = DockStyle.Fill;
            Main.Location = new Point(153, 53);
            Main.Name = "Main";
            Main.Size = new Size(1042, 148);
            Main.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1042, 89);
            dataGridView1.TabIndex = 0;
            // 
            // MainHeader
            // 
            MainHeader.Controls.Add(lblHeader);
            MainHeader.Dock = DockStyle.Top;
            MainHeader.Location = new Point(0, 0);
            MainHeader.Name = "MainHeader";
            MainHeader.Size = new Size(1042, 59);
            MainHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1042, 59);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Patient Visit History";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Feedback
            // 
            Feedback.Controls.Add(Notes);
            Feedback.Controls.Add(Prescriptions);
            Feedback.Dock = DockStyle.Fill;
            Feedback.Location = new Point(153, 227);
            Feedback.Name = "Feedback";
            Feedback.Size = new Size(1042, 355);
            Feedback.TabIndex = 4;
            // 
            // Notes
            // 
            Notes.Controls.Add(txtNotes);
            Notes.Controls.Add(lblNotes);
            Notes.Dock = DockStyle.Fill;
            Notes.Location = new Point(0, 125);
            Notes.Name = "Notes";
            Notes.Size = new Size(1042, 230);
            Notes.TabIndex = 8;
            // 
            // txtNotes
            // 
            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Location = new Point(0, 33);
            txtNotes.Margin = new Padding(3, 4, 3, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.Size = new Size(1042, 197);
            txtNotes.TabIndex = 6;
            // 
            // lblNotes
            // 
            lblNotes.Dock = DockStyle.Top;
            lblNotes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotes.Location = new Point(0, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(1042, 33);
            lblNotes.TabIndex = 3;
            lblNotes.Text = "Notes:";
            // 
            // Prescriptions
            // 
            Prescriptions.Controls.Add(txtPrescriptions);
            Prescriptions.Controls.Add(lblPrescriptions);
            Prescriptions.Dock = DockStyle.Top;
            Prescriptions.Location = new Point(0, 0);
            Prescriptions.Name = "Prescriptions";
            Prescriptions.Size = new Size(1042, 125);
            Prescriptions.TabIndex = 5;
            // 
            // txtPrescriptions
            // 
            txtPrescriptions.Dock = DockStyle.Fill;
            txtPrescriptions.Location = new Point(0, 25);
            txtPrescriptions.Margin = new Padding(3, 4, 3, 4);
            txtPrescriptions.Multiline = true;
            txtPrescriptions.Name = "txtPrescriptions";
            txtPrescriptions.ReadOnly = true;
            txtPrescriptions.Size = new Size(1042, 100);
            txtPrescriptions.TabIndex = 7;
            // 
            // lblPrescriptions
            // 
            lblPrescriptions.Dock = DockStyle.Top;
            lblPrescriptions.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrescriptions.Location = new Point(0, 0);
            lblPrescriptions.Name = "lblPrescriptions";
            lblPrescriptions.Size = new Size(1042, 25);
            lblPrescriptions.TabIndex = 4;
            lblPrescriptions.Text = "Prescription (optional):";
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = SystemColors.ActiveCaption;
            btnClose.Dock = DockStyle.Left;
            btnClose.Location = new Point(153, 589);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(192, 73);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // DR_PatientHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 766);
            Controls.Add(panel1);
            Controls.Add(TopBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DR_PatientHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            TopBar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ContainerMain.ResumeLayout(false);
            ContainerMain.PerformLayout();
            Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            MainHeader.ResumeLayout(false);
            Feedback.ResumeLayout(false);
            Notes.ResumeLayout(false);
            Notes.PerformLayout();
            Prescriptions.ResumeLayout(false);
            Prescriptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopBar;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel Main;
        private DataGridView dataGridView1;
        private Panel MainHeader;
        private Label lblHeader;
        private TableLayoutPanel ContainerMain;
        private TextBox txtPrescriptions;
        private TextBox txtNotes;
        private TextBox textBox6;
        private Label lblPrescriptions;
        private Label lblNotes;
        private Button button2;
        private Button btnClose;
        private Panel Feedback;
        private Panel Notes;
        private Panel Prescriptions;
    }
}