using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _411_Demo_2
{
    public partial class TransactionsForm : Form
    {
        //For determining whether the dgv is bound to list or not
        //mostly for cell changed listener. listener can't added to a non-existent cell.

        //Acts as a temporary display list
        //Upon import, or category change mod acts as buffer, and then changes are written to master
        private List<Transaction> _displayList;
        public HomeForm ReturnWindow { get; set; }
        public TransactionsForm()
        {
            InitializeComponent();
            ResetFilter();
            ResetSort();
            BindDisplayList();
            SetDaysSinceLabel();
        }

        //Add only new transactions from import to MasterList, write new MasterList, and bind
        private void btnImport_Click(object sender, EventArgs e)
        {
            /*
            string importFileName;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "csv files (*.csv) | *.csv";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                importFileName = ofd.FileName;
            }
            else
            {
                importFileName = "";
            }

            if (importFileName != "")
            {
                try
                {
                    List<Transaction> importList;
                    using (var reader = new StreamReader(importFileName))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        csv.Context.RegisterClassMap<TransLister.ReadImportMap>();
                        importList = csv.GetRecords<Transaction>().ToList();
                    }

                    //List contains only new transactions that don't already exist in Mastrer
                    //May still contain dup CC
                    importList = TransLister.RemoveDuplicates(importList, TransLister.MasterList);
                    importList = TransLister.RemoveDuplicatesCC(importList, TransLister.MasterList);

                    int numImported = 0;

                    foreach (var transaction in importList)
                    {
                        if (TransLister.IsCreditCardTransaction(transaction))
                        {
                            BreakoutForm.trans = transaction;
                            BreakoutForm f = new BreakoutForm();
                            if (f.ShowDialog() == DialogResult.OK)
                            {
                                TransLister.MasterList.Add(new Transaction
                                {
                                    Date = transaction.Date,
                                    Description = transaction.Description + "(Break Out - " + f.strBreakOut1 + ")",
                                    Amount = Math.Round(transaction.Amount * f.BreakOut1, 2),
                                    Category = f.strBreakOut1,
                                    IsBrokenOut = true,
                                });
                                TransLister.MasterList.Add(new Transaction
                                {
                                    Date = transaction.Date,
                                    Description = transaction.Description + "(Break Out - " + f.strBreakOut2 + ")",
                                    Amount = Math.Round(transaction.Amount * f.BreakOut2, 2),
                                    Category = f.strBreakOut2,
                                    IsBrokenOut = true
                                });
                                TransLister.MasterList.Add(new Transaction
                                {
                                    Date = transaction.Date,
                                    Description = transaction.Description + "(Break Out - " + f.strBreakOut3 + ")",
                                    Amount = Math.Round(transaction.Amount * f.BreakOut3, 2),
                                    Category = f.strBreakOut3,
                                    IsBrokenOut = true
                                });
                                TransLister.MasterList.Add(new Transaction
                                {
                                    Date = transaction.Date,
                                    Description = transaction.Description + "(Break Out - " + f.strBreakOut4 + ")",
                                    Amount = Math.Round(transaction.Amount * f.BreakOut4, 2),
                                    Category = f.strBreakOut4,
                                    IsBrokenOut = true
                                });
                            }
                        }
                        else
                        {
                            TransLister.AutoSetCategory(transaction);
                            TransLister.MasterList.Add(transaction);
                        }
                        numImported++;
                    }

                    TransLister.WriteMasterFile();
                    ResetFilter();
                    ResetSort();
                    SetDaysSinceLabel();
                    BindDisplayList();
                    MessageBox.Show("New Transactions Imported: " + numImported);
                }
                catch
                {
                    MessageBox.Show("Invalid File, Cannot Import");
                    ResetFilter();
                    ResetSort();
                    BindDisplayList();
                }
            }
            */
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            //apply the filter here.
           
            var checkedRadio = gbCat.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            _displayList = TransLister.FilterBy(
                TransLister.MasterList, 
                checkedRadio.Text, 
                cbOnlyChecks.Checked, 
                dtpStart.Value, 
                dtpEnd.Value, 
                nudMin.Value, 
                nudMax.Value, 
                txtbSearch.Text);
            
            ResetSort();
            BindDisplayList();

            if(_displayList.Count == 0)
            {
                txtbSearch.Focus();
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            ResetFilter();
            ResetSort();
            BindDisplayList();
        }

        //If e column header is clicked, sort DisplayList by e and bind it
        private void dgvTransactions_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTransactions.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.None)
            {
                _displayList = TransLister.SortBy(_displayList, e.ColumnIndex, false);
                BindDisplayList();
                ClearAllGlyphs();
                dgvTransactions.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            }
            else if (dgvTransactions.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
            {
                _displayList = TransLister.SortBy(_displayList, e.ColumnIndex, true);
                BindDisplayList();
                ClearAllGlyphs();
                dgvTransactions.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            }
            else if (dgvTransactions.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                _displayList = TransLister.SortBy(_displayList, e.ColumnIndex, false);
                BindDisplayList();
                ClearAllGlyphs();
                dgvTransactions.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            }
        }

        private void ClearAllGlyphs()
        {
            foreach (DataGridViewColumn column in dgvTransactions.Columns)
            {
                column.HeaderCell.SortGlyphDirection = SortOrder.None;
            }
        }

        //Set controls with min and max values based off master
        //Set Mod to master, and display
        private void ResetFilter()
        {
            rbAll.Checked = true;

            var oldestTrans = TransLister.MasterList.Min(x => x.Date);
            var latestTrans = TransLister.MasterList.Max(x => x.Date);

            dtpStart.MinDate = oldestTrans;
            dtpStart.MaxDate = latestTrans;
            dtpStart.Value = oldestTrans;

            dtpEnd.MinDate = oldestTrans;
            dtpEnd.MaxDate = latestTrans;
            dtpEnd.Value = latestTrans;

            decimal maxAmt = TransLister.MasterList.Max(x => x.Amount);
            decimal minAmt = TransLister.MasterList.Min(x => x.Amount);

            nudMin.Minimum = minAmt;
            nudMin.Maximum = maxAmt;
            nudMin.Value = minAmt;

            nudMax.Minimum = minAmt;
            nudMax.Maximum = maxAmt;
            nudMax.Value = maxAmt;

            cbOnlyChecks.Checked = false;

            txtbSearch.Text = "";

            _displayList = TransLister.FilterBy(
                TransLister.MasterList,
                rbAll.Text,
                cbOnlyChecks.Checked,
                dtpStart.Value,
                dtpEnd.Value,
                nudMin.Value,
                nudMax.Value,
                txtbSearch.Text);
        }

        private void ResetSort()
        {
            _displayList = TransLister.SortBy(_displayList, 0, false);
        }

        private void nudMin_ValueChanged(object sender, EventArgs e)
        {
            if (nudMin.Value > nudMax.Value)
            {
                nudMin.Value = nudMax.Value;
            }
        }

        private void nudMax_ValueChanged(object sender, EventArgs e)
        {
            if (nudMax.Value < nudMin.Value)
            {
                nudMax.Value = nudMin.Value;
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.MinDate = dtpStart.Value;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            dtpStart.MaxDate = dtpEnd.Value;
        }

        private void SetDaysSinceLabel()
        {
            if (TransLister.MasterList.Count == 0)
            {
                lblDaysSinceVal.Text = "No Transactions";
            }
            else
            {
                int numDays = TransLister.DaysSinceLast();
                lblDaysSinceVal.Text = numDays.ToString();

                if (numDays > 30)
                {
                    lblDaysSinceVal.Text = numDays + " (Consider Importing Bank Activity)";
                    lblDaysSinceVal.ForeColor = Color.Red;
                    lblDaysSince.ForeColor = Color.Red;
                }
                else
                {
                    lblDaysSinceVal.Text = numDays.ToString();
                    lblDaysSinceVal.ForeColor = Color.Black;
                    lblDaysSince.ForeColor = Color.Black;
                }
            }    
        }

        private void BindDisplayList()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _displayList;
            dgvTransactions.DataSource = bs;
            dgvTransactions.Columns["IsBrokenOut"].Visible = false;
        }

        private void dgvTransactions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Transaction ma in TransLister.MasterList)
            {
                _displayList[e.RowIndex].Category = dgvTransactions[4, e.RowIndex].Value.ToString();

                //replace the matching transactions category in master
                if (_displayList[e.RowIndex].Date == ma.Date &&
                    _displayList[e.RowIndex].Description == ma.Description &&
                    _displayList[e.RowIndex].CheckNum == ma.CheckNum &&
                    _displayList[e.RowIndex].Amount == ma.Amount)
                {
                    ma.Category = _displayList[e.RowIndex].Category;
                }
            }
        }

        private void TransactionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TransLister.WriteMasterFile();
            Report.SetLatestFullMonth();
        }

        private void TransactionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReturnWindow.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if(e.Value.ToString() == "0")
                {
                    e.Value = null;
                }
            }
            if (e.ColumnIndex == 3)
            {
                var dgv = sender as DataGridView;
                var cell = dgv[e.ColumnIndex, e.RowIndex];
                var val = (decimal)e.Value;

                if (val < 0) 
                {
                    cell.Style.ForeColor = Color.Red;
                }
            }
        }

        private void linkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}