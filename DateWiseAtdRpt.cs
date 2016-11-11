using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hr_home
{
    public partial class DateWiseAtdRpt : Form
    {
        public DateWiseAtdRpt()
        {
            InitializeComponent();
        }

        private void DateWiseAtdRpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hR_Manager_Dataset.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.hR_Manager_Dataset.EMPLOYEE);

        }
        public object ReportSource
        {
            get { return crystalReportViewer1.ReportSource; }
            set { crystalReportViewer1.ReportSource = value; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crystalReportViewer1.SelectionFormula = "{employee.eid} = '" + eIDComboBox.Text + "' And {attendance.start_time} in '" + StartTimeMaskedTextBox1.Text + "' to '" + StartTimeMaskedTextBox2 + "'";
            string eid=EidCombobox.Text;
            string startDate=startDatemaskedTextBox.Text;
            string endDate=endDateMaskedTextBox.Text;


            crystalReportViewer1.SelectionFormula = "{employee.eid}='" + eid + "' And {attendance.attendance_date} >= " + " Date (" + startDate + ") and {attendance.attendance_date} <= Date ("+endDate+")";
            crystalReportViewer1.RefreshReport();         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
