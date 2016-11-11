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
    public partial class Timewise_Report : Form
    {
        Control controlObj;
        public Timewise_Report()
        {
            InitializeComponent();
            controlObj = new Control();
        }

        private void eMPLOYEEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hR_Manager_Dataset);

        }

        private void Timewise_Report_Load(object sender, EventArgs e)
        {
            
            string[] eidList = controlObj.getEmpList();
            int i = 0;
            while (eidList[i] != null)
            {
                eIDComboBox.Items.Add(eidList[i]);
                i++;
            }

            
            // TODO: This line of code loads data into the 'hR_Manager_Dataset.ATTENDANCE' table. You can move, or remove it, as needed.
            //this.aTTENDANCETableAdapter.Fill(this.hR_Manager_Dataset.ATTENDANCE);
            // TODO: This line of code loads data into the 'hR_Manager_Dataset.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.hR_Manager_Dataset.EMPLOYEE);

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        public object ReportSource
        {
            get { return crystalReportViewer1.ReportSource; }
            set { crystalReportViewer1.ReportSource = value; }

        }

        private void eIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                /*StartDatePicker.CustomFormat = "dd-mm-yyyy";
                DateTime startDate = StartDatePicker.Value;

                EndDatePicker.CustomFormat = "dd-mm-yyyy";
                DateTime endDate = EndDatePicker.Value;
                */
                crystalReportViewer1.SelectionFormula = "{employee.eid} = '" + eIDComboBox.Text + "' And {attendance.start_time} in '"+ StartTimeMaskedTextBox1.Text +"' to '"+ StartTimeMaskedTextBox2 +"'";
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception exception)
            {
                MessageBox.Show("This Employee has no attendance record");  
              
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
