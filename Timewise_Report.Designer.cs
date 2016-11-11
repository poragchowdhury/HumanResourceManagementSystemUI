namespace Hr_home
{
    partial class Timewise_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label eIDLabel;
            System.Windows.Forms.Label aTTENDANCE_DATELabel1;
            System.Windows.Forms.Label label1;
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportDocument2 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.final_timewiseAtd1 = new Hr_home.final_timewiseAtd();
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartTimeMaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.StartTimeMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.ViewReport = new System.Windows.Forms.Button();
            this.eIDComboBox = new System.Windows.Forms.ComboBox();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Manager_Dataset = new Hr_home.HR_Manager_Dataset();
            this.aTTENDANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new Hr_home.HR_Manager_DatasetTableAdapters.EMPLOYEETableAdapter();
            this.tableAdapterManager = new Hr_home.HR_Manager_DatasetTableAdapters.TableAdapterManager();
            this.aTTENDANCETableAdapter = new Hr_home.HR_Manager_DatasetTableAdapters.ATTENDANCETableAdapter();
            eIDLabel = new System.Windows.Forms.Label();
            aTTENDANCE_DATELabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Manager_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eIDLabel
            // 
            eIDLabel.AutoSize = true;
            eIDLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            eIDLabel.Location = new System.Drawing.Point(205, 26);
            eIDLabel.Name = "eIDLabel";
            eIDLabel.Size = new System.Drawing.Size(28, 13);
            eIDLabel.TabIndex = 0;
            eIDLabel.Text = "EID:";
            // 
            // aTTENDANCE_DATELabel1
            // 
            aTTENDANCE_DATELabel1.AutoSize = true;
            aTTENDANCE_DATELabel1.Location = new System.Drawing.Point(36, 65);
            aTTENDANCE_DATELabel1.Name = "aTTENDANCE_DATELabel1";
            aTTENDANCE_DATELabel1.Size = new System.Drawing.Size(23, 13);
            aTTENDANCE_DATELabel1.TabIndex = 4;
            aTTENDANCE_DATELabel1.Text = "To:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 13);
            label1.TabIndex = 9;
            label1.Text = "From:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 133);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "F:\\programming\\programming code\\c#\\BestAir2\\best air projects info\\Hr_home\\Hr_hom" +
                "e\\bin\\Debug\\REPORT\\final_timewiseAtd.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1284, 869);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // reportDocument1
            // 
            this.reportDocument1.FileName = "rassdk://C:\\Users\\porag\\Documents\\Visual Studio 2008\\Projects\\Hr_home\\Hr_home\\bin" +
                "\\Debug\\REPORT\\Attendance_currentrpt.rpt";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ViewReport);
            this.panel1.Controls.Add(eIDLabel);
            this.panel1.Controls.Add(this.eIDComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 127);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(aTTENDANCE_DATELabel1);
            this.groupBox1.Controls.Add(this.StartTimeMaskedTextBox2);
            this.groupBox1.Controls.Add(this.StartTimeMaskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(419, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 91);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Time";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // StartTimeMaskedTextBox2
            // 
            this.StartTimeMaskedTextBox2.Location = new System.Drawing.Point(75, 58);
            this.StartTimeMaskedTextBox2.Mask = "00:00";
            this.StartTimeMaskedTextBox2.Name = "StartTimeMaskedTextBox2";
            this.StartTimeMaskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.StartTimeMaskedTextBox2.TabIndex = 8;
            this.StartTimeMaskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // StartTimeMaskedTextBox1
            // 
            this.StartTimeMaskedTextBox1.Location = new System.Drawing.Point(75, 23);
            this.StartTimeMaskedTextBox1.Mask = "00:00";
            this.StartTimeMaskedTextBox1.Name = "StartTimeMaskedTextBox1";
            this.StartTimeMaskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.StartTimeMaskedTextBox1.TabIndex = 7;
            this.StartTimeMaskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // ViewReport
            // 
            this.ViewReport.BackColor = System.Drawing.Color.Blue;
            this.ViewReport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewReport.Location = new System.Drawing.Point(764, 26);
            this.ViewReport.Name = "ViewReport";
            this.ViewReport.Size = new System.Drawing.Size(75, 23);
            this.ViewReport.TabIndex = 6;
            this.ViewReport.Text = "View Report";
            this.ViewReport.UseVisualStyleBackColor = false;
            this.ViewReport.Click += new System.EventHandler(this.ViewReport_Click);
            // 
            // eIDComboBox
            // 
            this.eIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EID", true));
            this.eIDComboBox.FormattingEnabled = true;
            this.eIDComboBox.Location = new System.Drawing.Point(239, 23);
            this.eIDComboBox.Name = "eIDComboBox";
            this.eIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.eIDComboBox.TabIndex = 1;
            this.eIDComboBox.SelectedIndexChanged += new System.EventHandler(this.eIDComboBox_SelectedIndexChanged);
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.hR_Manager_Dataset;
            // 
            // hR_Manager_Dataset
            // 
            this.hR_Manager_Dataset.DataSetName = "HR_Manager_Dataset";
            this.hR_Manager_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTTENDANCEBindingSource
            // 
            this.aTTENDANCEBindingSource.DataMember = "ATTENDANCE";
            this.aTTENDANCEBindingSource.DataSource = this.hR_Manager_Dataset;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ATTENDANCETableAdapter = this.aTTENDANCETableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMPLOYEETableAdapter = this.eMPLOYEETableAdapter;
            this.tableAdapterManager.UpdateOrder = Hr_home.HR_Manager_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aTTENDANCETableAdapter
            // 
            this.aTTENDANCETableAdapter.ClearBeforeFill = true;
            // 
            // Timewise_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 1002);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Timewise_Report";
            this.Text = "Timewise_Report";
            this.Load += new System.EventHandler(this.Timewise_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Manager_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Timewise Timewise1;
        private System.Windows.Forms.Panel panel1;
        private HR_Manager_Dataset hR_Manager_Dataset;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private Hr_home.HR_Manager_DatasetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private Hr_home.HR_Manager_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox eIDComboBox;
        private Hr_home.HR_Manager_DatasetTableAdapters.ATTENDANCETableAdapter aTTENDANCETableAdapter;
        private System.Windows.Forms.BindingSource aTTENDANCEBindingSource;
        private System.Windows.Forms.Button ViewReport;
        private System.Windows.Forms.MaskedTextBox StartTimeMaskedTextBox2;
        private System.Windows.Forms.MaskedTextBox StartTimeMaskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private final_timewiseAtd final_timewiseAtd1;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument2;
    }
}