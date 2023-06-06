using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _411_Demo_2
{
    public partial class HomeForm : Form
    {
        const int MONTHS_SHOWN = 5;
        public HomeForm()
        {
            InitializeComponent();
            
            FileStuff.CheckFiles();
            ReadInFiles();

            Report.SetLatestFullMonth();

            SetStatLabels();
            SetPnlLabels();
            SetPnlChart();
            SetSalesChart();
        }
        private static void ReadInFiles()
        {
            TransLister.ReadMasterFile(FileStuff.DirPath + "//master.csv");
            DailyTotalLister.ReadDailyTotalFile(FileStuff.DirPath + "//daily.csv");
            CatSet.ReadInKeys();
        }
        private void SetPnlChart()
        {
            chrtProfit.Series.Clear();
            chrtProfit.Series.Add(Report.ProfitSeries(MONTHS_SHOWN));
            chrtProfit.ChartAreas[0].AxisY.LabelStyle.Format = "c0";
            chrtProfit.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
            chrtProfit.ChartAreas[0].AxisX.Interval = 1;
            chrtProfit.Series[0].IsVisibleInLegend = true;
            chrtProfit.Invalidate();
        }
        private void SetStatLabels()
        {
            lblDaySinceVal.Text = DailyTotalLister.NumDaysSinceEntered().ToString();
            lblUncatVal.Text = TransLister.NumUncategorized().ToString();
            if (Convert.ToInt32(lblDaySinceVal.Text) > 30)
            {
                lblDaySinceVal.ForeColor = Color.Red;
                lblDaysSince.ForeColor = Color.Red;
            }
            else 
            {
                lblDaySinceVal.ForeColor = Color.Black;
                lblDaysSince.ForeColor = Color.Black;
            }
        }
        private void SetSalesChart()
        {
            chrtAllSales.Series.Clear();
            chrtAllSales.Series.Add(Report.AllSalesSeries(MONTHS_SHOWN));
            chrtAllSales.Series.Add(Report.ShopSalesSeries(MONTHS_SHOWN));
            chrtAllSales.Series.Add(Report.CaterSalesSeries(MONTHS_SHOWN));

            chrtAllSales.ChartAreas[0].AxisY.LabelStyle.Format = "c0";
            chrtAllSales.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
            chrtAllSales.ChartAreas[0].AxisX.Interval = 1;

            foreach(var s in chrtAllSales.Series)
            {
                s.IsVisibleInLegend = true;
            }

            chrtAllSales.Invalidate();
        }

        private void SetPnlLabels()
        {
            gbPnl.Text = "PNL Report for " + Report.LatestFullMonth.AddMonths(- MONTHS_SHOWN).ToString("MMM/yyyy") + " - " + Report.LatestFullMonth.ToString("MMM/yyyy");
            var profit = Report.Profit(MONTHS_SHOWN);
            var loss = Report.Loss(MONTHS_SHOWN);
            lblSalesVal.Text = profit.ToString("c0");
            lblExpVal.Text = loss.ToString("c0");
            lblProfVal.Text = (profit + loss).ToString("c0");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new TransactionsForm();
            f.ReturnWindow = this;
            f.Show();
            this.Hide();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            var t = new DailyTotalsForm();
            t.ReturnWindow = this;
            t.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var f = new ReportRequestForm();
            f.ReturnWindow = this;
            f.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeForm_Paint(object sender, PaintEventArgs e)
        {
            SetPnlLabels();
            SetSalesChart();
            SetStatLabels();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ;
        }

        
    }
}
