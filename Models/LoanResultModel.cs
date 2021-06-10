using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverWorkJsonLoader.Models
{
    public class LoanResultModel
    {
        public SummaryModel LoanAmountSummary { get; set; }
        public SummaryModel SubjectAppraisedAmountSummary { get; set; }
        public SummaryModel InterestRateSummary { get; set; }
    }
}
