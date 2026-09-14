using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace apex_management_sys
{
    public partial class RP_SearchPatient : Form
    {
        public RP_SearchPatient()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RP_Queue Queue = new RP_Queue();
            Queue.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Registration Regst = new Registration();
            Regst.Show();
            this.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
