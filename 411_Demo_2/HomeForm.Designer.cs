
namespace _411_Demo_2
{
    partial class HomeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnReports = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnDaily = new System.Windows.Forms.Button();
            this.lblUncat = new System.Windows.Forms.Label();
            this.lblDaysSince = new System.Windows.Forms.Label();
            this.lblUncatVal = new System.Windows.Forms.Label();
            this.lblDaySinceVal = new System.Windows.Forms.Label();
            this.gbView = new System.Windows.Forms.GroupBox();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.gbPnl = new System.Windows.Forms.GroupBox();
            this.lblProfVal = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblExpVal = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblSalesVal = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.chrtProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.chrtAllSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbView.SuspendLayout();
            this.gbPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAllSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnReports.Location = new System.Drawing.Point(6, 19);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(92, 23);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 24);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Daddy\'s Main Street (DEMO VERSION)";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnHelp.Location = new System.Drawing.Point(6, 48);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(92, 23);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnDaily
            // 
            this.btnDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDaily.Location = new System.Drawing.Point(104, 48);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(111, 23);
            this.btnDaily.TabIndex = 10;
            this.btnDaily.Text = "Daily Totals";
            this.btnDaily.UseVisualStyleBackColor = true;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // lblUncat
            // 
            this.lblUncat.AutoSize = true;
            this.lblUncat.Location = new System.Drawing.Point(221, 24);
            this.lblUncat.Name = "lblUncat";
            this.lblUncat.Size = new System.Drawing.Size(79, 13);
            this.lblUncat.TabIndex = 11;
            this.lblUncat.Text = "Uncategorized:";
            // 
            // lblDaysSince
            // 
            this.lblDaysSince.AutoSize = true;
            this.lblDaysSince.Location = new System.Drawing.Point(221, 53);
            this.lblDaysSince.Name = "lblDaysSince";
            this.lblDaysSince.Size = new System.Drawing.Size(104, 13);
            this.lblDaysSince.TabIndex = 12;
            this.lblDaysSince.Text = "Days Since Entered:";
            // 
            // lblUncatVal
            // 
            this.lblUncatVal.Location = new System.Drawing.Point(331, 24);
            this.lblUncatVal.Name = "lblUncatVal";
            this.lblUncatVal.Size = new System.Drawing.Size(32, 13);
            this.lblUncatVal.TabIndex = 13;
            this.lblUncatVal.Text = "13";
            this.lblUncatVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDaySinceVal
            // 
            this.lblDaySinceVal.Location = new System.Drawing.Point(331, 53);
            this.lblDaySinceVal.Name = "lblDaySinceVal";
            this.lblDaySinceVal.Size = new System.Drawing.Size(32, 13);
            this.lblDaySinceVal.TabIndex = 14;
            this.lblDaySinceVal.Text = "14";
            this.lblDaySinceVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbView
            // 
            this.gbView.Controls.Add(this.lblUncatVal);
            this.gbView.Controls.Add(this.btnHelp);
            this.gbView.Controls.Add(this.btnTransactions);
            this.gbView.Controls.Add(this.lblUncat);
            this.gbView.Controls.Add(this.btnReports);
            this.gbView.Controls.Add(this.lblDaySinceVal);
            this.gbView.Controls.Add(this.lblDaysSince);
            this.gbView.Controls.Add(this.btnDaily);
            this.gbView.Location = new System.Drawing.Point(12, 36);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(370, 79);
            this.gbView.TabIndex = 16;
            this.gbView.TabStop = false;
            this.gbView.Text = "View";
            // 
            // btnTransactions
            // 
            this.btnTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTransactions.Location = new System.Drawing.Point(104, 19);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(111, 23);
            this.btnTransactions.TabIndex = 15;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.button4_Click);
            // 
            // gbPnl
            // 
            this.gbPnl.Controls.Add(this.lblProfVal);
            this.gbPnl.Controls.Add(this.lblProfit);
            this.gbPnl.Controls.Add(this.lblExpVal);
            this.gbPnl.Controls.Add(this.lblExp);
            this.gbPnl.Controls.Add(this.lblSalesVal);
            this.gbPnl.Controls.Add(this.lblSales);
            this.gbPnl.Location = new System.Drawing.Point(388, 36);
            this.gbPnl.Name = "gbPnl";
            this.gbPnl.Size = new System.Drawing.Size(220, 79);
            this.gbPnl.TabIndex = 17;
            this.gbPnl.TabStop = false;
            this.gbPnl.Text = "PNL Report";
            // 
            // lblProfVal
            // 
            this.lblProfVal.ForeColor = System.Drawing.Color.Blue;
            this.lblProfVal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblProfVal.Location = new System.Drawing.Point(84, 58);
            this.lblProfVal.Name = "lblProfVal";
            this.lblProfVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProfVal.Size = new System.Drawing.Size(130, 13);
            this.lblProfVal.TabIndex = 5;
            this.lblProfVal.Text = "Profit Value";
            this.lblProfVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(7, 58);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(37, 13);
            this.lblProfit.TabIndex = 4;
            this.lblProfit.Text = "Profit: ";
            // 
            // lblExpVal
            // 
            this.lblExpVal.ForeColor = System.Drawing.Color.Red;
            this.lblExpVal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblExpVal.Location = new System.Drawing.Point(84, 39);
            this.lblExpVal.Name = "lblExpVal";
            this.lblExpVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExpVal.Size = new System.Drawing.Size(130, 13);
            this.lblExpVal.TabIndex = 3;
            this.lblExpVal.Text = "Expense Value";
            this.lblExpVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(7, 39);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(59, 13);
            this.lblExp.TabIndex = 2;
            this.lblExp.Text = "Expenses: ";
            // 
            // lblSalesVal
            // 
            this.lblSalesVal.ForeColor = System.Drawing.Color.Green;
            this.lblSalesVal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSalesVal.Location = new System.Drawing.Point(84, 20);
            this.lblSalesVal.Name = "lblSalesVal";
            this.lblSalesVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSalesVal.Size = new System.Drawing.Size(130, 13);
            this.lblSalesVal.TabIndex = 1;
            this.lblSalesVal.Text = "Sales Value";
            this.lblSalesVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(7, 20);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(39, 13);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Sales: ";
            // 
            // chrtProfit
            // 
            chartArea1.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea1.Name = "ChartArea1";
            this.chrtProfit.ChartAreas.Add(chartArea1);
            this.chrtProfit.DataSource = this.transactionBindingSource;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chrtProfit.Legends.Add(legend1);
            this.chrtProfit.Location = new System.Drawing.Point(12, 129);
            this.chrtProfit.Name = "chrtProfit";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Date";
            series1.YValueMembers = "Amount";
            this.chrtProfit.Series.Add(series1);
            this.chrtProfit.Size = new System.Drawing.Size(1087, 300);
            this.chrtProfit.TabIndex = 18;
            this.chrtProfit.Text = "PNL (YTD)";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "pnl";
            title1.Text = "Profit";
            this.chrtProfit.Titles.Add(title1);
            
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(_411_Demo_2.Transaction);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1024, 742);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chrtAllSales
            // 
            chartArea2.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea2.Name = "ChartArea1";
            this.chrtAllSales.ChartAreas.Add(chartArea2);
            this.chrtAllSales.DataSource = this.transactionBindingSource;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chrtAllSales.Legends.Add(legend2);
            this.chrtAllSales.Location = new System.Drawing.Point(12, 436);
            this.chrtAllSales.Name = "chrtAllSales";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "Date";
            series2.YValueMembers = "Amount";
            this.chrtAllSales.Series.Add(series2);
            this.chrtAllSales.Size = new System.Drawing.Size(1087, 300);
            this.chrtAllSales.TabIndex = 20;
            this.chrtAllSales.Text = "PNL (YTD)";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title2.Name = "sales";
            title2.Text = "All Sales";
            this.chrtAllSales.Titles.Add(title2);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1111, 777);
            this.Controls.Add(this.chrtAllSales);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chrtProfit);
            this.Controls.Add(this.gbPnl);
            this.Controls.Add(this.gbView);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HomeForm_Paint);
            this.gbView.ResumeLayout(false);
            this.gbView.PerformLayout();
            this.gbPnl.ResumeLayout(false);
            this.gbPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAllSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Label lblUncat;
        private System.Windows.Forms.Label lblDaysSince;
        private System.Windows.Forms.Label lblUncatVal;
        private System.Windows.Forms.Label lblDaySinceVal;
        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.GroupBox gbPnl;
        private System.Windows.Forms.Label lblSalesVal;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblExpVal;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblProfVal;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtProfit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAllSales;
    }
}

