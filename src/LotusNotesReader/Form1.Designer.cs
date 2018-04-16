namespace LotusNotesReader
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOpenNsf = new System.Windows.Forms.Button();
            this.txtNsfFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.lblNotesItemLabel = new System.Windows.Forms.Label();
            this.lblNotesItemCount = new System.Windows.Forms.Label();
            this.lblNotesItemTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNotesViewTotal = new System.Windows.Forms.Label();
            this.lblNotesViewCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNotesEntryTotal = new System.Windows.Forms.Label();
            this.lblNotesEntryCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Location = new System.Drawing.Point(13, 139);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(524, 177);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(94, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnOpenNsf
            // 
            this.btnOpenNsf.Location = new System.Drawing.Point(13, 8);
            this.btnOpenNsf.Name = "btnOpenNsf";
            this.btnOpenNsf.Size = new System.Drawing.Size(75, 23);
            this.btnOpenNsf.TabIndex = 3;
            this.btnOpenNsf.Text = "Open Nsf";
            this.btnOpenNsf.UseVisualStyleBackColor = true;
            this.btnOpenNsf.Click += new System.EventHandler(this.btnOpenNsf_Click);
            // 
            // txtNsfFilePath
            // 
            this.txtNsfFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNsfFilePath.Location = new System.Drawing.Point(94, 10);
            this.txtNsfFilePath.Name = "txtNsfFilePath";
            this.txtNsfFilePath.ReadOnly = true;
            this.txtNsfFilePath.Size = new System.Drawing.Size(243, 20);
            this.txtNsfFilePath.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "NSF File|*.nsf";
            this.openFileDialog1.Multiselect = true;
            // 
            // cboView
            // 
            this.cboView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboView.FormattingEnabled = true;
            this.cboView.Location = new System.Drawing.Point(343, 10);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(194, 21);
            this.cboView.TabIndex = 5;
            // 
            // lblNotesItemLabel
            // 
            this.lblNotesItemLabel.AutoSize = true;
            this.lblNotesItemLabel.Location = new System.Drawing.Point(14, 115);
            this.lblNotesItemLabel.Name = "lblNotesItemLabel";
            this.lblNotesItemLabel.Size = new System.Drawing.Size(35, 13);
            this.lblNotesItemLabel.TabIndex = 6;
            this.lblNotesItemLabel.Text = "Items:";
            // 
            // lblNotesItemCount
            // 
            this.lblNotesItemCount.AutoSize = true;
            this.lblNotesItemCount.Location = new System.Drawing.Point(84, 115);
            this.lblNotesItemCount.Name = "lblNotesItemCount";
            this.lblNotesItemCount.Size = new System.Drawing.Size(37, 13);
            this.lblNotesItemCount.TabIndex = 7;
            this.lblNotesItemCount.Text = "00000";
            // 
            // lblNotesItemTotal
            // 
            this.lblNotesItemTotal.AutoSize = true;
            this.lblNotesItemTotal.Location = new System.Drawing.Point(140, 115);
            this.lblNotesItemTotal.Name = "lblNotesItemTotal";
            this.lblNotesItemTotal.Size = new System.Drawing.Size(37, 13);
            this.lblNotesItemTotal.TabIndex = 8;
            this.lblNotesItemTotal.Text = "00000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "/";
            // 
            // lblNotesViewTotal
            // 
            this.lblNotesViewTotal.AutoSize = true;
            this.lblNotesViewTotal.Location = new System.Drawing.Point(140, 71);
            this.lblNotesViewTotal.Name = "lblNotesViewTotal";
            this.lblNotesViewTotal.Size = new System.Drawing.Size(37, 13);
            this.lblNotesViewTotal.TabIndex = 12;
            this.lblNotesViewTotal.Text = "00000";
            // 
            // lblNotesViewCount
            // 
            this.lblNotesViewCount.AutoSize = true;
            this.lblNotesViewCount.Location = new System.Drawing.Point(84, 71);
            this.lblNotesViewCount.Name = "lblNotesViewCount";
            this.lblNotesViewCount.Size = new System.Drawing.Size(37, 13);
            this.lblNotesViewCount.TabIndex = 11;
            this.lblNotesViewCount.Text = "00000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Views:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "/";
            // 
            // lblNotesEntryTotal
            // 
            this.lblNotesEntryTotal.AutoSize = true;
            this.lblNotesEntryTotal.Location = new System.Drawing.Point(140, 93);
            this.lblNotesEntryTotal.Name = "lblNotesEntryTotal";
            this.lblNotesEntryTotal.Size = new System.Drawing.Size(37, 13);
            this.lblNotesEntryTotal.TabIndex = 16;
            this.lblNotesEntryTotal.Text = "00000";
            // 
            // lblNotesEntryCount
            // 
            this.lblNotesEntryCount.AutoSize = true;
            this.lblNotesEntryCount.Location = new System.Drawing.Point(84, 93);
            this.lblNotesEntryCount.Name = "lblNotesEntryCount";
            this.lblNotesEntryCount.Size = new System.Drawing.Size(37, 13);
            this.lblNotesEntryCount.TabIndex = 15;
            this.lblNotesEntryCount.Text = "00000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Entries:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(279, 46);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 13);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "...";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(359, 71);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(37, 13);
            this.lblStartTime.TabIndex = 20;
            this.lblStartTime.Text = "00000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Start Time:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(359, 93);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(37, 13);
            this.lblEndTime.TabIndex = 22;
            this.lblEndTime.Text = "00000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "End Time:";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Location = new System.Drawing.Point(359, 115);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(37, 13);
            this.lblElapsedTime.TabIndex = 24;
            this.lblElapsedTime.Text = "00000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Elapsed Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 328);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNotesEntryTotal);
            this.Controls.Add(this.lblNotesEntryCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNotesViewTotal);
            this.Controls.Add(this.lblNotesViewCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNotesItemTotal);
            this.Controls.Add(this.lblNotesItemCount);
            this.Controls.Add(this.lblNotesItemLabel);
            this.Controls.Add(this.cboView);
            this.Controls.Add(this.txtNsfFilePath);
            this.Controls.Add(this.btnOpenNsf);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotus Notes Search Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnOpenNsf;
        private System.Windows.Forms.TextBox txtNsfFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Label lblNotesItemLabel;
        private System.Windows.Forms.Label lblNotesItemCount;
        private System.Windows.Forms.Label lblNotesItemTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNotesViewTotal;
        private System.Windows.Forms.Label lblNotesViewCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNotesEntryTotal;
        private System.Windows.Forms.Label lblNotesEntryCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Label label6;
    }
}

