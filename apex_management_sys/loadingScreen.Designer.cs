namespace apex_management_sys
{
    partial class loadingScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadingScreen));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            progressBar = new ProgressBar();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progessbarPanel = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            progessbarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 61, 92);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 396);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(progessbarPanel, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 242);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(709, 154);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Top;
            progressBar.Location = new Point(0, 0);
            progressBar.Margin = new Padding(3, 60, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(543, 44);
            progressBar.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(83, 0);
            label2.Name = "label2";
            label2.Size = new Size(543, 77);
            label2.TabIndex = 2;
            label2.Text = "Loading....";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(709, 242);
            label1.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // progessbarPanel
            // 
            progessbarPanel.Controls.Add(progressBar);
            progessbarPanel.Dock = DockStyle.Fill;
            progessbarPanel.Location = new Point(83, 80);
            progessbarPanel.Name = "progessbarPanel";
            progessbarPanel.Size = new Size(543, 71);
            progessbarPanel.TabIndex = 3;
            // 
            // loadingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 235, 245);
            ClientSize = new Size(709, 396);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "loadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loadingScreen";
            Load += loadingScreen_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            progessbarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel progessbarPanel;
    }
}