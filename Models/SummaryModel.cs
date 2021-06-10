﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverWorkJsonLoader.Models
{
    public class SummaryModel
    {
        public decimal Sum { get; set; }
        public decimal Average { get; set; }
        public decimal Median { get; set; }
        public decimal Minimum { get; set; }
        public decimal Maximum { get; set; }
    }
}
