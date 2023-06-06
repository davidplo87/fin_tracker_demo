
namespace _411_Demo_2
{
    partial class ReportRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportRequestForm));
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.rbRestVsCater = new System.Windows.Forms.RadioButton();
            this.rbFoodVsSales = new System.Windows.Forms.RadioButton();
            this.rbPayroll = new System.Windows.Forms.RadioButton();
            this.rbSpld = new System.Windows.Forms.RadioButton();
            this.rbPnl = new System.Windows.Forms.RadioButton();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.rbSixMonth = new System.Windows.Forms.RadioButton();
            this.rbThreeMonth = new System.Windows.Forms.RadioButton();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLastFullMonth = new System.Windows.Forms.Label();
            this.lblLastFullMonthVal = new System.Windows.Forms.Label();
            this.gbReport.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.rbSales);
            this.gbReport.Controls.Add(this.rbRestVsCater);
            this.gbReport.Controls.Add(this.rbFoodVsSales);
            this.gbReport.Controls.Add(this.rbPayroll);
            this.gbReport.Controls.Add(this.rbSpld);
            this.gbReport.Controls.Add(this.rbPnl);
            this.gbReport.Location = new System.Drawing.Point(12, 32);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(198, 163);
            this.gbReport.TabIndex = 0;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Report";
            // 
            // rbSales
            // 
            this.rbSales.AutoSize = true;
            this.rbSales.Location = new System.Drawing.Point(7, 43);
            this.rbSales.Name = "rbSales";
            this.rbSales.Size = new System.Drawing.Size(80, 17);
            this.rbSales.TabIndex = 6;
            this.rbSales.TabStop = true;
            this.rbSales.Text = "Sales (Line)";
            this.rbSales.UseVisualStyleBackColor = true;
            // 
            // rbRestVsCater
            // 
            this.rbRestVsCater.AutoSize = true;
            this.rbRestVsCater.Location = new System.Drawing.Point(7, 89);
            this.rbRestVsCater.Name = "rbRestVsCater";
            this.rbRestVsCater.Size = new System.Drawing.Size(186, 17);
            this.rbRestVsCater.TabIndex = 5;
            this.rbRestVsCater.TabStop = true;
            this.rbRestVsCater.Text = "Restaurant vs Catering Sales (Pie)";
            this.rbRestVsCater.UseVisualStyleBackColor = true;
            // 
            // rbFoodVsSales
            // 
            this.rbFoodVsSales.AutoSize = true;
            this.rbFoodVsSales.Location = new System.Drawing.Point(7, 66);
            this.rbFoodVsSales.Name = "rbFoodVsSales";
            this.rbFoodVsSales.Size = new System.Drawing.Size(165, 17);
            this.rbFoodVsSales.TabIndex = 4;
            this.rbFoodVsSales.TabStop = true;
            this.rbFoodVsSales.Text = "Food / Bev Supplies vs Sales";
            this.rbFoodVsSales.UseVisualStyleBackColor = true;
            // 
            // rbPayroll
            // 
            this.rbPayroll.AutoSize = true;
            this.rbPayroll.Location = new System.Drawing.Point(7, 112);
            this.rbPayroll.Name = "rbPayroll";
            this.rbPayroll.Size = new System.Drawing.Size(56, 17);
            this.rbPayroll.TabIndex = 2;
            this.rbPayroll.TabStop = true;
            this.rbPayroll.Text = "Payroll";
            this.rbPayroll.UseVisualStyleBackColor = true;
            // 
            // rbSpld
            // 
            this.rbSpld.AutoSize = true;
            this.rbSpld.Location = new System.Drawing.Point(7, 135);
            this.rbSpld.Name = "rbSpld";
            this.rbSpld.Size = new System.Drawing.Size(129, 17);
            this.rbSpld.TabIndex = 1;
            this.rbSpld.TabStop = true;
            this.rbSpld.Text = "Sales per Labor Dollar";
            this.rbSpld.UseVisualStyleBackColor = true;
            // 
            // rbPnl
            // 
            this.rbPnl.AutoSize = true;
            this.rbPnl.Checked = true;
            this.rbPnl.Location = new System.Drawing.Point(7, 20);
            this.rbPnl.Name = "rbPnl";
            this.rbPnl.Size = new System.Drawing.Size(125, 17);
            this.rbPnl.TabIndex = 0;
            this.rbPnl.TabStop = true;
            this.rbPnl.Text = "PNL (Profit and Loss)";
            this.rbPnl.UseVisualStyleBackColor = true;
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.rbAll);
            this.gbDate.Controls.Add(this.rbYear);
            this.gbDate.Controls.Add(this.rbSixMonth);
            this.gbDate.Controls.Add(this.rbThreeMonth);
            this.gbDate.Location = new System.Drawing.Point(216, 32);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(115, 115);
            this.gbDate.TabIndex = 1;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Date Span";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(6, 89);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(62, 17);
            this.rbAll.TabIndex = 9;
            this.rbAll.Text = "All Time";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Checked = true;
            this.rbYear.Location = new System.Drawing.Point(6, 20);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(70, 17);
            this.rbYear.TabIndex = 8;
            this.rbYear.TabStop = true;
            this.rbYear.Text = "Last Year";
            this.rbYear.UseVisualStyleBackColor = true;
            // 
            // rbSixMonth
            // 
            this.rbSixMonth.AutoSize = true;
            this.rbSixMonth.Location = new System.Drawing.Point(6, 43);
            this.rbSixMonth.Name = "rbSixMonth";
            this.rbSixMonth.Size = new System.Drawing.Size(92, 17);
            this.rbSixMonth.TabIndex = 7;
            this.rbSixMonth.Text = "Last 6 Months";
            this.rbSixMonth.UseVisualStyleBackColor = true;
            // 
            // rbThreeMonth
            // 
            this.rbThreeMonth.AutoSize = true;
            this.rbThreeMonth.Location = new System.Drawing.Point(6, 66);
            this.rbThreeMonth.Name = "rbThreeMonth";
            this.rbThreeMonth.Size = new System.Drawing.Size(92, 17);
            this.rbThreeMonth.TabIndex = 6;
            this.rbThreeMonth.Text = "Last 3 Months";
            this.rbThreeMonth.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(12, 201);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View Report";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(256, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLastFullMonth
            // 
            this.lblLastFullMonth.AutoSize = true;
            this.lblLastFullMonth.Location = new System.Drawing.Point(7, 9);
            this.lblLastFullMonth.Name = "lblLastFullMonth";
            this.lblLastFullMonth.Size = new System.Drawing.Size(128, 13);
            this.lblLastFullMonth.TabIndex = 10;
            this.lblLastFullMonth.Text = "Last Full Month Available:";
            // 
            // lblLastFullMonthVal
            // 
            this.lblLastFullMonthVal.AutoSize = true;
            this.lblLastFullMonthVal.Location = new System.Drawing.Point(130, 9);
            this.lblLastFullMonthVal.Name = "lblLastFullMonthVal";
            this.lblLastFullMonthVal.Size = new System.Drawing.Size(35, 13);
            this.lblLastFullMonthVal.TabIndex = 11;
            this.lblLastFullMonthVal.Text = "label2";
            // 
            // ReportRequestForm
            // 
            this.AcceptButton = this.btnView;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(343, 235);
            this.Controls.Add(this.lblLastFullMonthVal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblLastFullMonth);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.gbDate);
            this.Controls.Add(this.gbReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportRequestForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Request";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportRequestForm_FormClosed);
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.RadioButton rbRestVsCater;
        private System.Windows.Forms.RadioButton rbFoodVsSales;
        private System.Windows.Forms.RadioButton rbPayroll;
        private System.Windows.Forms.RadioButton rbSpld;
        private System.Windows.Forms.RadioButton rbPnl;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.RadioButton rbSixMonth;
        private System.Windows.Forms.RadioButton rbThreeMonth;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLastFullMonth;
        private System.Windows.Forms.Label lblLastFullMonthVal;
        private System.Windows.Forms.RadioButton rbSales;
    }
}