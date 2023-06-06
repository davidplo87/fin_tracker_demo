using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _411_Demo_2
{
    public partial class ReportResultForm : Form
    {
        public static Series series { set; get; }
        public static Series series2 { set; get; }
        public static Series series3 { set; get; }
        public static string Description { get; set; }
        public static List<string> Lines { get; set; }
        public ReportResultForm()
        {
            InitializeComponent();

            chrtResult.Series.Clear();
            chrtResult.Titles.Clear();

            chrtResult.Series.Add(series);
            chrtResult.Series[0].IsVisibleInLegend = true;
            if (series2 != null)
            {
                chrtResult.Series.Add(series2);
            }
            if (series3 != null)
            {
                chrtResult.Series.Add(series3);
            }

            foreach(Series s in chrtResult.Series)
            {
                s.IsVisibleInLegend = true;
            }

            chrtResult.Titles.Add(Description);
            chrtResult.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular);
            chrtResult.ChartAreas[0].AxisY.LabelStyle.Format = "c0";
            chrtResult.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep30;

            if(series.Points.Count < 24)
            {
                chrtResult.ChartAreas[0].AxisX.Interval = 1;
            }
            else
            {
                chrtResult.ChartAreas[0].AxisX.Interval = 3;
            }
            
            chrtResult.Invalidate();

            series = null;
            series2 = null;
            series3 = null;

            foreach (string line in Lines)
            {
                lbSummary.Items.Add(line);
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
