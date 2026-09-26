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


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Queue_Click(object sender, EventArgs e)
        {
            RP_Queue Q = new RP_Queue();
            Q.Show();
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            Login.Instance.Show();
            this.Close();
        }

        private void Appointments_Click(object sender, EventArgs e)
        {
            Appointment ap = new Appointment();
            ap.Show();
            this.Close();
        }

        private void home_Load(object sender, EventArgs e)
        {
            btnQueue.Visible = Session.CurrentUser.HasPermission(Permission.ManageQueue);
            btnDoctors.Visible = Session.CurrentUser.HasPermission(Permission.AddConsultationNote);
            btnAppointments.Visible = Session.CurrentUser.HasPermission(Permission.BookAppointment);
            btnPatients.Visible = Session.CurrentUser.HasPermission(Permission.ViewPatientRecords);
            btnEmployees.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
            btnDashboard.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);
            Main.Visible = Session.CurrentUser.HasPermission(Permission.ManageStaff);

            btnDashboard.Enabled = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Close();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            RP_SearchPatient r = new RP_SearchPatient();
            r.Show();
            this.Close();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            DR_Doctor d = new DR_Doctor();
            d.Show();
            this.Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            newAccount na = new newAccount();
            na.Show();
            this.Close();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Appointment a = new Appointment();
            a.Show();
            this.Close();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            RP_Queue q = new RP_Queue();
            q.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            Login.Instance.Show();
            this.Close();
        }
    }
}
