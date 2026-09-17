using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace apex_management_sys
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RP_Queue Queue = new RP_Queue();
            Queue.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RP_SearchPatient Search = new RP_SearchPatient();
            Search.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Background_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private void Patients_Click(object sender, EventArgs e)
        {
            RP_SearchPatient sp = new RP_SearchPatient();
            sp.Show();
            this.Close();
        }

        private void Queue_Click(object sender, EventArgs e)
        {
            RP_Queue Q = new RP_Queue();
            Q.Show();
            this.Close();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Close();
        }
    }
}
