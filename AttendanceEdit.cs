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
    public partial class AttendanceEdit : Form
    {
        private Control controlObj;
        public AttendanceEdit()
        {
            InitializeComponent();
            controlObj = new Control();
        }

        private void aTTENDANCEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.aTTENDANCEBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.hR_Manager_Dataset);

        }



        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string startTime, endTime;
            string eid=EidCombobox.Text;
            string atdDate=AttIDMaskedTextBox.Text;
            
            
            startTime = controlObj.getStartTime(eid, atdDate);
            endTime = controlObj.getEndtime(eid, atdDate);
            
            
            StartTimeMaskedTextBox.Text = startTime;
            EndTimeMaskedTextBox.Text = endTime;
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("You are about to insert a new record.\nDo you want to continue?","Insertion Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                string eid = EidCombobox.Text;
                string atdDate = AttIDMaskedTextBox.Text;
                string startTime = StartTimeMaskedTextBox.Text;
                string endTime = EndTimeMaskedTextBox.Text;
                controlObj.insertAttendance(eid, atdDate, startTime, endTime);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EidCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AttendanceEdit_Load(object sender, EventArgs e)
        {
            string [] eidList=controlObj.getEmpList();
            int i=0;
            while (eidList[i]!=null)
            {
                EidCombobox.Items.Add(eidList[i]); 
                i++;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlObj.deleteAtd(EidCombobox.Text, AttIDMaskedTextBox.Text);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlObj.updateAtd(EidCombobox.Text,AttIDMaskedTextBox.Text,StartTimeMaskedTextBox.Text,EndTimeMaskedTextBox.Text);

        }
    }
}
