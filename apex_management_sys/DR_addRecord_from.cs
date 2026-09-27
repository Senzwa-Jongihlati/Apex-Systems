using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace apex_management_sys
{
    public partial class DR_addRecord_from : Form
    {
        private readonly int _queueId;

        public DR_addRecord_from()
        {
            InitializeComponent();
        }

        public DR_addRecord_from(int queueId)
        {
            InitializeComponent();
            _queueId = queueId;
            //LoadPatientRecord();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DR_PatientHistory ph = new DR_PatientHistory();
            ph.Show();
        }
    }
}
