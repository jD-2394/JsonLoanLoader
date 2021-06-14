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
        private JsonLoader loader = new JsonLoader();
        private LoanProcessor processor = new LoanProcessor();
        private LoanDataPackage result;
        public MainForm()
        {
            InitializeComponent();
            loader = new JsonLoader();
            processor = new LoanProcessor();
            result = new LoanDataPackage();
            this.SelectSummary.DataSource = new List<string>()
            {
                "",
                "Loan Amount Summary",
                "Subject Appraised Amount Summary",
                "Interest Rate Summary"
            };
        }
        


        private void Clear_Form_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
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
            this.SaveSummary.Enabled = false;
            this.SaveState.Enabled = false;
            this.SaveAll.Enabled = false;
        }

        private void ImportJson_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ClearForm();
                var data = loader.ParseJsonFromFile(fileDialog.FileName);

                result = processor.GroupImportLoanData(data);
                if(result.loanStateData.Count > 0)
                {
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
                    var dataToIncludeInDropdown = result.loanStateData.Select(x => x.LoanState).ToList();
                    dataToIncludeInDropdown.Sort();
                    this.StateSelector.DataSource = dataToIncludeInDropdown;

                    this.StateSelector.Enabled = true;
                    this.SelectSummary.Enabled = true;
                    this.SaveSummary.Enabled = true;
                    this.SaveState.Enabled = true;
                    this.SaveAll.Enabled = true;
                }
                
            }
        }

        private void StateSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStateSummaryFromListener();
        }
        /*
         * Listener body used by both the Select State dropdowns and Select Summary report dropdowns 
         * since we want the fields in the form to update any time either values of the dropdowns are altered
         */
        public void SelectStateSummaryFromListener()
        {
            var State = this.StateSelector.Text;
            var SelectedSummary = this.SelectSummary.Text;
            if(State != null && SelectedSummary != null)
            {

                SummaryModel selectedSummary = new SummaryModel();
                if (SelectedSummary == "Loan Amount Summary")
                {
                    selectedSummary = this.result.loanStateData.Where(x => x.LoanState == State).Single().StateData.LoanAmountSummary;
                }
                if (SelectedSummary == "Subject Appraised Amount Summary")
                {
                    selectedSummary = this.result.loanStateData.Where(x => x.LoanState == State).Single().StateData.SubjectAppraisedAmountSummary;
                }
                if (SelectedSummary == "Interest Rate Summary")
                {
                    selectedSummary = this.result.loanStateData.Where(x => x.LoanState == State).Single().StateData.InterestRateSummary;
                }
                if (selectedSummary != null)
                {
                    this.StateSum.Text = selectedSummary.Sum;
                    this.StateAverage.Text = selectedSummary.Average;
                    this.StateMedian.Text = selectedSummary.Median;
                    this.StateMinimum.Text = selectedSummary.Minimum;
                    this.StateMaximum.Text = selectedSummary.Maximum;
                }
            }
        }
        private void SelectSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStateSummaryFromListener();
        }
        // Saves the summary file with the option of a save file dialog to choose save location
        private void SaveSummaryAs_Click(object sender, EventArgs e)
        {
            if(result != null)
            {
                loader.ParseJsonToFile(result,true);
            }
        }
        // saves the state summary file with the option to choose save path
        private void SaveStateAs_Click(object sender, EventArgs e)
        {
            if (result != null)
            {
                loader.ParseJsonToFile(result,false);
            }
        }
        // this will save both files, no dialog, will be stored in the Results folder
        private void SaveFiles(object sender, EventArgs e)
        {
            loader.ParseJsonToFileSaveAll(result);
        }
    }
}
