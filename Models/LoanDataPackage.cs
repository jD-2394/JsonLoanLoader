using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverWorkJsonLoader.Models
{
    public class LoanDataPackage
    {
        public LoanResultModel summaryResults { get; set; }
        public List<LoanByState> loanStateData { get; set; }
    }
}
