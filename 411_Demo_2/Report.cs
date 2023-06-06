using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace _411_Demo_2
{
    public static class Report
    {
        public static DateTime LatestFullMonth { get; set; }

        public static void SetLatestFullMonth()
        {
            if (DailyTotalLister.LatestFullMonth() >= TransLister.LatestFullMonth())
            {
                LatestFullMonth = TransLister.LatestFullMonth();
            }
            else
            {
                LatestFullMonth = DailyTotalLister.LatestFullMonth();
            }
        }

        public static int Profit(int monthsPrior)
        {
            return  Convert.ToInt32(DailyTotalLister.MasterList.Where(x =>
                x.Date > LatestFullMonth.AddMonths(-monthsPrior) &&
                x.Date <= LatestFullMonth
                ).Sum(x => x.Cater + x.Shop));
        }

        public static int Profit()
        {
            return Convert.ToInt32(DailyTotalLister.MasterList.Where(x => x.Date <= LatestFullMonth).Sum(x => x.Cater + x.Shop));
        }

        public static int Loss(int monthsPrior)
        {

            return Convert.ToInt32(TransLister.MasterList.Where(x =>
                x.Date > LatestFullMonth.AddMonths(-monthsPrior) &&
                x.Date <= LatestFullMonth && (
                    x.Category == "Food / Bev Supply" ||
                    x.Category == "Other Business Expense" ||
                    x.Category == "Utility / Rent" ||
                    x.Category == "Payroll")).Sum(x => x.Amount));
        }

        public static int Loss()
        {

            return Convert.ToInt32(TransLister.MasterList.Where(x =>
                x.Date <= LatestFullMonth && (
                x.Category == "Food / Bev Supply" ||
                x.Category == "Other Business Expense" ||
                x.Category == "Utility / Rent" ||
                x.Category == "Payroll")).Sum(x => x.Amount));
        }

        public static int LaborCost(int monthsPrior)
        {
            return Convert.ToInt32(TransLister.MasterList.Where(x => 
                x.Date > LatestFullMonth.AddMonths(-monthsPrior) &&
                x.Date <= LatestFullMonth && 
                x.Category == "Payroll").Sum(x => x.Amount));
        }

        public static int LaborCost()
        {
            return Convert.ToInt32(TransLister.MasterList.Where(x =>
                x.Date <= LatestFullMonth &&
                x.Category == "Payroll").Sum(x => x.Amount));
        }

        public static int FoodCost(int monthsPrior)
        {
            return Convert.ToInt32(TransLister.MasterList.Where(x =>
                x.Date > LatestFullMonth.AddMonths(-monthsPrior) &&
                x.Date <= LatestFullMonth &&
                x.Category == "Food / Bev Supply").Sum(x => x.Amount));
        }

        public static int FoodCost()
        {
            return Convert.ToInt32(TransLister.MasterList.Where(x =>
                x.Date <= LatestFullMonth &&
                x.Category == "Food / Bev Supply").Sum(x => x.Amount));
        }

        public static int Rest(int monthsPrior)
        {
            return Convert.ToInt32(DailyTotalLister.MasterList.Where(x =>
                x.Date > LatestFullMonth.AddMonths(-monthsPrior) &&
                x.Date <= LatestFullMonth).Sum(x => x.Shop));
        }

        public static int Rest()
        {
            return Convert.ToInt32(DailyTotalLister.MasterList.Where(x => x.Date <= LatestFullMonth).Sum(x => x.Shop));
        }

        public static int Cater(int monthsPrior)
        {
            return Convert.ToInt32(DailyTotalLister.MasterList.Where(x =>
                x.Date > LatestFullMonth.AddMonths(-monthsPrior) &&
                x.Date <= LatestFullMonth).Sum(x => x.Cater));
        }
        public static int Cater()
        {
            return Convert.ToInt32(DailyTotalLister.MasterList.Where(x => x.Date <= LatestFullMonth).Sum(x => x.Cater));
        }

        public static Series ProfitSeries(int monthsPrior)
        {
            var series = new Series
            {
                Name = "Profit",
                Color = Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                BorderWidth = 3,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = monthsPrior - 1; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    TransLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year && (
                        x.Category == "Food / Bev Supply" ||
                        x.Category == "Payroll" ||
                        x.Category == "Utility / Rent" ||
                        x.Category == "Other Business Expense")).Sum(x => x.Amount) + DailyTotalLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year).Sum(x => x.Shop + x.Cater)
                    );
            }
            return series;
        }

        public static Series ProfitSeries()
        {
            DateTime begin = TransLister.MasterList.Min(x => x.Date);

            var series = new Series
            {
                Name = "Profit",
                Color = Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                BorderWidth = 3,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = ((LatestFullMonth.Year - begin.Year) * 12) + LatestFullMonth.Month - begin.Month; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    TransLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year && (
                        x.Category == "Food / Bev Supply" ||
                        x.Category == "Payroll" ||
                        x.Category == "Utility / Rent" ||
                        x.Category == "Other Business Expense")).Sum(x => x.Amount) + DailyTotalLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year).Sum(x => x.Shop + x.Cater)
                    );
            }
            return series;
        }

        public static Series FoodSeries(int monthsPrior)
        {
            var series = new Series
            {
                Name = "Food / Bev Supply Costs",
                Color = Color.Red,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                BorderWidth = 3,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = monthsPrior - 1; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    - TransLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year && (
                        x.Category == "Food / Bev Supply")).Sum(x => x.Amount)
                    );
            }
            return series;
        }

        public static Series FoodSeries()
        {
            DateTime begin = TransLister.MasterList.Min(x => x.Date);

            var series = new Series
            {
                Name = "Food / Bev Supply Costs",
                Color = Color.Red,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                BorderWidth = 3,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = ((LatestFullMonth.Year - begin.Year) * 12) + LatestFullMonth.Month - begin.Month; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    - TransLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year && (
                        x.Category == "Food / Bev Supply")).Sum(x => x.Amount)
                    );
            }
            return series;
        }
        /*
        public static Series SpldSeries(int monthsPrior)
        {
            var series = new Series
            {
                Name = "Sales per Labor Dollar",
                Color = Color.Purple,
                BorderWidth = 3,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = monthsPrior - 1; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    DailyTotalLister.MasterList.Where(x =>
                    x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                    x.Date.Year == LatestFullMonth.AddMonths(-i).Year).Sum(x => x.Shop + x.Cater) / -
                    TransLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year <= LatestFullMonth.AddMonths(-i).Year && (
                        x.Category == "Payroll")).Sum(x => x.Amount)
                    );
            }
            return series;
        }
        
        public static Series SpldSeries()
        {
            DateTime begin = TransLister.MasterList.Min(x => x.Date);

            var series = new Series
            {
                Name = "Sales per Labor Dollar",
                Color = Color.Purple,
                BorderWidth = 3,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = ((LatestFullMonth.Year - begin.Year) * 12) + LatestFullMonth.Month - begin.Month - 1; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    DailyTotalLister.MasterList.Where(x =>
                    x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                    x.Date.Year == LatestFullMonth.AddMonths(-i).Year).Sum(x => x.Shop + x.Cater) / -
                    TransLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year && (
                        x.Category == "Payroll")).Sum(x => x.Amount)
                    );
            }
            return series;
        }
        */
        public static Series LaborSeries(int monthsPrior)
        {
            var series = new Series
            {
                Name = "Labor Expenses",
                Color = Color.Red,
                BorderWidth = 3,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = monthsPrior - 1; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    - TransLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year && (
                        x.Category == "Payroll")).Sum(x => x.Amount)
                    );
            }
            return series;
        }

        public static Series LaborSeries()
        {
            DateTime begin = TransLister.MasterList.Min(x => x.Date);

            var series = new Series
            {
                Name = "Labor Expenses",
                Color = Color.Red,
                BorderWidth = 3,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = ((LatestFullMonth.Year - begin.Year) * 12) + LatestFullMonth.Month - begin.Month - 1; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    - TransLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year && (
                        x.Category == "Payroll")).Sum(x => x.Amount)
                    );
            }
            return series;
        }

        public static Series RestVsCaterSeries(int monthsPrior)
        {
            var series = new Series
            {
                Name = "restvscater",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Pie,
            };

            series.Points.AddXY("Restaurant", DailyTotalLister.MasterList.Where(x =>
                    x.Date > LatestFullMonth.AddMonths(-monthsPrior) &&
                    x.Date < LatestFullMonth).Sum(x => x.Shop));

            series.Points.AddXY("Restaurant", DailyTotalLister.MasterList.Where(x =>
                    x.Date > LatestFullMonth.AddMonths(-monthsPrior) &&
                    x.Date < LatestFullMonth).Sum(x => x.Cater));

            return series;
        }

        public static Series RestVsCaterSeries()
        {
            DateTime begin = TransLister.MasterList.Min(x => x.Date);

            var series = new Series
            {
                Name = "restvscater",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Pie,
            };

            series.Points.AddXY("Restaurant", DailyTotalLister.MasterList.Sum(x => x.Shop));

            series.Points.AddXY("Catering", DailyTotalLister.MasterList.Sum(x => x.Cater));

            return series;
        }

        public static Series AllSalesSeries(int monthsPrior)
        {
            var series = new Series
            {
                Name = "All Sales",
                Color = Color.Green,
                BorderWidth = 3,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
                
            };

            for (int i = monthsPrior - 1; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    DailyTotalLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year).Sum(x => x.Shop + x.Cater)
                    );
            }
            return series;
        }

        public static Series AllSalesSeries()
        {
            DateTime begin = TransLister.MasterList.Min(x => x.Date);

            var series = new Series
            {
                Name = "All Sales",
                Color = Color.Green,
                BorderWidth = 3,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = ((LatestFullMonth.Year - begin.Year) * 12) + LatestFullMonth.Month - begin.Month; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    DailyTotalLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year).Sum(x => x.Shop + x.Cater)
                    );
            }
            return series;
        }

        public static Series CaterSalesSeries(int monthsPrior)
        {
            var series = new Series
            {
                Name = "Catering Sales",
                Color = Color.Purple,
                BorderWidth = 3,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,

            };

            for (int i = monthsPrior - 1; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    DailyTotalLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year).Sum(x => x.Cater)
                    );
            }
            return series;
        }

        public static Series CaterSalesSeries()
        {
            DateTime begin = TransLister.MasterList.Min(x => x.Date);

            var series = new Series
            {
                Name = "Catering Sales",
                Color = Color.Purple,
                BorderWidth = 3,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = ((LatestFullMonth.Year - begin.Year) * 12) + LatestFullMonth.Month - begin.Month; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    DailyTotalLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year).Sum(x => x.Cater)
                    );
            }
            return series;
        }

        public static Series ShopSalesSeries(int monthsPrior)
        {
            var series = new Series
            {
                Name = "Restaurant Sales",
                Color = Color.Orange,
                BorderWidth = 3,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = monthsPrior - 1; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    DailyTotalLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year).Sum(x => x.Shop)
                    );
            }
            return series;
        }

        public static Series ShopSalesSeries()
        {
            DateTime begin = TransLister.MasterList.Min(x => x.Date);

            var series = new Series
            {
                Name = "Restaurant Sales",
                Color = Color.Orange,
                BorderWidth = 3,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
            };

            for (int i = ((LatestFullMonth.Year - begin.Year) * 12) + LatestFullMonth.Month - begin.Month; i >= 0; i--)
            {
                series.Points.AddXY(LatestFullMonth.AddMonths(-i).ToString("MMM yy"),
                    DailyTotalLister.MasterList.Where(x =>
                        x.Date.Month == LatestFullMonth.AddMonths(-i).Month &&
                        x.Date.Year == LatestFullMonth.AddMonths(-i).Year).Sum(x => x.Shop)
                    );
            }
            return series;
        }
    }
}
