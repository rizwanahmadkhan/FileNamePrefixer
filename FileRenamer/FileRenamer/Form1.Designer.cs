namespace FileRenamer
{
    partial class Form1
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
            this.txtSelectedFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFileFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSortProperty = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tsslStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSortingType = new System.Windows.Forms.ComboBox();
            this.lstbFileNames = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSelectedFolderPath
            // 
            this.txtSelectedFolderPath.Location = new System.Drawing.Point(88, 19);
            this.txtSelectedFolderPath.Name = "txtSelectedFolderPath";
            this.txtSelectedFolderPath.Size = new System.Drawing.Size(261, 20);
            this.txtSelectedFolderPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Folder:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(364, 18);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Format:";
            // 
            // cmbFileFormat
            // 
            this.cmbFileFormat.FormattingEnabled = true;
            this.cmbFileFormat.Location = new System.Drawing.Point(88, 59);
            this.cmbFileFormat.Name = "cmbFileFormat";
            this.cmbFileFormat.Size = new System.Drawing.Size(120, 21);
            this.cmbFileFormat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sorting Property:";
            // 
            // cmbSortProperty
            // 
            this.cmbSortProperty.FormattingEnabled = true;
            this.cmbSortProperty.Location = new System.Drawing.Point(319, 59);
            this.cmbSortProperty.Name = "cmbSortProperty";
            this.cmbSortProperty.Size = new System.Drawing.Size(120, 21);
            this.cmbSortProperty.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Prefixes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stsStatus
            // 
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatusLabel});
            this.stsStatus.Location = new System.Drawing.Point(0, 276);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(710, 22);
            this.stsStatus.SizingGrip = false;
            this.stsStatus.TabIndex = 8;
            this.stsStatus.Text = "statusStrip1";
            // 
            // tsslStatusLabel
            // 
            this.tsslStatusLabel.Name = "tsslStatusLabel";
            this.tsslStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sorting Type:";
            // 
            // cmbSortingType
            // 
            this.cmbSortingType.FormattingEnabled = true;
            this.cmbSortingType.Location = new System.Drawing.Point(88, 98);
            this.cmbSortingType.Name = "cmbSortingType";
            this.cmbSortingType.Size = new System.Drawing.Size(120, 21);
            this.cmbSortingType.TabIndex = 10;
            // 
            // lstbFileNames
            // 
            this.lstbFileNames.FormattingEnabled = true;
            this.lstbFileNames.HorizontalScrollbar = true;
            this.lstbFileNames.Location = new System.Drawing.Point(471, 46);
            this.lstbFileNames.Name = "lstbFileNames";
            this.lstbFileNames.Size = new System.Drawing.Size(212, 212);
            this.lstbFileNames.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Files in the Folder (Filtered):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 298);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstbFileNames);
            this.Controls.Add(this.cmbSortingType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSortProperty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFileFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSelectedFolderPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Add Prefix to File Name";
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSelectedFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFileFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSortProperty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSortingType;
        private System.Windows.Forms.ListBox lstbFileNames;
        private System.Windows.Forms.Label label5;
    }
}

