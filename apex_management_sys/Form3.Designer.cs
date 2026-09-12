namespace apex_management_sys
{
    partial class Form3
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
            btnSearch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Returning Patient";
            // 
            // lbl2IDNo
            // 
            lbl2IDNo.AutoSize = true;
            lbl2IDNo.Location = new Point(58, 205);
            lbl2IDNo.Name = "lbl2IDNo";
            lbl2IDNo.Size = new Size(100, 25);
            lbl2IDNo.TabIndex = 1;
            lbl2IDNo.Text = "ID Number";
            // 
            // txt2IDNo
            // 
            txt2IDNo.Location = new Point(199, 205);
            txt2IDNo.Name = "txt2IDNo";
            txt2IDNo.Size = new Size(150, 31);
            txt2IDNo.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(299, 426);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(171, 34);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Patient";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_09_10_232332;
            ClientSize = new Size(796, 556);
            Controls.Add(btnSearch);
            Controls.Add(txt2IDNo);
            Controls.Add(lbl2IDNo);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Returning Patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl2IDNo;
        private TextBox txt2IDNo;
        private Button btnSearch;
    }
}