using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace apex_management_sys
{
    public partial class RP_Queue : Form
    {
        public RP_Queue()
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome To The Queue {Session.CurrentReceptionist.GetFullName()}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration Regst = new Registration();
            Regst.Show();
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

        private void Admissions_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            R.Show();
            this.Close();
        }

        private void Patients_Click(object sender, EventArgs e)
        {
            RP_SearchPatient sp = new RP_SearchPatient();
            sp.Show();
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
