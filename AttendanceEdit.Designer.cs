namespace Hr_home
{
    partial class AttendanceEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceEdit));
            this.EidCombobox = new System.Windows.Forms.ComboBox();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Manager_Dataset = new Hr_home.HR_Manager_Dataset();
            this.eMPLOYEEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.eMPLOYEETableAdapter = new Hr_home.HR_Manager_DatasetTableAdapters.EMPLOYEETableAdapter();
            this.AttIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EndTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Manager_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EidCombobox
            // 
            this.EidCombobox.FormattingEnabled = true;
            this.EidCombobox.Location = new System.Drawing.Point(130, 158);
            this.EidCombobox.Name = "EidCombobox";
            this.EidCombobox.Size = new System.Drawing.Size(121, 21);
            this.EidCombobox.TabIndex = 0;
            this.EidCombobox.SelectedIndexChanged += new System.EventHandler(this.EidCombobox_SelectedIndexChanged);
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
            // eMPLOYEEBindingSource1
            // 
            this.eMPLOYEEBindingSource1.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource1.DataSource = this.hR_Manager_Dataset;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // AttIDMaskedTextBox
            // 
            this.AttIDMaskedTextBox.Location = new System.Drawing.Point(130, 207);
            this.AttIDMaskedTextBox.Mask = "00/00/0000";
            this.AttIDMaskedTextBox.Name = "AttIDMaskedTextBox";
            this.AttIDMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.AttIDMaskedTextBox.TabIndex = 1;
            this.AttIDMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Attendance Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "End Time";
            // 
            // EndTimeMaskedTextBox
            // 
            this.EndTimeMaskedTextBox.Location = new System.Drawing.Point(130, 291);
            this.EndTimeMaskedTextBox.Mask = "00:00";
            this.EndTimeMaskedTextBox.Name = "EndTimeMaskedTextBox";
            this.EndTimeMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.EndTimeMaskedTextBox.TabIndex = 3;
            this.EndTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // StartTimeMaskedTextBox
            // 
            this.StartTimeMaskedTextBox.Location = new System.Drawing.Point(130, 251);
            this.StartTimeMaskedTextBox.Mask = "00:00";
            this.StartTimeMaskedTextBox.Name = "StartTimeMaskedTextBox";
            this.StartTimeMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.StartTimeMaskedTextBox.TabIndex = 2;
            this.StartTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(93, 489);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(158, 27);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update Record";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(93, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(93, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 27);
            this.button3.TabIndex = 12;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.StartTimeMaskedTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.EndTimeMaskedTextBox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EidCombobox);
            this.panel1.Controls.Add(this.AttIDMaskedTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(902, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 749);
            this.panel1.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectToolStripMenuItem.Text = "&Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenuItem.Text = "&Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "&Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1276, 776);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AttendanceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 776);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AttendanceEdit";
            this.Text = "AttendanceEdit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AttendanceEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Manager_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EidCombobox;
        private System.Windows.Forms.Label label1;
        private HR_Manager_Dataset hR_Manager_Dataset;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private Hr_home.HR_Manager_DatasetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.MaskedTextBox AttIDMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox EndTimeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox StartTimeMaskedTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}