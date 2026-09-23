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
            RP_SearchPatient sp = new RP_SearchPatient();
            sp.Show();
            this.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public void CenterPanel()
        {
            Main.Left = (this.ClientSize.Width - Section.Width)/ 2;
            Main.Top = (this.ClientSize.Height - Section.Height) / 2;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Registration Regst = new Registration();
            Regst.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btndPatient_Click(object sender, EventArgs e)
        {
            RP_SearchPatient sp = new RP_SearchPatient();
            sp.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
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

        private void RP_SearchPatient_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }
    }
}
