using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace apex_management_sys
{
    public partial class home : Form
    {
        private Login login;
        public home()
        {
            InitializeComponent();
        }
        public home(Login loginform)
        {
            InitializeComponent();
            login = loginform;
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDeshPatient_Click(object sender, EventArgs e)
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

        private void Admissions_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            R.Show();
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void Appointments_Click(object sender, EventArgs e)
        {
            Appointment ap = new Appointment();
            ap.Show();
            this.Close();
        }
    }
}
