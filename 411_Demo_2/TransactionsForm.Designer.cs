
namespace _411_Demo_2
{
    partial class TransactionsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDaysSinceVal = new System.Windows.Forms.Label();
            this.lblDaysSince = new System.Windows.Forms.Label();
            this.gbCat = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbPersonal = new System.Windows.Forms.RadioButton();
            this.rbUtilRent = new System.Windows.Forms.RadioButton();
            this.rbPayroll = new System.Windows.Forms.RadioButton();
            this.rbFoodBev = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.rbCat = new System.Windows.Forms.RadioButton();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCheck = new System.Windows.Forms.GroupBox();
            this.cbOnlyChecks = new System.Windows.Forms.CheckBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.linkDownload = new System.Windows.Forms.LinkLabel();
            this.linkImport = new System.Windows.Forms.LinkLabel();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.gbCat.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.gbPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.gbCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToResizeColumns = false;
            this.dgvTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.checkNumDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.categoryDataDataGridViewComboBoxColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTransactions.Location = new System.Drawing.Point(169, 12);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTransactions.ShowEditingIcon = false;
            this.dgvTransactions.Size = new System.Drawing.Size(1050, 571);
            this.dgvTransactions.TabIndex = 0;
            this.dgvTransactions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellEndEdit);
            this.dgvTransactions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTransactions_CellFormatting);
            this.dgvTransactions.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTransactions_ColumnHeaderMouseClick);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle3.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // checkNumDataGridViewTextBoxColumn
            // 
            this.checkNumDataGridViewTextBoxColumn.DataPropertyName = "CheckNum";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.NullValue = null;
            this.checkNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.checkNumDataGridViewTextBoxColumn.HeaderText = "Check #";
            this.checkNumDataGridViewTextBoxColumn.Name = "checkNumDataGridViewTextBoxColumn";
            this.checkNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkNumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // categoryDataDataGridViewComboBoxColumn
            // 
            this.categoryDataDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categoryDataDataGridViewComboBoxColumn.DataPropertyName = "Category";
            this.categoryDataDataGridViewComboBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryDataDataGridViewComboBoxColumn.HeaderText = "Category";
            this.categoryDataDataGridViewComboBoxColumn.Items.AddRange(new object[] {
            "Uncategorized",
            "Deposit",
            "Utility / Rent",
            "Food / Bev Supply",
            "Personal Expense",
            "Other Business Expense",
            "Payroll"});
            this.categoryDataDataGridViewComboBoxColumn.Name = "categoryDataDataGridViewComboBoxColumn";
            this.categoryDataDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.categoryDataDataGridViewComboBoxColumn.Width = 74;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 589);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(148, 23);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import Bank Activity";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnExit.Location = new System.Drawing.Point(1122, 589);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDaysSinceVal
            // 
            this.lblDaysSinceVal.AutoSize = true;
            this.lblDaysSinceVal.Location = new System.Drawing.Point(309, 594);
            this.lblDaysSinceVal.Name = "lblDaysSinceVal";
            this.lblDaysSinceVal.Size = new System.Drawing.Size(35, 13);
            this.lblDaysSinceVal.TabIndex = 19;
            this.lblDaysSinceVal.Text = "label6";
            // 
            // lblDaysSince
            // 
            this.lblDaysSince.AutoSize = true;
            this.lblDaysSince.Location = new System.Drawing.Point(166, 594);
            this.lblDaysSince.Name = "lblDaysSince";
            this.lblDaysSince.Size = new System.Drawing.Size(146, 13);
            this.lblDaysSince.TabIndex = 18;
            this.lblDaysSince.Text = "Days Since Last Transaction:";
            // 
            // gbCat
            // 
            this.gbCat.Controls.Add(this.rbAll);
            this.gbCat.Controls.Add(this.rbOther);
            this.gbCat.Controls.Add(this.rbPersonal);
            this.gbCat.Controls.Add(this.rbUtilRent);
            this.gbCat.Controls.Add(this.rbPayroll);
            this.gbCat.Controls.Add(this.rbFoodBev);
            this.gbCat.Controls.Add(this.rbDeposit);
            this.gbCat.Controls.Add(this.rbCat);
            this.gbCat.Location = new System.Drawing.Point(12, 12);
            this.gbCat.Name = "gbCat";
            this.gbCat.Size = new System.Drawing.Size(148, 210);
            this.gbCat.TabIndex = 3;
            this.gbCat.TabStop = false;
            this.gbCat.Text = "Category";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(6, 181);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(89, 17);
            this.rbAll.TabIndex = 9;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All Categories";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(6, 158);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(140, 17);
            this.rbOther.TabIndex = 7;
            this.rbOther.Text = "Other Business Expense";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbPersonal
            // 
            this.rbPersonal.AutoSize = true;
            this.rbPersonal.Location = new System.Drawing.Point(6, 135);
            this.rbPersonal.Name = "rbPersonal";
            this.rbPersonal.Size = new System.Drawing.Size(110, 17);
            this.rbPersonal.TabIndex = 6;
            this.rbPersonal.Text = "Personal Expense";
            this.rbPersonal.UseVisualStyleBackColor = true;
            // 
            // rbUtilRent
            // 
            this.rbUtilRent.AutoSize = true;
            this.rbUtilRent.Location = new System.Drawing.Point(6, 112);
            this.rbUtilRent.Name = "rbUtilRent";
            this.rbUtilRent.Size = new System.Drawing.Size(84, 17);
            this.rbUtilRent.TabIndex = 5;
            this.rbUtilRent.Text = "Utility / Rent";
            this.rbUtilRent.UseVisualStyleBackColor = true;
            // 
            // rbPayroll
            // 
            this.rbPayroll.AutoSize = true;
            this.rbPayroll.Location = new System.Drawing.Point(6, 89);
            this.rbPayroll.Name = "rbPayroll";
            this.rbPayroll.Size = new System.Drawing.Size(56, 17);
            this.rbPayroll.TabIndex = 4;
            this.rbPayroll.Text = "Payroll";
            this.rbPayroll.UseVisualStyleBackColor = true;
            // 
            // rbFoodBev
            // 
            this.rbFoodBev.AutoSize = true;
            this.rbFoodBev.Location = new System.Drawing.Point(7, 66);
            this.rbFoodBev.Name = "rbFoodBev";
            this.rbFoodBev.Size = new System.Drawing.Size(114, 17);
            this.rbFoodBev.TabIndex = 2;
            this.rbFoodBev.Text = "Food / Bev Supply";
            this.rbFoodBev.UseVisualStyleBackColor = true;
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Location = new System.Drawing.Point(7, 43);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(61, 17);
            this.rbDeposit.TabIndex = 1;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // rbCat
            // 
            this.rbCat.AutoSize = true;
            this.rbCat.Location = new System.Drawing.Point(7, 20);
            this.rbCat.Name = "rbCat";
            this.rbCat.Size = new System.Drawing.Size(94, 17);
            this.rbCat.TabIndex = 0;
            this.rbCat.Text = "Uncategorized";
            this.rbCat.UseVisualStyleBackColor = true;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.txtbSearch);
            this.gbSearch.Location = new System.Drawing.Point(12, 228);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(148, 51);
            this.gbSearch.TabIndex = 26;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // txtbSearch
            // 
            this.txtbSearch.Location = new System.Drawing.Point(7, 19);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(134, 20);
            this.txtbSearch.TabIndex = 25;
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.label1);
            this.gbDate.Controls.Add(this.dtpEnd);
            this.gbDate.Controls.Add(this.dtpStart);
            this.gbDate.Location = new System.Drawing.Point(12, 285);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(148, 91);
            this.gbDate.TabIndex = 20;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Date Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Through:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(7, 58);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(136, 20);
            this.dtpEnd.TabIndex = 1;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(7, 19);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(136, 20);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.nudMax);
            this.gbPrice.Controls.Add(this.nudMin);
            this.gbPrice.Controls.Add(this.label2);
            this.gbPrice.Location = new System.Drawing.Point(12, 382);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(148, 89);
            this.gbPrice.TabIndex = 21;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "Price Range";
            // 
            // nudMax
            // 
            this.nudMax.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMax.Location = new System.Drawing.Point(7, 58);
            this.nudMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(136, 20);
            this.nudMax.TabIndex = 4;
            this.nudMax.ValueChanged += new System.EventHandler(this.nudMax_ValueChanged);
            // 
            // nudMin
            // 
            this.nudMin.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMin.Location = new System.Drawing.Point(7, 19);
            this.nudMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(136, 20);
            this.nudMin.TabIndex = 3;
            this.nudMin.ValueChanged += new System.EventHandler(this.nudMin_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Through:";
            // 
            // gbCheck
            // 
            this.gbCheck.Controls.Add(this.cbOnlyChecks);
            this.gbCheck.Location = new System.Drawing.Point(12, 477);
            this.gbCheck.Name = "gbCheck";
            this.gbCheck.Size = new System.Drawing.Size(148, 48);
            this.gbCheck.TabIndex = 24;
            this.gbCheck.TabStop = false;
            this.gbCheck.Text = "Check";
            // 
            // cbOnlyChecks
            // 
            this.cbOnlyChecks.AutoSize = true;
            this.cbOnlyChecks.Location = new System.Drawing.Point(7, 20);
            this.cbOnlyChecks.Name = "cbOnlyChecks";
            this.cbOnlyChecks.Size = new System.Drawing.Size(116, 17);
            this.cbOnlyChecks.TabIndex = 0;
            this.cbOnlyChecks.Text = "Only Show Checks";
            this.cbOnlyChecks.UseVisualStyleBackColor = true;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(12, 560);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(148, 23);
            this.btnResetFilter.TabIndex = 23;
            this.btnResetFilter.Text = "Reset Filter";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyFilter.Location = new System.Drawing.Point(12, 531);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(148, 23);
            this.btnApplyFilter.TabIndex = 22;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // linkDownload
            // 
            this.linkDownload.AutoSize = true;
            this.linkDownload.Location = new System.Drawing.Point(707, 594);
            this.linkDownload.Name = "linkDownload";
            this.linkDownload.Size = new System.Drawing.Size(211, 13);
            this.linkDownload.TabIndex = 27;
            this.linkDownload.TabStop = true;
            this.linkDownload.Text = "I Need Help Downloading My Bank Activity";
            this.linkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDownload_LinkClicked);
            // 
            // linkImport
            // 
            this.linkImport.AutoSize = true;
            this.linkImport.Location = new System.Drawing.Point(924, 594);
            this.linkImport.Name = "linkImport";
            this.linkImport.Size = new System.Drawing.Size(192, 13);
            this.linkImport.TabIndex = 28;
            this.linkImport.TabStop = true;
            this.linkImport.Text = "I Need Help Importing My Bank Activity";
            this.linkImport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkImport_LinkClicked);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(_411_Demo_2.Transaction);
            // 
            // TransactionsForm
            // 
            this.AcceptButton = this.btnApplyFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1231, 619);
            this.Controls.Add(this.linkImport);
            this.Controls.Add(this.linkDownload);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResetFilter);
            this.Controls.Add(this.gbCheck);
            this.Controls.Add(this.lblDaysSince);
            this.Controls.Add(this.gbPrice);
            this.Controls.Add(this.lblDaysSinceVal);
            this.Controls.Add(this.gbDate);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TransactionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransactionsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.gbCat.ResumeLayout(false);
            this.gbCat.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.gbCheck.ResumeLayout(false);
            this.gbCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDaysSinceVal;
        private System.Windows.Forms.Label lblDaysSince;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.GroupBox gbCat;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbPersonal;
        private System.Windows.Forms.RadioButton rbUtilRent;
        private System.Windows.Forms.RadioButton rbPayroll;
        private System.Windows.Forms.RadioButton rbFoodBev;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.RadioButton rbCat;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCheck;
        private System.Windows.Forms.CheckBox cbOnlyChecks;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryDataDataGridViewComboBoxColumn;
        private System.Windows.Forms.LinkLabel linkDownload;
        private System.Windows.Forms.LinkLabel linkImport;
    }
}