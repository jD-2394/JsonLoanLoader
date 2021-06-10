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
        public LoanDataPackage GroupImportLoanData(List<LoanDataModel> data)
        {
            var summaryLoanData = GenerateLoanReportSummary(data);
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

        public List<LoanByState> GroupLoanDataByState(List<LoanDataModel> data)
        {
            var compiledStateLoans = new List<LoanByState>();
            foreach(var loan in data)
            {
                var LoanStateIsInCollection = compiledStateLoans.Any(x => x.LoanState == loan.SubjectState);
                if (LoanStateIsInCollection)
                {
                    var StateLoanEntryIndex = compiledStateLoans.FindIndex(x => x.LoanState == loan.SubjectState);
                    compiledStateLoans[StateLoanEntryIndex].StateLoanData.Add(loan);
                }
                else
                {
                    compiledStateLoans.Add(new LoanByState()
                    {
                       LoanState = loan.SubjectState,
                       StateLoanData = new List<LoanDataModel>() { loan}
                    });
                }
            }
            return compiledStateLoans;

        }
        public LoanResultModel GenerateLoanReportSummary(List<LoanDataModel> data)
        {

            var LoanAmountSummary = new SummaryModel()
            {
                Sum = data.Select(x => x.LoanAmount).ToList().Sum(),
                Average = data.Select(x => x.LoanAmount).ToList().Average(),
                Median = UtilityClass.GetMedian(data.Select(x => x.LoanAmount).ToList()),
                Maximum = data.Select(x => x.LoanAmount).ToList().Max(),
                Minimum = data.Select(x => x.LoanAmount).ToList().Min()
            };
            var SubjectAppraisedAmountSummary = new SummaryModel()
            {
                Sum = data.Select(x => x.SubjectAppraisedAmount).ToList().Sum(),
                Average = data.Select(x => x.SubjectAppraisedAmount).ToList().Average(),
                Median = UtilityClass.GetMedian(data.Select(x => x.SubjectAppraisedAmount).ToList()),
                Maximum = data.Select(x => x.SubjectAppraisedAmount).ToList().Max(),
                Minimum = data.Select(x => x.SubjectAppraisedAmount).ToList().Min()
            };
            var InterestRateSummary = new SummaryModel()
            {
                Sum = data.Select(x => x.InterestRate).ToList().Sum(),
                Average = data.Select(x => x.InterestRate).ToList().Average(),
                Median = UtilityClass.GetMedian(data.Select(x => x.InterestRate).ToList()),
                Maximum = data.Select(x => x.InterestRate).ToList().Max(),
                Minimum = data.Select(x => x.InterestRate).ToList().Min()
            };

            return new LoanResultModel()
            {LoanAmountSummary = LoanAmountSummary,
            SubjectAppraisedAmountSummary = SubjectAppraisedAmountSummary,
            InterestRateSummary = InterestRateSummary};
        }
    }
}
