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
    public partial class Form1 : Form
    {
        Control controlObj=new Control();
        public Form1()
        {
            
            InitializeComponent();
            //Control controlObj = new Control();
        }

        private void contactWithDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*private void TimewiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }*/

        private void jamilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("iexplore", "http://jamil_2342@yahoo.com");
        }

        private void attendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AttendanceEdit AE = new AttendanceEdit();
            AE.Show();
        }

        private void timewiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timewise_Report Timewise = new Timewise_Report();   // Generates Timewise report with date interval 
            Timewise.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hR_Manager_Dataset.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.hR_Manager_Dataset.EMPLOYEE);

            DateMaskedTextBox.Text = controlObj.getCurrentDate();
            string date = DateMaskedTextBox.Text;

            RefreshDisplayGroupBox(date);
            nAMECheckedListBox.Items.AddRange(controlObj.getDateItem("employee","name"));
            religionCheckedListBox.Items.AddRange(controlObj.getDateItem("employee", "religion"));
            locationCheckedListBox.Items.AddRange(controlObj.getDateItem("employee", "location"));

            
        }

        private void RefreshDisplayGroupBox(string date)
        {
            TotalEmpLabel.Text = controlObj.getTotalEmp().ToString();
            TotalPreEmpLabel.Text = controlObj.getTotalPresent(date).ToString();
            TotalEmpLeaveLabel.Text = controlObj.getTotalLeave(date).ToString();
            TotalAbsEmpLabel.Text = controlObj.getTotalAbsent(date).ToString();
        }

        private void datewiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new DateWiseAtdRpt().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //oleDbDataAdapter1.Fill(dataSet1);
            //dataGrid1.SetDataBinding(dataSet1, "employee");
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Today_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DisplayComboBox.Text=="Employee Present")
            {
                string date = DateMaskedTextBox.Text;
                dataSet1.Clear();
                oleDbDataAdapter1.SelectCommand.CommandText = controlObj.getQryPresent(date);
                oleDbDataAdapter1.Fill(dataSet1, "Employee_hr");
                dataGrid1.SetDataBinding(dataSet1, "Employee_hr"); 
            }
            
            else if (DisplayComboBox.Text == "Employee Absent")
            {
                string date = DateMaskedTextBox.Text;
                dataSet1.Clear();
                oleDbDataAdapter1.SelectCommand.CommandText = controlObj.getQryAbsent(date);
                oleDbDataAdapter1.Fill(dataSet1, "Employee_hr");
                dataGrid1.SetDataBinding(dataSet1, "Employee_hr");
            }
            
            else if (DisplayComboBox.Text == "Employee Leave")
            {
                string date = DateMaskedTextBox.Text;
                dataSet1.Clear();
                oleDbDataAdapter1.SelectCommand.CommandText = controlObj.getQryLeave(date);
                oleDbDataAdapter1.Fill(dataSet1, "Employee_hr");
                dataGrid1.SetDataBinding(dataSet1, "Employee_hr");
            }
        }

        private void DateMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DateMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            string date = DateMaskedTextBox.Text;
            try
            {
                RefreshDisplayGroupBox(date);
            }
            catch (Exception ex)
            {


            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.SelectCommand.CommandText = "select * from employee";
            dataSet1.Clear();
            oleDbDataAdapter1.Fill(dataSet1, "employee");
            SearchDataGrid.SetDataBinding(dataSet1, "employee");
            
        }

        private void AttributeCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eMPLOYEETableAdapter.FillBy(this.hR_Manager_Dataset.EMPLOYEE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void locationCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mail_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
