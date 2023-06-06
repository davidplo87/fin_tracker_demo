
namespace _411_Demo_2
{
    partial class DailyTotalsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyTotalsForm));
            this.dgvDailyTotals = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.gbMonthTotals = new System.Windows.Forms.GroupBox();
            this.lblTotalMonthVal = new System.Windows.Forms.Label();
            this.lblCaterMonthVal = new System.Windows.Forms.Label();
            this.lblRestMonthVal = new System.Windows.Forms.Label();
            this.lblTotalMonth = new System.Windows.Forms.Label();
            this.lblCaterMonth = new System.Windows.Forms.Label();
            this.lblRestMonth = new System.Windows.Forms.Label();
            this.dtpTotals = new System.Windows.Forms.DateTimePicker();
            this.gbYearTotals = new System.Windows.Forms.GroupBox();
            this.lblRestYearVal = new System.Windows.Forms.Label();
            this.lblTotalYear = new System.Windows.Forms.Label();
            this.lblCaterYearVal = new System.Windows.Forms.Label();
            this.lblCaterYear = new System.Windows.Forms.Label();
            this.lblTotalYearVal = new System.Windows.Forms.Label();
            this.lblRestYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyTotals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyTotalBindingSource)).BeginInit();
            this.gbMonthTotals.SuspendLayout();
            this.gbYearTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDailyTotals
            // 
            this.dgvDailyTotals.AllowUserToAddRows = false;
            this.dgvDailyTotals.AllowUserToDeleteRows = false;
            this.dgvDailyTotals.AllowUserToResizeColumns = false;
            this.dgvDailyTotals.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDailyTotals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDailyTotals.AutoGenerateColumns = false;
            this.dgvDailyTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyTotals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.DayOfWeek,
            this.shopDataGridViewTextBoxColumn,
            this.caterDataGridViewTextBoxColumn});
            this.dgvDailyTotals.DataSource = this.dailyTotalBindingSource;
            this.dgvDailyTotals.Location = new System.Drawing.Point(12, 12);
            this.dgvDailyTotals.MultiSelect = false;
            this.dgvDailyTotals.Name = "dgvDailyTotals";
            this.dgvDailyTotals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDailyTotals.Size = new System.Drawing.Size(456, 595);
            this.dgvDailyTotals.TabIndex = 0;
            this.dgvDailyTotals.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDailyTotals_CellEndEdit);
            this.dgvDailyTotals.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDailyTotals_DataError);
            this.dgvDailyTotals.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDailyTotals_RowValidating);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.DataPropertyName = "DayOfWeek";
            this.DayOfWeek.HeaderText = "Day Of Week";
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.ReadOnly = true;
            // 
            // shopDataGridViewTextBoxColumn
            // 
            this.shopDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shopDataGridViewTextBoxColumn.DataPropertyName = "Shop";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.shopDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.shopDataGridViewTextBoxColumn.HeaderText = "Restaurant";
            this.shopDataGridViewTextBoxColumn.Name = "shopDataGridViewTextBoxColumn";
            this.shopDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // caterDataGridViewTextBoxColumn
            // 
            this.caterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.caterDataGridViewTextBoxColumn.DataPropertyName = "Cater";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            this.caterDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.caterDataGridViewTextBoxColumn.HeaderText = "Catering";
            this.caterDataGridViewTextBoxColumn.Name = "caterDataGridViewTextBoxColumn";
            this.caterDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dailyTotalBindingSource
            // 
            this.dailyTotalBindingSource.DataSource = typeof(_411_Demo_2.DailyTotal);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(474, 584);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbMonthTotals
            // 
            this.gbMonthTotals.Controls.Add(this.lblTotalMonthVal);
            this.gbMonthTotals.Controls.Add(this.lblCaterMonthVal);
            this.gbMonthTotals.Controls.Add(this.lblRestMonthVal);
            this.gbMonthTotals.Controls.Add(this.lblTotalMonth);
            this.gbMonthTotals.Controls.Add(this.lblCaterMonth);
            this.gbMonthTotals.Controls.Add(this.lblRestMonth);
            this.gbMonthTotals.Location = new System.Drawing.Point(474, 38);
            this.gbMonthTotals.Name = "gbMonthTotals";
            this.gbMonthTotals.Size = new System.Drawing.Size(139, 72);
            this.gbMonthTotals.TabIndex = 4;
            this.gbMonthTotals.TabStop = false;
            this.gbMonthTotals.Text = "Total For Month";
            // 
            // lblTotalMonthVal
            // 
            this.lblTotalMonthVal.Location = new System.Drawing.Point(74, 50);
            this.lblTotalMonthVal.Name = "lblTotalMonthVal";
            this.lblTotalMonthVal.Size = new System.Drawing.Size(59, 13);
            this.lblTotalMonthVal.TabIndex = 6;
            this.lblTotalMonthVal.Text = "label9";
            this.lblTotalMonthVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCaterMonthVal
            // 
            this.lblCaterMonthVal.Location = new System.Drawing.Point(74, 33);
            this.lblCaterMonthVal.Name = "lblCaterMonthVal";
            this.lblCaterMonthVal.Size = new System.Drawing.Size(59, 13);
            this.lblCaterMonthVal.TabIndex = 5;
            this.lblCaterMonthVal.Text = "label8";
            this.lblCaterMonthVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRestMonthVal
            // 
            this.lblRestMonthVal.Location = new System.Drawing.Point(74, 16);
            this.lblRestMonthVal.Name = "lblRestMonthVal";
            this.lblRestMonthVal.Size = new System.Drawing.Size(59, 13);
            this.lblRestMonthVal.TabIndex = 4;
            this.lblRestMonthVal.Text = "label7";
            this.lblRestMonthVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMonth
            // 
            this.lblTotalMonth.AutoSize = true;
            this.lblTotalMonth.Location = new System.Drawing.Point(6, 50);
            this.lblTotalMonth.Name = "lblTotalMonth";
            this.lblTotalMonth.Size = new System.Drawing.Size(34, 13);
            this.lblTotalMonth.TabIndex = 3;
            this.lblTotalMonth.Text = "Total:";
            // 
            // lblCaterMonth
            // 
            this.lblCaterMonth.AutoSize = true;
            this.lblCaterMonth.Location = new System.Drawing.Point(6, 33);
            this.lblCaterMonth.Name = "lblCaterMonth";
            this.lblCaterMonth.Size = new System.Drawing.Size(49, 13);
            this.lblCaterMonth.TabIndex = 2;
            this.lblCaterMonth.Text = "Catering:";
            // 
            // lblRestMonth
            // 
            this.lblRestMonth.AutoSize = true;
            this.lblRestMonth.Location = new System.Drawing.Point(6, 16);
            this.lblRestMonth.Name = "lblRestMonth";
            this.lblRestMonth.Size = new System.Drawing.Size(62, 13);
            this.lblRestMonth.TabIndex = 1;
            this.lblRestMonth.Text = "Restaurant:";
            // 
            // dtpTotals
            // 
            this.dtpTotals.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTotals.Location = new System.Drawing.Point(474, 12);
            this.dtpTotals.Name = "dtpTotals";
            this.dtpTotals.Size = new System.Drawing.Size(139, 20);
            this.dtpTotals.TabIndex = 0;
            this.dtpTotals.Value = new System.DateTime(2022, 11, 28, 20, 14, 20, 0);
            this.dtpTotals.ValueChanged += new System.EventHandler(this.dtpTotals_ValueChanged);
            // 
            // gbYearTotals
            // 
            this.gbYearTotals.Controls.Add(this.lblRestYearVal);
            this.gbYearTotals.Controls.Add(this.lblTotalYear);
            this.gbYearTotals.Controls.Add(this.lblCaterYearVal);
            this.gbYearTotals.Controls.Add(this.lblCaterYear);
            this.gbYearTotals.Controls.Add(this.lblTotalYearVal);
            this.gbYearTotals.Controls.Add(this.lblRestYear);
            this.gbYearTotals.Location = new System.Drawing.Point(474, 116);
            this.gbYearTotals.Name = "gbYearTotals";
            this.gbYearTotals.Size = new System.Drawing.Size(139, 75);
            this.gbYearTotals.TabIndex = 5;
            this.gbYearTotals.TabStop = false;
            this.gbYearTotals.Text = "Totals For Year";
            // 
            // lblRestYearVal
            // 
            this.lblRestYearVal.Location = new System.Drawing.Point(68, 16);
            this.lblRestYearVal.Name = "lblRestYearVal";
            this.lblRestYearVal.Size = new System.Drawing.Size(65, 13);
            this.lblRestYearVal.TabIndex = 9;
            this.lblRestYearVal.Text = "label10";
            this.lblRestYearVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalYear
            // 
            this.lblTotalYear.AutoSize = true;
            this.lblTotalYear.Location = new System.Drawing.Point(7, 50);
            this.lblTotalYear.Name = "lblTotalYear";
            this.lblTotalYear.Size = new System.Drawing.Size(34, 13);
            this.lblTotalYear.TabIndex = 3;
            this.lblTotalYear.Text = "Total:";
            // 
            // lblCaterYearVal
            // 
            this.lblCaterYearVal.Location = new System.Drawing.Point(68, 33);
            this.lblCaterYearVal.Name = "lblCaterYearVal";
            this.lblCaterYearVal.Size = new System.Drawing.Size(65, 13);
            this.lblCaterYearVal.TabIndex = 8;
            this.lblCaterYearVal.Text = "label11";
            this.lblCaterYearVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCaterYear
            // 
            this.lblCaterYear.AutoSize = true;
            this.lblCaterYear.Location = new System.Drawing.Point(7, 33);
            this.lblCaterYear.Name = "lblCaterYear";
            this.lblCaterYear.Size = new System.Drawing.Size(49, 13);
            this.lblCaterYear.TabIndex = 2;
            this.lblCaterYear.Text = "Catering:";
            // 
            // lblTotalYearVal
            // 
            this.lblTotalYearVal.Location = new System.Drawing.Point(68, 50);
            this.lblTotalYearVal.Name = "lblTotalYearVal";
            this.lblTotalYearVal.Size = new System.Drawing.Size(65, 13);
            this.lblTotalYearVal.TabIndex = 7;
            this.lblTotalYearVal.Text = "label12";
            this.lblTotalYearVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRestYear
            // 
            this.lblRestYear.AutoSize = true;
            this.lblRestYear.Location = new System.Drawing.Point(7, 16);
            this.lblRestYear.Name = "lblRestYear";
            this.lblRestYear.Size = new System.Drawing.Size(62, 13);
            this.lblRestYear.TabIndex = 1;
            this.lblRestYear.Text = "Restaurant:";
            // 
            // DailyTotalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(625, 619);
            this.Controls.Add(this.gbYearTotals);
            this.Controls.Add(this.gbMonthTotals);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvDailyTotals);
            this.Controls.Add(this.dtpTotals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DailyTotalsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Totals";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TotalsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DailyTotalsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyTotals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyTotalBindingSource)).EndInit();
            this.gbMonthTotals.ResumeLayout(false);
            this.gbMonthTotals.PerformLayout();
            this.gbYearTotals.ResumeLayout(false);
            this.gbYearTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDailyTotals;
        private System.Windows.Forms.BindingSource dailyTotalBindingSource;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbMonthTotals;
        private System.Windows.Forms.Label lblTotalMonthVal;
        private System.Windows.Forms.Label lblCaterMonthVal;
        private System.Windows.Forms.Label lblRestMonthVal;
        private System.Windows.Forms.Label lblTotalMonth;
        private System.Windows.Forms.Label lblCaterMonth;
        private System.Windows.Forms.Label lblRestMonth;
        private System.Windows.Forms.GroupBox gbYearTotals;
        private System.Windows.Forms.Label lblRestYearVal;
        private System.Windows.Forms.Label lblTotalYear;
        private System.Windows.Forms.Label lblCaterYearVal;
        private System.Windows.Forms.Label lblCaterYear;
        private System.Windows.Forms.Label lblTotalYearVal;
        private System.Windows.Forms.Label lblRestYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpTotals;
    }
}