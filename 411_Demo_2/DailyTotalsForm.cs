using System;
using System.Linq;
using System.Windows.Forms;

namespace _411_Demo_2
{
    public partial class DailyTotalsForm : Form
    {
        public HomeForm ReturnWindow { get; set; }

        public DailyTotalsForm()
        {
            InitializeComponent();
            DailyTotalLister.FillList();
            DailyTotalLister.SortByDateDescending();
            BindMasterList();
            FormatPicker();
            UpdateTotalsLabels();
        }

        private void FormatPicker()
        {
            dtpTotals.Format = DateTimePickerFormat.Custom;
            dtpTotals.CustomFormat = "MMM yyyy";
            dtpTotals.ShowUpDown = true;
            dtpTotals.Value = DateTime.Today;
            dtpTotals.MaxDate = DateTime.Today;
            dtpTotals.MinDate = DailyTotalLister.MasterList.Min(x => x.Date);
        }

        private void UpdateTotalsLabels()
        {
            lblRestMonthVal.Text = DailyTotalLister.TotalForMonthShop(dtpTotals.Value).ToString("c0");
            lblCaterMonthVal.Text = DailyTotalLister.TotalForMonthCater(dtpTotals.Value).ToString("c0");
            lblTotalMonthVal.Text = DailyTotalLister.TotalForMonthBoth(dtpTotals.Value).ToString("c0");

            lblRestYearVal.Text = DailyTotalLister.TotalForYearShop(dtpTotals.Value).ToString("c0");
            lblCaterYearVal.Text = DailyTotalLister.TotalForYearCater(dtpTotals.Value).ToString("c0");
            lblTotalYearVal.Text = DailyTotalLister.TotalForYearBoth(dtpTotals.Value).ToString("c0");
        }

        private void BindMasterList()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DailyTotalLister.MasterList;
            dgvDailyTotals.DataSource = bs;
        }

        //this is fired if a value inside cell is changed
        private void dgvDailyTotals_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DailyTotalLister.MasterList[e.RowIndex].Shop = decimal.Parse(dgvDailyTotals[2, e.RowIndex].Value.ToString());
            }
            else if (e.ColumnIndex == 3)
            {
                DailyTotalLister.MasterList[e.RowIndex].Cater = decimal.Parse(dgvDailyTotals[3, e.RowIndex].Value.ToString());
            }
            dgvDailyTotals.Rows[e.RowIndex].ErrorText = string.Empty;
            dtpTotals.Value = DailyTotalLister.MasterList[e.RowIndex].Date;
            UpdateTotalsLabels();
        }

        private void TotalsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Report.SetLatestFullMonth();
            DailyTotalLister.WriteMasterFile();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDailyTotals_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvDailyTotals.Rows[e.RowIndex].ErrorText = "Your Input Was Invalid\nMust Be a Number";
            e.Cancel = true;
        }

        private void dgvDailyTotals_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvDailyTotals.DataBindings.Count > 0)
            {
                dgvDailyTotals.Rows[e.RowIndex].ErrorText = "Your Input Was Invalid\nMust Be a Number";
                e.Cancel = true;
            }
        }

        private void dtpTotals_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalsLabels();
        }

        private void DailyTotalsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReturnWindow.Show();
        }
    }
}
