using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace _411_Demo_2
{
    public partial class ReportRequestForm : Form
    {
        public HomeForm ReturnWindow { get; set; }
        public ReportRequestForm()
        {
            InitializeComponent();
            SetLastFullMonthLabel(Report.LatestFullMonth);
        }

        private void SetLastFullMonthLabel(DateTime date)
        {
            lblLastFullMonthVal.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(date.Month) + ", " + date.Year.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var checkedReport = gbReport.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var checkedDateRange = gbDate.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            GenerateReport(checkedReport, checkedDateRange);
        }

        private void GenerateReport(RadioButton report, RadioButton dateRange)
        {
            if(dateRange == rbThreeMonth)
            {
                int months = 3;

                if (report == rbPnl)
                {
                    ShowPNL(months, report.Text);
                }
                if (report == rbSpld)
                {
                    //ShowPPLD(months, report.Text);
                }
                if (report == rbPayroll)
                { 
                    ShowPayroll(months, report.Text);
                }
                if (report == rbFoodVsSales)
                {
                    ShowFoodVsSales(months, report.Text);
                }
                if (report == rbRestVsCater)
                {
                    ShowRestVsCater(months, report.Text);
                }
                if (report == rbSales)
                {
                    ShowSales(months, report.Text);
                }
            }
            if(dateRange == rbSixMonth)
            {
                int months = 6;
                if (report == rbPnl)
                {
                    ShowPNL(months, report.Text);
                }
                if (report == rbSpld)
                {
                    //ShowPPLD(months, report.Text);
                }
                if (report == rbPayroll)
                {
                    ShowPayroll(months, report.Text); 
                }
                if (report == rbFoodVsSales)
                {
                    ShowFoodVsSales(months, report.Text);
                }
                if(report == rbRestVsCater)
                {
                    ShowRestVsCater(months, report.Text);
                }
                if (report == rbSales)
                {
                    ShowSales(months, report.Text);
                }
            }
            if (dateRange == rbYear)
            {
                int months = 12;
                if (report == rbPnl)
                {
                    ShowPNL(months, report.Text);
                }
                if (report == rbSpld)
                {
                    //ShowPPLD(months, report.Text);
                }
                if (report == rbPayroll)
                {
                    ShowPayroll(months, report.Text);
                }
                if (report == rbFoodVsSales)
                {
                    ShowFoodVsSales(months, report.Text);
                }
                if (report == rbRestVsCater)
                {
                    ShowRestVsCater(months, report.Text);
                }
                if (report == rbSales)
                {
                    ShowSales(months, report.Text);
                }
            }
            if (dateRange == rbAll)
            {
                
                if (report == rbPnl)
                {
                    ReportResultForm.Description = report.Text +
                        " for: " + 
                        TransLister.MasterList.Min(x=>x.Date).ToString("MM/yyyy") + 
                        " - " + 
                        Report.LatestFullMonth.ToString("MM/yyyy");

                    ReportResultForm.series = Report.ProfitSeries();

                    int sales = Report.Profit();
                    int loss = Report.Loss();
                    int pnl = sales + loss;

                    ReportResultForm.Lines = new List<string>();
                    ReportResultForm.Lines.Add("Sales: " + sales.ToString("c0"));
                    ReportResultForm.Lines.Add("Expenses: " + loss.ToString("c0"));
                    ReportResultForm.Lines.Add("Profit: " + pnl.ToString("c0"));

                    var f = new ReportResultForm();
                    f.ShowDialog();
                }
                /*if(report == rbSpld)
                {
                    ReportResultForm.Description = report.Text +
                        " for: " +
                        TransLister.MasterList.Min(x => x.Date).ToString("MM/yyyy") +
                        " - " +
                        Report.LatestFullMonth.ToString("MM/yyyy");

                    //ReportResultForm.series = Report.SpldSeries();

                    decimal sales = Report.Profit();
                    decimal laborCost = Report.LaborCost();
                    decimal ppld = sales / -laborCost;

                    ReportResultForm.Lines = new List<string>();
                    ReportResultForm.Lines.Add("Sales: " + sales.ToString("c0"));
                    ReportResultForm.Lines.Add("Labor Cost: " + laborCost.ToString("c0"));
                    ReportResultForm.Lines.Add("Sales Per Labor Dollar: " + ppld.ToString("C"));

                    var f = new ReportResultForm();
                    f.ShowDialog();
                }
                */
                if (report == rbPayroll)
                {
                    ReportResultForm.Description = report.Text +
                        " for: " +
                        TransLister.MasterList.Min(x => x.Date).ToString("MM/yyyy") +
                        " - " +
                        Report.LatestFullMonth.ToString("MM/yyyy");

                    ReportResultForm.series = Report.LaborSeries();
                    int laborCost = Report.LaborCost();

                    ReportResultForm.Lines = new List<string>();
                    ReportResultForm.Lines.Add("Labor Cost: " + laborCost.ToString("c0"));

                    var f = new ReportResultForm();
                    f.ShowDialog();
                }
                if (report == rbFoodVsSales)
                {
                    ReportResultForm.Description = report.Text +
                        " for: " +
                        DailyTotalLister.MasterList.Min(x => x.Date).ToString("MM/yyyy") +
                        " - " +
                        Report.LatestFullMonth.ToString("MM/yyyy");

                    ReportResultForm.series = Report.AllSalesSeries();
                    ReportResultForm.series2 = Report.FoodSeries();

                    int sales = Report.Profit();
                    int food = Report.FoodCost();
                    int diff = sales + food;

                    ReportResultForm.Lines = new List<string>();
                    ReportResultForm.Lines.Add("Sales: " + sales.ToString("c0"));
                    ReportResultForm.Lines.Add("Food / Bev Supply Cost: " + food.ToString("c0"));
                    ReportResultForm.Lines.Add("Sales - Food / Bev Supply Cost: " + diff.ToString("c0"));

                    var f = new ReportResultForm();
                    f.ShowDialog();
                }
                if (report == rbRestVsCater)
                {
                    ReportResultForm.Description = report.Text +
                        " for: " +
                        DailyTotalLister.MasterList.Min(x => x.Date).ToString("MM/yyyy") +
                        " - " +
                        Report.LatestFullMonth.ToString("MM/yyyy");

                    ReportResultForm.series = Report.RestVsCaterSeries();

                    decimal rest = Report.Rest();
                    decimal cater = Report.Cater();
                    decimal percRest = rest / (rest + cater);
                    decimal percCater = cater / (rest + cater);

                    ReportResultForm.Lines = new List<string>();
                    ReportResultForm.Lines.Add("Restaurant Sales: " + rest.ToString("c0"));
                    ReportResultForm.Lines.Add("Catering Sales: " + cater.ToString("c0"));
                    ReportResultForm.Lines.Add("Percent Restaurant: " + String.Format("{0:P2}", percRest));
                    ReportResultForm.Lines.Add("Percent Catering: " + String.Format("{0:P2}", percCater));

                    var f = new ReportResultForm();
                    f.ShowDialog();
                }
                if(report == rbSales)
                {
                    ReportResultForm.Description = report.Text +
                        " for: " +
                        DailyTotalLister.MasterList.Min(x => x.Date).ToString("MM/yyyy") +
                        " - " +
                        Report.LatestFullMonth.ToString("MM/yyyy");

                    ReportResultForm.series = Report.AllSalesSeries();
                    ReportResultForm.series3 = Report.ShopSalesSeries();
                    ReportResultForm.series2 = Report.CaterSalesSeries();

                    int sales = Report.Profit();
                    int rest = Report.Rest();
                    int cater = Report.Cater();

                    ReportResultForm.Lines = new List<string>();
                    ReportResultForm.Lines.Add("All Sales: " + sales.ToString("c0"));
                    ReportResultForm.Lines.Add("Restaurant Sales: " + rest.ToString("c0"));
                    ReportResultForm.Lines.Add("Catering Sales: " + cater.ToString("c0"));


                    var f = new ReportResultForm();
                    f.ShowDialog();
                }
            }
        }

        private void ShowPNL(int months, string report)
        {

            ReportResultForm.Description = report +
                        " for: " +
                Report.LatestFullMonth.AddMonths(-months).ToString("MM/yyyy") + 
                " - " + 
                Report.LatestFullMonth.ToString("MM/yyyy");

            ReportResultForm.series = Report.ProfitSeries(months);

            int sales = Report.Profit(months);
            int loss = Report.Loss(months);
            int pnl = sales + loss;

            ReportResultForm.Lines = new List<string>();
            ReportResultForm.Lines.Add("Sales: " + sales.ToString("c0"));
            ReportResultForm.Lines.Add("Expenses: " + loss.ToString("c0"));
            ReportResultForm.Lines.Add("Profit: " + pnl.ToString("c0"));

            var f = new ReportResultForm();
            f.ShowDialog();
        }
        /*
        private void ShowPPLD(int months, string report)
        {
            ReportResultForm.Description = report +
                        " for: " +
                Report.LatestFullMonth.AddMonths(-months).ToString("MM/yyyy") +
                " - " +
                Report.LatestFullMonth.ToString("MM/yyyy");

            //ReportResultForm.series = Report.SpldSeries(months);

            decimal sales = Report.Profit(months);
            decimal laborCost = Report.LaborCost(months);
            decimal ppld = sales / - laborCost;

            ReportResultForm.Lines = new List<string>();
            ReportResultForm.Lines.Add("Sales: " + sales.ToString("c0"));
            ReportResultForm.Lines.Add("Labor Cost: " + laborCost.ToString("c0"));
            ReportResultForm.Lines.Add("Sales Per Labor Dollar: " + ppld.ToString("C"));

            var f = new ReportResultForm();
            f.ShowDialog();
        }
        */
        private void ShowPayroll(int months, string report)
        {
            ReportResultForm.Description = report +
                        " for: " +
                Report.LatestFullMonth.AddMonths(-months).ToString("MM/yyyy") +
                " - " +
                Report.LatestFullMonth.ToString("MM/yyyy");

            ReportResultForm.series = Report.LaborSeries(months);

            int laborCost = Report.LaborCost(months);

            ReportResultForm.Lines = new List<string>();
            ReportResultForm.Lines.Add("Labor Cost: " + laborCost.ToString("c0"));

            var f = new ReportResultForm();
            f.ShowDialog();
        }

        private void ShowFoodVsSales(int months, string report)
        {
            ReportResultForm.Description = report +
                        " for: " +
                Report.LatestFullMonth.AddMonths(-months).ToString("MM/yyyy") +
                " - " +
                Report.LatestFullMonth.ToString("MM/yyyy");

            ReportResultForm.series = Report.AllSalesSeries(months);
            ReportResultForm.series2 = Report.FoodSeries(months);

            int sales = Report.Profit(months);
            int food = Report.FoodCost(months);
            int diff = sales + food;

            ReportResultForm.Lines = new List<string>();
            ReportResultForm.Lines.Add("Sales: " + sales.ToString("c0"));
            ReportResultForm.Lines.Add("Food / Bev Supply Cost: " + food.ToString("c0"));
            ReportResultForm.Lines.Add("Sales - Food / Bev Supply Cost: " + diff.ToString("c0"));

            var f = new ReportResultForm();
            f.ShowDialog();
        }

        private void ShowRestVsCater(int months, string report)
        {
            ReportResultForm.Description = report +
                        " for: " +
                Report.LatestFullMonth.AddMonths(-months).ToString("MM/yyyy") +
                " - " +
                Report.LatestFullMonth.ToString("MM/yyyy");

            ReportResultForm.series = Report.RestVsCaterSeries(months);

            decimal rest = Report.Rest(months);
            decimal cater = Report.Cater(months);
            decimal percRest = rest / (rest + cater);
            decimal percCater = cater / (rest + cater);

            ReportResultForm.Lines = new List<string>();
            ReportResultForm.Lines.Add("Restaurant Sales: " + rest.ToString("c0"));
            ReportResultForm.Lines.Add("Catering Sales: " + cater.ToString("c0"));
            ReportResultForm.Lines.Add("Percent Restaurant: " + string.Format("{0:P2}", percRest));
            ReportResultForm.Lines.Add("Percent Catering: " + string.Format("{0:P2}", percCater));

            var f = new ReportResultForm();
            f.ShowDialog();
        }

        private void ShowSales(int months, string report)
        {

            ReportResultForm.Description = report +
                        " for: " +
                Report.LatestFullMonth.AddMonths(-months).ToString("MM/yyyy") +
                " - " +
                Report.LatestFullMonth.ToString("MM/yyyy");

            ReportResultForm.series = Report.AllSalesSeries(months);
            ReportResultForm.series3 = Report.ShopSalesSeries(months);
            ReportResultForm.series2 = Report.CaterSalesSeries(months);

            int sales = Report.Profit(months);
            int rest = Report.Rest(months);
            int cater = Report.Cater(months); 

            ReportResultForm.Lines = new List<string>();
            ReportResultForm.Lines.Add("All Sales: " + sales.ToString("c0"));
            ReportResultForm.Lines.Add("Restaurant Sales: " + rest.ToString("c0"));
            ReportResultForm.Lines.Add("Catering Sales: " + cater.ToString("c0"));

            var f = new ReportResultForm();
            f.ShowDialog();
        }

        private void ReportRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReturnWindow.Show();
        }
    }
}
