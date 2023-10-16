namespace QuanLy
{
    partial class WaterReport
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
            this.rptWater = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpkCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpkCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnTaoReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptWater
            // 
            this.rptWater.LocalReport.ReportEmbeddedResource = "QuanLy.ReportWater.waterReport.rdlc";
            this.rptWater.Location = new System.Drawing.Point(0, 129);
            this.rptWater.Name = "rptWater";
            this.rptWater.ServerReport.BearerToken = null;
            this.rptWater.Size = new System.Drawing.Size(1041, 558);
            this.rptWater.TabIndex = 0;
            this.rptWater.Load += new System.EventHandler(this.rptWater_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoReport);
            this.groupBox1.Controls.Add(this.dtpkCheckOut);
            this.groupBox1.Controls.Add(this.dtpkCheckIn);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dtpkCheckIn
            // 
            this.dtpkCheckIn.Location = new System.Drawing.Point(108, 47);
            this.dtpkCheckIn.Name = "dtpkCheckIn";
            this.dtpkCheckIn.Size = new System.Drawing.Size(194, 20);
            this.dtpkCheckIn.TabIndex = 0;
            // 
            // dtpkCheckOut
            // 
            this.dtpkCheckOut.Location = new System.Drawing.Point(569, 47);
            this.dtpkCheckOut.Name = "dtpkCheckOut";
            this.dtpkCheckOut.Size = new System.Drawing.Size(253, 20);
            this.dtpkCheckOut.TabIndex = 1;
            // 
            // btnTaoReport
            // 
            this.btnTaoReport.Location = new System.Drawing.Point(419, 44);
            this.btnTaoReport.Name = "btnTaoReport";
            this.btnTaoReport.Size = new System.Drawing.Size(75, 23);
            this.btnTaoReport.TabIndex = 2;
            this.btnTaoReport.Text = "Tạo Report";
            this.btnTaoReport.UseVisualStyleBackColor = true;
            this.btnTaoReport.Click += new System.EventHandler(this.btnTaoReport_Click);
            // 
            // WaterReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptWater);
            this.Name = "WaterReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaterReport";
            this.Load += new System.EventHandler(this.WaterReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptWater;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoReport;
        private System.Windows.Forms.DateTimePicker dtpkCheckOut;
        private System.Windows.Forms.DateTimePicker dtpkCheckIn;
    }
}