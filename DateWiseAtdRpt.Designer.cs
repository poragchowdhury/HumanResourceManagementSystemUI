namespace Hr_home
{
    partial class DateWiseAtdRpt
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ShowReportButton = new System.Windows.Forms.Button();
            this.EidCombobox = new System.Windows.Forms.ComboBox();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Manager_Dataset = new Hr_home.HR_Manager_Dataset();
            this.eMPLOYEETableAdapter = new Hr_home.HR_Manager_DatasetTableAdapters.EMPLOYEETableAdapter();
            this.startDatemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.endDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Manager_Dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "F:\\programming\\programming code\\c#\\BestAir2\\best air projects info\\Hr_home\\Hr_hom" +
                "e\\bin\\Debug\\REPORT\\DatewiseAtd.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1276, 776);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // ShowReportButton
            // 
            this.ShowReportButton.Location = new System.Drawing.Point(1155, 15);
            this.ShowReportButton.Name = "ShowReportButton";
            this.ShowReportButton.Size = new System.Drawing.Size(75, 23);
            this.ShowReportButton.TabIndex = 1;
            this.ShowReportButton.Text = "Show Report";
            this.ShowReportButton.UseVisualStyleBackColor = true;
            this.ShowReportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EidCombobox
            // 
            this.EidCombobox.DataSource = this.eMPLOYEEBindingSource;
            this.EidCombobox.DisplayMember = "EID";
            this.EidCombobox.FormattingEnabled = true;
            this.EidCombobox.Location = new System.Drawing.Point(609, 14);
            this.EidCombobox.Name = "EidCombobox";
            this.EidCombobox.Size = new System.Drawing.Size(121, 21);
            this.EidCombobox.TabIndex = 2;
            this.EidCombobox.ValueMember = "EID";
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
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // startDatemaskedTextBox
            // 
            this.startDatemaskedTextBox.Location = new System.Drawing.Point(812, 17);
            this.startDatemaskedTextBox.Mask = "0000, 00, 00";
            this.startDatemaskedTextBox.Name = "startDatemaskedTextBox";
            this.startDatemaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.startDatemaskedTextBox.TabIndex = 3;
            // 
            // endDateMaskedTextBox
            // 
            this.endDateMaskedTextBox.Location = new System.Drawing.Point(1000, 17);
            this.endDateMaskedTextBox.Mask = "0000, 00, 00";
            this.endDateMaskedTextBox.Name = "endDateMaskedTextBox";
            this.endDateMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.endDateMaskedTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(500, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(933, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(736, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DateWiseAtdRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 776);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDateMaskedTextBox);
            this.Controls.Add(this.startDatemaskedTextBox);
            this.Controls.Add(this.EidCombobox);
            this.Controls.Add(this.ShowReportButton);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "DateWiseAtdRpt";
            this.Text = "DateWiseAtdRpt";
            this.Load += new System.EventHandler(this.DateWiseAtdRpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Manager_Dataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button ShowReportButton;
        private System.Windows.Forms.ComboBox EidCombobox;
        private HR_Manager_Dataset hR_Manager_Dataset;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private Hr_home.HR_Manager_DatasetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.MaskedTextBox startDatemaskedTextBox;
        private System.Windows.Forms.MaskedTextBox endDateMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}