using SilverWorkJsonLoader.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverWorkJsonLoader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            loader = new JsonLoader();
            processor = new LoanProcessor();
        }
        private JsonLoader loader = new JsonLoader();
        private LoanProcessor processor = new LoanProcessor();
        private LoanDataPackage result = new LoanDataPackage();


        private void button2_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private void clearForm()
        {
            this.Sum.Text = "";
            this.Average.Text = "";
            this.Median.Text = "";
            this.Minimum.Text = "";
            this.Maximum.Text = "";

            this.IRS_Sum.Text = "";
            this.IRS_Average.Text = "";
            this.IRS_Median.Text = "";
            this.IRS_Minimum.Text = "";
            this.IRS_Maximum.Text = "";

            this.LAS_Sum.Text = "";
            this.LAS_Average.Text = "";
            this.LAS_Median.Text = "";
            this.LAS_Minimum.Text = "";
            this.LAS_Maximum.Text = "";

            this.StateSum.Text = "";
            this.StateAverage.Text = "";
            this.StateMedian.Text = "";
            this.StateMinimum.Text = "";
            this.StateMaximum.Text = "";

            this.StateSelector.DataSource = null;
            this.StateSelector.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                clearForm();
                var data = loader.ParseJsonInFile(fileDialog.FileName);
                var result = processor.GroupImportLoanData(data);
                this.Sum.Text = result.summaryResults.SubjectAppraisedAmountSummary.Sum.ToString();
                this.Average.Text = result.summaryResults.SubjectAppraisedAmountSummary.Average.ToString();
                this.Median.Text = result.summaryResults.SubjectAppraisedAmountSummary.Median.ToString();
                this.Minimum.Text = result.summaryResults.SubjectAppraisedAmountSummary.Minimum.ToString();
                this.Maximum.Text = result.summaryResults.SubjectAppraisedAmountSummary.Maximum.ToString();

                this.IRS_Sum.Text = result.summaryResults.InterestRateSummary.Sum.ToString();
                this.IRS_Average.Text = result.summaryResults.InterestRateSummary.Average.ToString();
                this.IRS_Median.Text = result.summaryResults.InterestRateSummary.Median.ToString();
                this.IRS_Minimum.Text = result.summaryResults.InterestRateSummary.Minimum.ToString();
                this.IRS_Maximum.Text = result.summaryResults.InterestRateSummary.Maximum.ToString();

                this.LAS_Sum.Text = result.summaryResults.LoanAmountSummary.Sum.ToString();
                this.LAS_Average.Text = result.summaryResults.LoanAmountSummary.Average.ToString();
                this.LAS_Median.Text = result.summaryResults.LoanAmountSummary.Median.ToString();
                this.LAS_Minimum.Text = result.summaryResults.LoanAmountSummary.Minimum.ToString();
                this.LAS_Maximum.Text = result.summaryResults.LoanAmountSummary.Maximum.ToString();

                this.StateSelector.DataSource = result.loanStateData.Select(x => x.LoanState).ToList();
                this.StateSelector.Enabled = true;
            }
        }

        private void StateSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = this.StateSelector.Text;
        }
    }
}
