namespace PageExtractionDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.rdoSearch = new System.Windows.Forms.RadioButton();
            this.txtPageNumbers = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.NumericUpDown();
            this.txtFrom = new System.Windows.Forms.NumericUpDown();
            this.rdoNumber = new System.Windows.Forms.RadioButton();
            this.rdoRange = new System.Windows.Forms.RadioButton();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchText);
            this.groupBox1.Controls.Add(this.rdoSearch);
            this.groupBox1.Controls.Add(this.txtPageNumbers);
            this.groupBox1.Controls.Add(this.txtTo);
            this.groupBox1.Controls.Add(this.txtFrom);
            this.groupBox1.Controls.Add(this.rdoNumber);
            this.groupBox1.Controls.Add(this.rdoRange);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(6, 207);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(246, 20);
            this.txtSearchText.TabIndex = 6;
            // 
            // rdoSearch
            // 
            this.rdoSearch.AutoSize = true;
            this.rdoSearch.Location = new System.Drawing.Point(6, 168);
            this.rdoSearch.Name = "rdoSearch";
            this.rdoSearch.Size = new System.Drawing.Size(209, 17);
            this.rdoSearch.TabIndex = 5;
            this.rdoSearch.TabStop = true;
            this.rdoSearch.Text = "Enter Text for Search Based Extraction";
            this.rdoSearch.UseVisualStyleBackColor = true;
            this.rdoSearch.CheckedChanged += new System.EventHandler(this.rdoSearch_CheckedChanged);
            // 
            // txtPageNumbers
            // 
            this.txtPageNumbers.Location = new System.Drawing.Point(6, 127);
            this.txtPageNumbers.Name = "txtPageNumbers";
            this.txtPageNumbers.Size = new System.Drawing.Size(246, 20);
            this.txtPageNumbers.TabIndex = 4;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(132, 52);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(120, 20);
            this.txtTo.TabIndex = 3;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(6, 52);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(120, 20);
            this.txtFrom.TabIndex = 2;
            // 
            // rdoNumber
            // 
            this.rdoNumber.AutoSize = true;
            this.rdoNumber.Location = new System.Drawing.Point(6, 89);
            this.rdoNumber.Name = "rdoNumber";
            this.rdoNumber.Size = new System.Drawing.Size(228, 17);
            this.rdoNumber.TabIndex = 1;
            this.rdoNumber.TabStop = true;
            this.rdoNumber.Text = "Enter Page Number(s): (Comma Separated)";
            this.rdoNumber.UseVisualStyleBackColor = true;
            this.rdoNumber.CheckedChanged += new System.EventHandler(this.rdoNumber_CheckedChanged);
            // 
            // rdoRange
            // 
            this.rdoRange.AutoSize = true;
            this.rdoRange.Location = new System.Drawing.Point(6, 19);
            this.rdoRange.Name = "rdoRange";
            this.rdoRange.Size = new System.Drawing.Size(152, 17);
            this.rdoRange.TabIndex = 0;
            this.rdoRange.TabStop = true;
            this.rdoRange.Text = "Specify Range: (From - To)";
            this.rdoRange.UseVisualStyleBackColor = true;
            this.rdoRange.CheckedChanged += new System.EventHandler(this.rdoRange_CheckedChanged);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(302, 20);
            this.txtFilePath.TabIndex = 5;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(321, 11);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(134, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload PDF";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(321, 308);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(134, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create new PDF";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page Extraction with Aspose.PDF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPageNumbers;
        private System.Windows.Forms.NumericUpDown txtTo;
        private System.Windows.Forms.NumericUpDown txtFrom;
        private System.Windows.Forms.RadioButton rdoNumber;
        private System.Windows.Forms.RadioButton rdoRange;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.RadioButton rdoSearch;
    }
}

