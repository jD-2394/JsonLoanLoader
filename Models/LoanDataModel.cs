using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverWorkJsonLoader.Models
{
    public class LoanDataModel
    {
        public string LoanGUID { get; set; }
        public string LoanID { get; set; }
        public string BorrowerFirstName { get; set; }
        public string BorrowerLastName { get; set; }
        public string SubjectAddress1 { get; set; }
        public string SubjectAddress2 { get; set; }
        public string SubjectCity { get; set; }
        public string SubjectState { get; set; }
        public string SubjectZip { get; set; }
        public decimal SubjectAppraisedAmount { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal InterestRate { get; set; }
    }
}
