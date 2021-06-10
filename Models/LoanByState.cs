using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverWorkJsonLoader.Models
{
    public class LoanByState
    {
        public string LoanState { get; set; }
        public List<LoanDataModel> StateLoanData { get; set; }
        public LoanResultModel StateData { get; set; }
    }
}
