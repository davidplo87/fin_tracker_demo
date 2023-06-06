using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _411_Demo_2
{
    public partial class BreakoutForm : Form
    {
        public decimal BreakOut1 { get; set; }
        public decimal BreakOut2 { get; set; }
        public decimal BreakOut3 { get; set; }
        public decimal BreakOut4 { get; set; }
        public string strBreakOut1 { get; set; }
        public string strBreakOut2 { get; set; }
        public string strBreakOut3 { get; set; }
        public string strBreakOut4 { get; set; }
        public static Transaction trans { get; set; }
        
        public BreakoutForm()
        {
            InitializeComponent();

            label2.Text = "Date: " + trans.Date.ToShortDateString();
            label3.Text = "Description: " + trans.Description;
            label4.Text = "Amount: " + trans.Amount.ToString("C2");
            label5.Text = null;

            BreakOut1 = .52m;
            BreakOut2 = .01m;
            BreakOut3 = .08m;
            BreakOut4 = .39m;

            strBreakOut1 = "Food / Bev Supply";
            strBreakOut2 = "Other Business Expense";
            strBreakOut3 = "Utility / Rent";
            strBreakOut4 = "Personal Expense";

            label10.Text = strBreakOut1;
            label11.Text = strBreakOut2;
            label12.Text = strBreakOut3;
            label13.Text = strBreakOut4;

            numericUpDown1.Value = BreakOut1 * 100;
            numericUpDown2.Value = BreakOut2 * 100;
            numericUpDown3.Value = BreakOut3 * 100;
            numericUpDown4.Value = BreakOut4 * 100;

            label14.Text = String.Format("{0:P2}", (BreakOut1 + BreakOut2 + BreakOut3 + BreakOut4));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            BreakOut1 = numericUpDown1.Value / 100;
            label14.Text = String.Format("{0:P2}", (BreakOut1 + BreakOut2 + BreakOut3 + BreakOut4));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            BreakOut2 = numericUpDown2.Value / 100;
            label14.Text = String.Format("{0:P2}", (BreakOut1 + BreakOut2 + BreakOut3 + BreakOut4));
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            BreakOut3 = numericUpDown3.Value / 100;
            label14.Text = String.Format("{0:P2}", (BreakOut1 + BreakOut2 + BreakOut3 + BreakOut4));
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            BreakOut4 = numericUpDown4.Value / 100;
            label14.Text = String.Format("{0:P2}", (BreakOut1 + BreakOut2 + BreakOut3 + BreakOut4));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(BreakOut1 + BreakOut2 + BreakOut3 + BreakOut4 == 1)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                label5.Text = "Percentages Must Add Up To %100";
            }
        }
    }
}
