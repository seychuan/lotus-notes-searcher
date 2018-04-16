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
            this.rtbOutput.Location = new System.Drawing.Point(13, 65);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(919, 530);
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
            this.txtNsfFilePath.Size = new System.Drawing.Size(638, 20);
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
            this.cboView.Location = new System.Drawing.Point(738, 10);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(194, 21);
            this.cboView.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 607);
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
    }
}

