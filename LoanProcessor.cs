using SilverWorkJsonLoader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverWorkJsonLoader
{
    public class LoanProcessor
    {
/*
 * This is where the data parsed from the JSON processer used to generate the summary data
 * for all loans as well as compile the loan data for each state, and its appropriate summary
 */
        public LoanDataPackage GroupImportLoanData(List<LoanDataModel> data)
        {
            // we need to generate the overall summary across all loans on file
            var summaryLoanData = GenerateLoanReportSummary(data);
            // we need to group the data for the state loans first to be able to get the summary for each state
            var stateLoanData = GroupLoanDataByState(data);
            foreach(var stateLoan in stateLoanData)
            {
                stateLoan.StateData = GenerateLoanReportSummary(stateLoan.StateLoanData);
            }
            return new LoanDataPackage()
            {
                summaryResults = summaryLoanData,
                loanStateData = stateLoanData
            };
        }
        // groups the loan data by state
        public List<LoanByState> GroupLoanDataByState(List<LoanDataModel> data)
        {
            var compiledStateLoans = new List<LoanByState>();
            foreach(var loan in data)
            {
                // check if the state already exists in the collection
                var LoanStateIsInCollection = compiledStateLoans.Any(x => x.LoanState == loan.SubjectState);
                if (LoanStateIsInCollection)
                {
                    // if the state already exist, add to the existing state in the collection
                    var StateLoanEntryIndex = compiledStateLoans.FindIndex(x => x.LoanState == loan.SubjectState);
                    compiledStateLoans[StateLoanEntryIndex].StateLoanData.Add(loan);
                }
                else
                {
                    // if the state doesn't already exist, add a new entry to the collection with the state and data for that state
                    compiledStateLoans.Add(new LoanByState()
                    {
                       LoanState = loan.SubjectState,
                       StateLoanData = new List<LoanDataModel>() { loan}
                    });
                }
            }
            return compiledStateLoans;

        }
        // takes the loan data and generates the Sum,Average,Median,Maximum,Minimum for each summary and stores in the Loan Result model, used by the overall summary and by each state
        public LoanResultModel GenerateLoanReportSummary(List<LoanDataModel> data)
        {
            // used MathNet to provide the statistics for all the values except the Sum as this avoids the possible inefficiencies of implementing a custom algorithm where one isn't necessary.
            var LoanAmountSummary = new SummaryModel()
            {
                Sum = Math.Round(Convert.ToDecimal(data.Select(x => x.LoanAmount).ToList().Sum()),2).ToString("0.00"),
                Average = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Mean(data.Select(x => x.LoanAmount).ToList())),2).ToString("0.##"),
                Median = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Median(data.Select(x => x.LoanAmount).ToList())),2).ToString("0.00"),
                Maximum = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Maximum(data.Select(x => x.LoanAmount).ToList())),2).ToString("0.00"),
                Minimum = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Minimum(data.Select(x => x.LoanAmount).ToList())),2).ToString("0.00")
            };
            var SubjectAppraisedAmountSummary = new SummaryModel()
            {
                Sum = Math.Round(Convert.ToDecimal(data.Select(x => x.SubjectAppraisedAmount).ToList().Sum()), 2).ToString("0.00"),
                Average = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Mean(data.Select(x => x.SubjectAppraisedAmount).ToList())),2).ToString("0.00"),
                Median = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Median(data.Select(x => x.SubjectAppraisedAmount).ToList())),2).ToString("0.00"),
                Maximum = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Maximum(data.Select(x => x.SubjectAppraisedAmount).ToList())),2).ToString("0.00"),
                Minimum = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Minimum(data.Select(x => x.SubjectAppraisedAmount).ToList())),2).ToString("0.00")
            };
            var InterestRateSummary = new SummaryModel()
            {
                Sum = Math.Round(Convert.ToDecimal(data.Select(x => x.SubjectAppraisedAmount).ToList().Sum()), 2).ToString("0.00"),
                Average = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Mean(data.Select(x => x.InterestRate).ToList())),2).ToString("0.00"),
                Median = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Median(data.Select(x => x.InterestRate).ToList())),2).ToString("0.00"),
                Maximum = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Maximum(data.Select(x => x.InterestRate).ToList())),2).ToString("0.00"),
                Minimum = Math.Round(Convert.ToDecimal(MathNet.Numerics.Statistics.Statistics.Minimum(data.Select(x => x.InterestRate).ToList())),2).ToString("0.00")
            };

            return new LoanResultModel()
            {LoanAmountSummary = LoanAmountSummary,
            SubjectAppraisedAmountSummary = SubjectAppraisedAmountSummary,
            InterestRateSummary = InterestRateSummary};
        }
    }
}
