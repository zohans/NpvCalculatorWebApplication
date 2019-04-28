using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NpvWebApplication.Models
{
    public partial class NpvInput
    {
        public decimal Cash { get; set; }
        public decimal CashSeries { get; set; }
        public decimal LowerBound { get; set; }
        public decimal UpperBound { get; set; }
        public decimal DiscountRate { get; set; }
    }
}