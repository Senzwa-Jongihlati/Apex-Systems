using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace apex_management_sys
{
    public partial class loadingScreen : Form
    {
        public loadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar.Increment(1);
            if (progressBar.Value == 100)
            {

                timer1.Stop();
                Login l = new Login();
                l.Show();
                this.Hide();
            }

        }

        private void loadingScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }

}
    